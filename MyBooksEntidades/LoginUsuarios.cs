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
        public string Email { get; set; }


        public LoginUsuarios(string login, string senha, string email)
        {
            Login = login;
            Senha = senha;
            Email = email;
        }

        public LoginUsuarios()
        {
            ID = Guid.NewGuid().ToString();
        }
   
}

   
}
