using FluentValidation.Results;
using MyBooksEntidades;
using MyBooksRepositorios;
using MyBooksServiços.Conversor_de_Tipos;
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
    public partial class UserControl1 : UserControl
    {
        BindingList<string> errors = new BindingList<string>();
        public UserControl1()
        {
            InitializeComponent();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var livro = new Livros();
            var repositorio = new RepositorioLivro();
            livro.Atuacao = cbAtuacao.Text;
            livro.Titulo = txtTitulo.Text;
            livro.Autor = txtAutor.Text;
            livro.Editora = cbEditora.Text;
            livro.Edicao = ConversorDeNumeros.ConvertaStringParaInt(txtEdicao.Text, 1);
            livro.Volume = ConversorDeNumeros.ConvertaStringParaInt(txtVolume.Text, 1);

            ValidacaoLivro validacao = new ValidacaoLivro();
            ValidationResult x = validacao.Validate(livro);
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
                repositorio.Salvar(livro);
                MessageBox.Show(repositorio.mensagem);
            }
        }
    }
}
