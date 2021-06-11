using MyBooksEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksRepositorios
{
    public class RepositorioRequisitante
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";
        public void Salvar(Requisitante usuario)
        {
            //comando Sql --SqlComand
            cmd.CommandText = "insert into Requisitante values(@IDrequisitante, @Nome,@Telefone,@Email,@Livro,@Volume)";
            //parametros
            cmd.Parameters.AddWithValue("@IDrequisitante", usuario.IDrequisitante);
            cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@Telefone", usuario.Telefone);
            cmd.Parameters.AddWithValue("@Email", usuario.Email);
            cmd.Parameters.AddWithValue("@Livro", usuario.Livro);
            cmd.Parameters.AddWithValue("@Volume", usuario.Volume);
            //conectar com banco -- Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                // mostrar mensagem de erro ou sucesso
                this.mensagem = "Registro da Doação feita com sucesso";

            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }
        }
        public List<Requisitante> Consulta()
        {
            var usuario = new List<Requisitante>();

            cmd.CommandText = "select * from Usuario";

            try
            {
                cmd.Connection = conexao.conectar();
                SqlDataReader read = cmd.ExecuteReader();
                //executar comando
                while (read.Read())
                {
                    Requisitante x = new Requisitante();
                    x.IDrequisitante = (string)read["IDrequisitante"];
                    x.Nome = (string)read["Nome"];
                    x.Telefone = (string)read["Telefone"];
                    x.Email = (string)read["Email"];
                    x.Livro = (string)read["Livro"];
                    x.Volume = int.Parse(read["Volume"].ToString(), System.Globalization.CultureInfo.InvariantCulture);                  
                    usuario.Add(x);
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

            return usuario;

        }

        public void Deletar(Livros deletarLivro)
        {
            //comando Sql --SqlComand
            cmd.CommandText = "DELETE FROM Livros WHERE IdLivro = @IdLivro;"; ;
            //parametros
            cmd.Parameters.AddWithValue("@IdLivro", deletarLivro.IdLivro);

            //conectar com banco -- Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                // mostrar mensagem de erro ou sucesso
                this.mensagem = "Livro doado com sucesso!";

            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }

        }
    }
}
