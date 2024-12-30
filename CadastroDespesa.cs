using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Homes2
{
    public class CadastroDespesa
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String msg = "";

        public CadastroDespesa(String categoria, String valor)
        {

            cmd.CommandText = "insert into despesas (categoria, valor,data) values(@categoria,@valor,@data)";
            DateTime data = DateTime.Now;
            cmd.Parameters.AddWithValue("@categoria", categoria);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                this.msg = "Cadastrado com sucesso.";

            }
            catch (SqlException ex)
            {
                this.msg = "Erro na conexão com o banco de dados.";
            }
        }
    }
}
