using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksEntidades
{
    public class Livros
    {
        public string IdLivro { get; set; }
        public string Atuacao { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int Edicao { get; set; }
        public int Volume { get; set; }


        public Livros(string _idLivro, string _Atuacao, string _Titulo, string _Autor, string _Editora, int _Edicao, int _Volume) 
        {
            IdLivro = _idLivro;
            Atuacao = _Atuacao;
            Titulo = _Titulo;
            Autor = _Autor;
            Editora = _Editora;
            Edicao = _Edicao;
            Volume = _Volume;
        
        }

        public Livros()
        {
            IdLivro = Guid.NewGuid().ToString();
        }

    }
}
