using Microsoft.VisualBasic;
using System;
using System.Data.SqlClient;

namespace Homes2
{
    public class LucroPorPeriodo
    {
        Conexao conexao = new Conexao();

        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        public String msg;
        public double _somaLucro = 0;
        public double _somaDespesa = 0;
        public double valorLiquido = 0;

        public LucroPorPeriodo(String dataInicio, String Datafim)
        {
            // Corrigindo a forma de passar os parâmetros
            cmd.CommandText = "SELECT SUM(preco) FROM Agendamento WHERE Data_Cadastro BETWEEN @dataInicio AND @dataFim";
            cmd2.CommandText = "SELECT SUM(valor) FROM Despesas WHERE data BETWEEN @dataInicio AND @dataFim";

            // Convertendo as strings para DateTime, para evitar problemas de formato
            DateTime dataInicioConvertida;
            DateTime dataFimConvertida;

            if (!DateTime.TryParseExact(dataInicio, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataInicioConvertida))
            {
                this.msg = "Formato de data de início inválido.";
                return;
            }

            if (!DateTime.TryParseExact(Datafim, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataFimConvertida))
            {
                this.msg = "Formato de data de fim inválido.";
                return;
            }

            // Passando as datas para os parâmetros corretamente
            cmd.Parameters.AddWithValue("@dataInicio", dataInicioConvertida);
            cmd.Parameters.AddWithValue("@dataFim", dataFimConvertida);

            cmd2.Parameters.AddWithValue("@dataInicio", dataInicioConvertida);
            cmd2.Parameters.AddWithValue("@dataFim", dataFimConvertida);

            try
            {
                // Executando a primeira consulta para lucro
                cmd.Connection = conexao.Conectar();
                object resultado = cmd.ExecuteScalar();
                if (resultado != DBNull.Value)
                {
                    _somaLucro = Convert.ToDouble(resultado);
                }
                conexao.Desconectar();

                // Executando a segunda consulta para despesa
                cmd2.Connection = conexao.Conectar();
                object resultado2 = cmd2.ExecuteScalar();
                if (resultado2 != DBNull.Value)
                {
                    _somaDespesa = Convert.ToDouble(resultado2);
                }
                conexao.Desconectar();

                // Calculando o valor líquido
                valorLiquido = (_somaLucro - _somaDespesa);
            }
            catch (SqlException ex)
            {
                this.msg = "Erro na conexão com o banco de dados: " + ex.Message;
            }
        }
    }
}
