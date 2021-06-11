using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksEntidades
{
    public class Requisitante
    {
        public string IDrequisitante { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Livro { get; set; }
        public int Volume { get; set; }

        public Requisitante(string nome, string telefone, string email, string livro, int volume)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Livro = livro;
            Volume = volume;
        }
        public Requisitante()
        {
            IDrequisitante = Guid.NewGuid().ToString();
        }
    }
}
