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
                string query = "SELECT Categoria,SUM(Valor) as total FROM Despesas WHERE Data BETWEEN @DataInicial AND @DataFinal GROUP BY Categoria;";
                string queryLucro = "SELECT nomeCliente, endereco, Valor AS Valor FROM Agendamento WHERE data_Evento BETWEEN @DataInicial AND @DataFinal";
                string queryReceitas = "SELECT SUM(Valor) AS TotalReceitas FROM Agendamento WHERE data_Evento BETWEEN @DataInicial AND @DataFinal";
                string queryDespesas = "SELECT SUM(valor) AS TotalDespesas FROM Despesas WHERE data BETWEEN @DataInicial AND @DataFinal";

                decimal totalReceitas = 0;
                decimal totalDespesas = 0;
                decimal total = 0;

                using (SqlConnection conn = conexao.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DataInicial", dataInicial);
                        cmd.Parameters.AddWithValue("@DataFinal", dataFinal);

                        object resultado = cmd.ExecuteScalar();
                        
                    }

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

                        // Adiciona o título do relatório
                        document.Add(new Paragraph("Relatório de Lucro Mensal")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(20)
                           
                            .SetMarginBottom(10));

                        document.Add(new Paragraph($"Período: {dataInicial:dd/MM/yyyy} a {dataFinal:dd/MM/yyyy}")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(12)
                            .SetMarginBottom(20));

                        // Eventos do período
                        document.Add(new Paragraph("Eventos do Período")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(14)
                            
                            .SetMarginBottom(10));

                        // Criação e estilização da tabela de eventos
                        Table tabelaEventos = new Table(3);
                        tabelaEventos.SetWidth(UnitValue.CreatePercentValue(100))
                                     .SetMarginBottom(20);
                        tabelaEventos.AddHeaderCell(new Cell().Add(new Paragraph("Nome do Cliente").SetTextAlignment(TextAlignment.CENTER)));
                        tabelaEventos.AddHeaderCell(new Cell().Add(new Paragraph("Endereço").SetTextAlignment(TextAlignment.CENTER)));
                        tabelaEventos.AddHeaderCell(new Cell().Add(new Paragraph("Valor").SetTextAlignment(TextAlignment.CENTER)));

                        // Preenche a tabela de eventos
                        using (SqlConnection conn = new Conexao().Conectar())
                        {
                            using (SqlCommand cmdLucro = new SqlCommand(queryLucro, conn))
                            {
                                cmdLucro.Parameters.AddWithValue("@DataInicial", dataInicial);
                                cmdLucro.Parameters.AddWithValue("@DataFinal", dataFinal);

                                using (SqlDataReader leitor = cmdLucro.ExecuteReader())
                                {
                                    while (leitor.Read())
                                    {
                                        tabelaEventos.AddCell(new Cell().Add(new Paragraph(leitor["nomeCliente"].ToString()).SetTextAlignment(TextAlignment.LEFT)));
                                        tabelaEventos.AddCell(new Cell().Add(new Paragraph(leitor["endereco"].ToString()).SetTextAlignment(TextAlignment.LEFT)));
                                        tabelaEventos.AddCell(new Cell().Add(new Paragraph(Convert.ToDecimal(leitor["valor"]).ToString("C", CultureInfo.CurrentCulture)).SetTextAlignment(TextAlignment.RIGHT)));
                                    }
                                }
                            }
                        }

                        document.Add(tabelaEventos);

                        // Despesas por Categoria
                        document.Add(new Paragraph("Despesas por Categoria")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(14)
                            
                            .SetMarginBottom(10));

                        // Criação e estilização da tabela de despesas
                        Table tabelaDespesas = new Table(2);
                        tabelaDespesas.SetWidth(UnitValue.CreatePercentValue(100))
                                      .SetMarginBottom(20);
                        tabelaDespesas.AddHeaderCell(new Cell().Add(new Paragraph("Categoria").SetTextAlignment(TextAlignment.CENTER)));
                        tabelaDespesas.AddHeaderCell(new Cell().Add(new Paragraph("Valor").SetTextAlignment(TextAlignment.CENTER)));

                        // Preenche a tabela de despesas
                        using (SqlConnection conn = new Conexao().Conectar())
                        {
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@DataInicial", dataInicial);
                                cmd.Parameters.AddWithValue("@DataFinal", dataFinal);

                                using (SqlDataReader leitor = cmd.ExecuteReader())
                                {
                                    while (leitor.Read())
                                    {
                                        tabelaDespesas.AddCell(new Cell().Add(new Paragraph(leitor["Categoria"].ToString()).SetTextAlignment(TextAlignment.LEFT)));
                                        tabelaDespesas.AddCell(new Cell().Add(new Paragraph(Convert.ToDecimal(leitor["total"]).ToString("C", CultureInfo.CurrentCulture)).SetTextAlignment(TextAlignment.RIGHT)));
                                    }
                                }
                            }
                        }

                        document.Add(tabelaDespesas);

                        // Adiciona os totais e o lucro líquido
                        decimal lucroLiquido = totalReceitas - totalDespesas;
                        decimal porcentagemLucro = totalReceitas > 0 ? (lucroLiquido / totalReceitas) * 100 : 0; // Evita divisão por zero

                        document.Add(new Paragraph($"Total de Receitas: {totalReceitas:C}")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(12)
                            .SetMarginBottom(5));

                        document.Add(new Paragraph($"Total de Despesas: {totalDespesas:C}")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(12)
                            .SetMarginBottom(5));

                        document.Add(new Paragraph($"Lucro Líquido: {lucroLiquido:C}")
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(12)
                            
                            .SetMarginBottom(10));

                        document.Add(new Paragraph($"Porcentagem de Lucro: {porcentagemLucro:F2}%")
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(12)
                        .SetMarginBottom(10));

                        // Mensagem final e fechamento do documento
                        document.Add(new Paragraph("Relatório gerado automaticamente.")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(10)
                            
                            .SetMarginTop(20));

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
