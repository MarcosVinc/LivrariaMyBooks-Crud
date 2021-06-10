using MyBooksRepositorios;
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
    public partial class FormAltExcLivros : Form
    {
        
        public FormAltExcLivros()
        {
            InitializeComponent();
        }

        private void metroGrid1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddLivros f1 = new AddLivros();           
            f1.siticoneCircleButton1.Visible = false;
            f1.siticoneCircleButton2.Visible = false;
            f1.textBox1.Visible = false;
            f1.siticoneCircleButton3.Visible = true;
            f1.siticoneCircleButton4.Visible = true;
            f1.textBox1.Text = this.metroGrid1.CurrentRow.Cells[0].Value.ToString();
            f1.cbAtuacao.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
            f1.txtTitulo.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
            f1.txtAutor.Text = this.metroGrid1.CurrentRow.Cells[3].Value.ToString();
            f1.cbEditora.Text = this.metroGrid1.CurrentRow.Cells[4].Value.ToString();
            f1.txtEdicao.Text= this.metroGrid1.CurrentRow.Cells[5].Value.ToString();
            f1.txtVolume.Text = this.metroGrid1.CurrentRow.Cells[6].Value.ToString();
            f1.ShowDialog();
        }
        
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAltExcLivros_Load(object sender, EventArgs e)
        {
            // Abrir a tabela, ela ja vem atualizada, porém quando haver alteração ou exclusão de itens não aparecera sem atualiza. O que e feito pelo o proximo metodo 
            var x = new RepositorioLivro();
            var livro = x.Consulta();
            metroGrid1.DataSource = livro;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Atualizar a tabela
            var x = new RepositorioLivro();
            var livro = x.Consulta();
            metroGrid1.DataSource = livro;
        }
    }
}
