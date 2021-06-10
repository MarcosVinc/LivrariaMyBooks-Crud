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
    public partial class TelaInicial : Form
    {
        
        public TelaInicial()
        {
            InitializeComponent();
            Customizacao();
        }

        private void Customizacao() 
        {
            SubPainelCadastro.Visible = false;
        }

        private void EsconderSubMenu() 
        {
            if (SubPainelCadastro.Visible == true)
                SubPainelCadastro.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu) 
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else 
            
                subMenu.Visible = false;
            
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(SubPainelCadastro);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            AddLivros addL = new AddLivros();
            addL.Show();
            
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.instagram.com/marcosl.xs/?hl=pt-br");
        }

        private void btTelaInicial_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAltExcLivros f2 = new FormAltExcLivros();
            f2.Show();
        }
    }
}
