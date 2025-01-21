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
            cmd.CommandText = "SELECT * FROM Agendamento";

            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Data Evento", typeof(string));
            dt.Columns.Add("Valor", typeof(string));


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

                            string colunaNome = reader.GetName(1);
                            string colunaData = reader.GetName(2);// Nome da coluna
                            string colunaValor = reader.GetName(6);
                            string valorNome = reader[colunaNome]?.ToString() ?? "";
                            string valorData = reader[colunaData]?.ToString() ?? "";
                            string valor = reader[colunaValor]?.ToString() ?? "";

                            dt.Rows.Add(valorNome, valorData, valor);
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
    }
}
