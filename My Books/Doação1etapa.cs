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
    public partial class Doação1etapa : Form
    {
        public Doação1etapa()
        {
            InitializeComponent();
        }

        private void siticoneDataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Doação2etapa f1 = new Doação2etapa();
            f1.txtID.Text = this.siticoneDataGridView1.CurrentRow.Cells[0].Value.ToString();
            f1.txLivro.Text = this.siticoneDataGridView1.CurrentRow.Cells[2].Value.ToString();
            f1.txtVolume.Text = this.siticoneDataGridView1.CurrentRow.Cells[6].Value.ToString();
            f1.ShowDialog();
        }

        private void Doação2etapa_Load(object sender, EventArgs e)
        {
            var x = new RepositorioLivro();
            var livro = x.Consulta();
            siticoneDataGridView1.DataSource = livro;
        }

        private void siticoneDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var x = new RepositorioLivro();
            var livro = x.Consulta();
            siticoneDataGridView1.DataSource = livro;
        }
    }
}
