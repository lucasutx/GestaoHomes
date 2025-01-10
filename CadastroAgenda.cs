using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homes2
{
    public class CadastroAgenda
    {
        public string msg = "";
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        
        public CadastroAgenda(string nome, string data_evento, string telefone, string endereco, string status, string valor)
        {
            cmd.CommandText = "Insert into Agendamento (nomeCliente,data_Evento,telefone,endereco,status_Evento,valor) " +
                "values (@nome,@data,@telefone,@endereco,@status,@valor)";

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@data", data_evento);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@valor", valor);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.msg = "Cadastrado com sucesso";
            }
            catch(SqlException ex) 
            { 
                this.msg = ex.Message;
            }




        }
    }
}
