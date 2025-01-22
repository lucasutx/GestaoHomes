using System;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Homes2
{
    public partial class FormValorLiquido : Form
    {
        public FormValorLiquido()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime dataInicial = dtInicio.Value;
            DateTime dataFinal = dtFim.Value;

            // Define o caminho do arquivo PDF
            string caminhoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "RelatorioLucroMensal.pdf");

            try
            {
                // Conexão com o banco de dados
                Conexao conexao = new Conexao();

                // Comandos SQL
                string queryLucro = "SELECT nomeCliente, endereco, Valor AS Valor FROM Agendamento WHERE data_Evento BETWEEN @DataInicial AND @DataFinal";
                string queryReceitas = "SELECT SUM(Valor) AS TotalReceitas FROM Agendamento WHERE data_Evento BETWEEN @DataInicial AND @DataFinal";
                string queryDespesas = "SELECT SUM(valor) AS TotalDespesas FROM Despesas WHERE data BETWEEN @DataInicial AND @DataFinal";

                decimal totalReceitas = 0;
                decimal totalDespesas = 0;

                using (SqlConnection conn = conexao.Conectar())
                {
                    // Calcula total de receitas
                    using (SqlCommand cmdReceitas = new SqlCommand(queryReceitas, conn))
                    {
                        cmdReceitas.Parameters.AddWithValue("@DataInicial", dataInicial);
                        cmdReceitas.Parameters.AddWithValue("@DataFinal", dataFinal);

                        object resultadoReceitas = cmdReceitas.ExecuteScalar();
                        totalReceitas = resultadoReceitas != DBNull.Value ? Convert.ToDecimal(resultadoReceitas) : 0;
                    }

                    // Calcula total de despesas
                    using (SqlCommand cmdDespesas = new SqlCommand(queryDespesas, conn))
                    {
                        cmdDespesas.Parameters.AddWithValue("@DataInicial", dataInicial);
                        cmdDespesas.Parameters.AddWithValue("@DataFinal", dataFinal);

                        object resultadoDespesas = cmdDespesas.ExecuteScalar();
                        totalDespesas = resultadoDespesas != DBNull.Value ? Convert.ToDecimal(resultadoDespesas) : 0;
                    }
                }

                // Cria o documento PDF
                using (PdfWriter writer = new PdfWriter(caminhoArquivo))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        // Adiciona o título
                        document.Add(new Paragraph("Relatório de Lucro Mensal")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(20));

                        document.Add(new Paragraph($"Período: {dataInicial:dd/MM/yyyy} a {dataFinal:dd/MM/yyyy}")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(12));

                        document.Add(new Paragraph("Eventos do Período")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(12));

                        document.Add(new Paragraph("\n"));

                        // Cria uma tabela para os dados do lucro
                        Table tabela = new Table(3);
                        tabela.AddHeaderCell("Nome do Cliente");
                        tabela.AddHeaderCell("Endereço");
                        tabela.AddHeaderCell("Valor");

                        // Conecta ao banco de dados e busca os dados do lucro

                        Conexao conexao1 = new Conexao();
                        using (SqlConnection conn = conexao1.Conectar())
                        {
                            using (SqlCommand cmdLucro = new SqlCommand(queryLucro, conn))
                            {
                                cmdLucro.Parameters.AddWithValue("@DataInicial", dataInicial);
                                cmdLucro.Parameters.AddWithValue("@DataFinal", dataFinal);

                                using (SqlDataReader leitor = cmdLucro.ExecuteReader())
                                {
                                    while (leitor.Read())
                                    {
                                        tabela.AddCell(leitor["nomeCliente"].ToString());
                                        tabela.AddCell(leitor["endereco"].ToString());
                                        tabela.AddCell(leitor["valor"].ToString());
                                    }
                                }
                            }
                        }

                        // Adiciona a tabela ao documento
                        document.Add(tabela);

                        // Adiciona os totais de receitas, despesas e lucro líquido
                        decimal lucroLiquido = totalReceitas - totalDespesas;

                        document.Add(new Paragraph("\n"));
                        document.Add(new Paragraph($"Total de Receitas: {totalReceitas:C}")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(12));

                        document.Add(new Paragraph($"Total de Despesas: {totalDespesas:C}")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(12));

                        document.Add(new Paragraph($"Lucro Líquido: {lucroLiquido:C}")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(12));

                        // Finaliza o documento
                        document.Close();
                    }
                }

                MessageBox.Show("Relatório gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar o relatório: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
