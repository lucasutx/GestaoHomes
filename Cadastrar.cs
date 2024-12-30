using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homes2
{
    public class Cadastrar
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String msg = "";

        public Cadastrar(String nome, String endereco, String preco ) 
        {
            cmd.CommandText = "insert into Evento (nome, endereco, preco,data_Cadastro) values(@nome, @endereco, @preco,@data_Cadastro)";
            DateTime data = DateTime.Now;
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@data_Cadastro", data);

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
