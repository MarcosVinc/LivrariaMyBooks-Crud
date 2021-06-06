using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooksEntidades
{
    public class LoginUsuarios
    {
        public string ID { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }


        public LoginUsuarios(string login, string senha)
        {
            Login = login;
            Senha = senha;

        }

        public LoginUsuarios()
        {
            ID = Guid.NewGuid().ToString();
        }
   
}

   
}
