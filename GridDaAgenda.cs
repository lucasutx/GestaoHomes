using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homes2
{
    public partial class GridDaAgenda : Form
    {
        public GridDaAgenda()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Agendamento";

            Conexao conexao = new Conexao();

            try
            {
                cmd.Connection = conexao.Conectar();

            }
            catch
            (Exception ex)
            {
            }

        }

        private void GridDaAgenda_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT * FROM Agendamento order by data_evento";

            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("NOME", typeof(string));
            dt.Columns.Add("Data Evento", typeof(string));
            dt.Columns.Add("VALOR", typeof(string));


            dataGridView1.DataSource = dt;

            try
            {
                cmd.Connection = conexao.Conectar();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Verifica se há linhas antes de tentar ler
                    if (reader.HasRows)
                    {
                        while (reader.Read())

                        {
                            Dictionary<string, string> linha = new Dictionary<string, string>();
                            
                            string colunaId = reader.GetName(0);
                            string colunaNome = reader.GetName(1);
                            string colunaData = reader.GetName(2);// Nome da coluna
                            string colunaValor = reader.GetName(6);

                            string valorID = reader[colunaId]?.ToString() ?? "";
                            string valorNome = reader[colunaNome]?.ToString() ?? "";
                            string valorData = reader[colunaData]?.ToString() ?? "";
                            string valor = reader[colunaValor]?.ToString() ?? "";

                            dt.Rows.Add(valorID,valorNome, valorData, valor);
                            dataGridView1.DataSource = dt;

                        }
                    }
                }

                // Desconecta fora do using
                conexao.Desconectar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                int idSelecionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                var confirmacao = MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmacao == DialogResult.Yes)
                {
                    // Remove o registro do banco de dados
                    SqlCommand cmd = new SqlCommand();
                    Conexao conexao = new Conexao();
                    cmd.Connection = conexao.Conectar();
                    
                       cmd.CommandText = "DELETE FROM Agendamento WHERE Id = @Id";

                            cmd.Parameters.AddWithValue("@Id", idSelecionado);
                            cmd.ExecuteNonQuery();

                    // Remove a linha do DataGridView
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                    MessageBox.Show("Registro excluído com sucesso.");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.");
            }
        }
    }
}
