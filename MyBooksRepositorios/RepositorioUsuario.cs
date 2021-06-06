using MyBooksEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksRepositorios
{
    public class RepositorioUsuario
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";
        public void Salvar(LoginUsuarios usuario)
        {
            //comando Sql --SqlComand
            cmd.CommandText = "insert into Usuario values(@Identificador, @Logim,@Senha)";
            //parametros
            cmd.Parameters.AddWithValue("@identificador", usuario.ID);
            cmd.Parameters.AddWithValue("@Logim", usuario.Login);
            cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
            //conectar com banco -- Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                // mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com sucesso";

            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }
        }
        public List<LoginUsuarios> Consulta()
        {
            var produto = new List<LoginUsuarios>();

            cmd.CommandText = "select * from Usuario";

            try
            {
                cmd.Connection = conexao.conectar();
                SqlDataReader read = cmd.ExecuteReader();
                //executar comando
                while (read.Read())
                {
                    LoginUsuarios x = new LoginUsuarios();
                    x.ID = (string)read["ID"];
                    x.Login = (string)read["Login"];
                    x.Senha = (string)read["Senha"];
                    produto.Add(x);
                }

                read.Close();
                //desconectar
                conexao.desconectar();
                // mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com sucesso";

            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }

            return produto;

        }

    }
}
