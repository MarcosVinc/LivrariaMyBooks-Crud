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
    public partial class Doação2etapa : Form
    {
        BindingList<string> errors = new BindingList<string>();

        public Doação2etapa()
        {
            InitializeComponent();
        }

        private void siticoneCircleButton5_Click(object sender, EventArgs e)
        {

            var y = new Requisitante();
            var repositorio = new RepositorioRequisitante();

            y.Livro = txLivro.Text;
            y.Volume = ConversorDeNumeros.ConvertaStringParaInt(txtVolume.Text, 1);
            y.Nome = txtRequisitante.Text;
            y.Volume = ConversorDeNumeros.ConvertaStringParaInt(txtVolume.Text, 1);
            y.Email = txtRequisitanteEmail.Text;
            y.Telefone = txtRequisitanteTelefone.Text;

            ValidacaoRequisitoB validacao = new ValidacaoRequisitoB();
            ValidationResult x = validacao.Validate(y);
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

                var livro = new Livros();
                var ff = new RepositorioRequisitante();
                livro.IdLivro = txtID.Text;
                repositorio.Deletar(livro);

                repositorio.Salvar(y);
                MessageBox.Show(repositorio.mensagem);
                this.Close();
            }

        }


    }
}
