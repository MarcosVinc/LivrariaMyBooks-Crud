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

namespace My_Books
{
    public partial class TelaCadastroUsuario : MetroFramework.Forms.MetroForm
    {
        BindingList<string> errors = new BindingList<string>();
        FormLogin f1 = new FormLogin();

        public TelaCadastroUsuario()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            f1.Show();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var usuario = new LoginUsuarios();
            var repositorio = new RepositorioUsuario();
            usuario.Login = txtUsuarioC.Text;
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
                this.Close();
                f1.Show();
            }
        }
    }
}
