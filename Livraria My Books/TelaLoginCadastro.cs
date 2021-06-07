using FluentValidation.Results;
using MyBooksEntidades;
using MyBooksRepositorios;
using MyBooksServiços.Validações;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Livraria_My_Books
{
    public partial class TelaLoginCadastro : Form
    {
        BindingList<string> errors = new BindingList<string>();
        public TelaLoginCadastro()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaLogin formLU = new TelaLogin();
            formLU.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var usuario = new LoginUsuarios();
            var repositorio = new RepositorioUsuario();
            usuario.Login = txLoginC.Text;
            usuario.Senha = txtSenhaC.Text;
            usuario.Email = txtEmailC.Text;
            ValidacaoUsuario validacao = new ValidacaoUsuario();
            ValidationResult x = validacao.Validate(usuario);
            if (x.IsValid == false)
            {
                foreach (ValidationFailure failure in x.Errors)
                {
                    errors.Add($"{failure.PropertyName} : {failure.ErrorMessage}");
                    MessageBox.Show($"Erro ao preencher :{failure.PropertyName}," +
                        $"+ mensagem do erro : {failure.ErrorMessage} ");
                }
            }
            else
            {
                repositorio.Salvar(usuario);
                MessageBox.Show(repositorio.mensagem);
            }


        }
    }
}
