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
            PainelSubMenuCadastro.Visible = false;
            //panel3.Visible = false;
            //panel4.Visible = false;
         
        }

        private void HideSubMenu() 
        {
            if (PainelSubMenuCadastro.Visible == true)
                PainelSubMenuCadastro.Visible = false;
           /* if (panel3.Visible == true)
                panel3.Visible = false;
            if (panel4.Visible == true)
                panel4.Visible = false;*/
        }

        private void showSubMenu(Panel subMenu) 
        {

            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else 
            {
                subMenu.Visible = false;
            }
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            showSubMenu(PainelSubMenuCadastro);
        }

        private void btLivrosCadastro_Click(object sender, EventArgs e)
        {
            userControl11.Show();
        }
    }

}
