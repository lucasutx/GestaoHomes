using System;
using System.Data.SqlClient;

namespace Homes2
{
    public class PesquisaEvento
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string msg = "";
        public string Resultado1 = "";
        public string Resultado2 = "";
        public Dictionary<string, string> Resultados = new Dictionary<string, string>();

        public PesquisaEvento(string data_Evento)
        {
            cmd.CommandText = "SELECT * FROM Agendamento WHERE data_Evento = @data_evento";
            cmd.Parameters.AddWithValue("@data_evento", data_Evento);

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
                            string colunaEndereco = reader.GetName(4);// Nome da coluna
                            string valorNome = reader[colunaNome]?.ToString() ?? "";
                            string valorEndereco = reader[colunaEndereco]?.ToString() ?? "";

                            Resultados[valorNome] = valorEndereco;

                        }
                    }
                    else
                    {
                        Resultado1 = "Nenhum evento encontrado para a data informada.";
                    }
                }

                // Desconecta fora do using
                conexao.Desconectar();
                this.msg = "Pesquisa realizada com sucesso";
            }
            catch (Exception ex)
            {
                this.msg = "Erro ao realizar a pesquisa: " + ex.Message;
            }
        }
    }
}
