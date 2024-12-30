using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homes2
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        //Construtor 
        public Conexao() 
        {
            con.ConnectionString = "Data Source=DESKTOP-LUCAS;Initial Catalog=Pizzaria;Integrated Security=True;Encrypt=False";

        }
        //Conectar
        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();

            }
            return con;
        }
        //Desconectar
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
