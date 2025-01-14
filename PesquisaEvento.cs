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
                        if (reader.Read())
                        {
                            // Ajuste o nome da coluna conforme a tabela do banco
                            Resultado1 = reader["nomeCliente"].ToString();
                            Resultado2 = reader["endereco"].ToString();

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
