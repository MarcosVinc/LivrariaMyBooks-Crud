using MyBooksRepositorios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksServiços.Modelo
{
    public class LogimComandos
    {
        public bool tem = false;
        public string mensagem = "";
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public bool verificarLogin(string login, string senha) 
        {

            cmd.CommandText = "select * from Usuarios where Logim = @Login and Senha = @Senha";
            cmd.Parameters.AddWithValue("@Login", login);
            cmd.Parameters.AddWithValue("@Senha", senha);

            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                { tem = true; }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados";
            }

            return tem;
        }
    }
}
