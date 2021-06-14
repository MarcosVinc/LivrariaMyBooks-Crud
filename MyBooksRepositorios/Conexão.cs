using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksRepositorios
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public static System.Configuration.ConnectionStringSettingsCollection ConnectionStrings { get; }

        public Conexao() 
        {
            var connectionString = ConfigurationManager.ConnectionStrings["LivrariaMyBooks"].ConnectionString;
            con.ConnectionString = connectionString;
        }
        public SqlConnection conectar() 
        {

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        } 
    }
}

/*<add name="Configuração de conexão Sql"
	 providerName="Data Source=DESKTOP-DL5R127;Initial Catalog=LivrariaMyBooks;Integrated Security=True"
	 connectionString="Valid Connection String;" />*/