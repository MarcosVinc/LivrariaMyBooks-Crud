using MyBooksEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksRepositorios
{
    public class RepositorioLivro
    {


        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";
        public void Salvar(Livros livros)
        {
            //comando Sql --SqlComand
            cmd.CommandText = "insert into Livros values(@IdLivro, @Atuacao,@Titulo, @Autor,@Editora, @Edicao, @Volume)";
            //parametros
            cmd.Parameters.AddWithValue("@IdLivro", livros.IdLivro);
            cmd.Parameters.AddWithValue("@Atuacao", livros.Atuacao);
            cmd.Parameters.AddWithValue("@Titulo", livros.Titulo);
            cmd.Parameters.AddWithValue("@Autor", livros.Autor);
            cmd.Parameters.AddWithValue("@Editora", livros.Editora);
            cmd.Parameters.AddWithValue("@Edicao", livros.Edicao);
            cmd.Parameters.AddWithValue("@Volume", livros.Volume);



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



        public List<Livros> Consulta()
        {
            var livro = new List<Livros>();

            cmd.CommandText = "select * from Livros";

            try
            {
                cmd.Connection = conexao.conectar();
                SqlDataReader read = cmd.ExecuteReader();
                //executar comando
                while (read.Read())
                {
                    Livros x = new Livros();
                    x.IdLivro = (string)read["IdLivro"];
                    x.Atuacao = (string)read["Atuacao"];
                    x.Titulo = (string)read["Titulo"];
                    x.Autor = (string)read["Autor"];
                    x.Editora = (string)read["Editora"];
                    x.Edicao = int.Parse(read["Edicao"].ToString(), System.Globalization.CultureInfo.InvariantCulture);
                    x.Volume = int.Parse(read["Volume"].ToString(), System.Globalization.CultureInfo.InvariantCulture);
                    livro.Add(x);
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

            return livro;

        }

        public void Alterar(Livros alterarLivro)
        {
            //comando Sql --SqlComand
            cmd.CommandText = "Update Livros set Atuacao = @atuacao, Titulo = @titulo, Autor = @autor , Editora = @editora, Edicao = @edicao, Volume = @volume where IdLivro = @idlivro";
            //parametros
            cmd.Parameters.AddWithValue("@idlivro", alterarLivro.IdLivro);
            cmd.Parameters.AddWithValue("@atuacao", alterarLivro.Atuacao);
            cmd.Parameters.AddWithValue("@titulo", alterarLivro.Titulo);
            cmd.Parameters.AddWithValue("@autor", alterarLivro.Autor);
            cmd.Parameters.AddWithValue("@editora", alterarLivro.Editora);
            cmd.Parameters.AddWithValue("@edicao", alterarLivro.Edicao);
            cmd.Parameters.AddWithValue("@volume", alterarLivro.Volume);

            //conectar com banco -- Conexao
            try
            {
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                // mostrar mensagem de erro ou sucesso
                this.mensagem = "alterada com sucasso";

            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }

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
                this.mensagem = "Excluida com sucesso";

            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
            }

        }
    }
}
