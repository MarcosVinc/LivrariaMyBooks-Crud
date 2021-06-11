using MyBooksServiços.Modelo;
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
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private void metroButton2_Click(object sender, EventArgs e)
        {
            TelaCadastroUsuario tc = new TelaCadastroUsuario();
            this.Hide();
            tc.Show();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtUsuario.Text, txtSenhaU.Text);

            if (controle.mensagem.Equals(""))
            {

                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MyBooks tt = new MyBooks();
                    this.Hide();
                    tt.Show();

                }
                else
                {
                    MessageBox.Show("Logim ou senha estão incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
