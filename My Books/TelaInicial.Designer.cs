
namespace My_Books
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.btCadastro = new System.Windows.Forms.Button();
            this.PainelSubMenuCadastro = new System.Windows.Forms.Panel();
            this.btLivrosCadastro = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControl11 = new My_Books.UserControl1();
            this.PainelSubMenuCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1021, 52);
            this.panel5.TabIndex = 1;
            // 
            // btCadastro
            // 
            this.btCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCadastro.FlatAppearance.BorderSize = 0;
            this.btCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCadastro.Image = global::My_Books.Properties.Resources.outline_book_black_24dp;
            this.btCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastro.Location = new System.Drawing.Point(0, 0);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(175, 56);
            this.btCadastro.TabIndex = 0;
            this.btCadastro.Text = "Cadastro";
            this.btCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCadastro.UseVisualStyleBackColor = true;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // PainelSubMenuCadastro
            // 
            this.PainelSubMenuCadastro.BackColor = System.Drawing.Color.SlateBlue;
            this.PainelSubMenuCadastro.Controls.Add(this.button4);
            this.PainelSubMenuCadastro.Controls.Add(this.button3);
            this.PainelSubMenuCadastro.Controls.Add(this.btLivrosCadastro);
            this.PainelSubMenuCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelSubMenuCadastro.Location = new System.Drawing.Point(0, 56);
            this.PainelSubMenuCadastro.Name = "PainelSubMenuCadastro";
            this.PainelSubMenuCadastro.Size = new System.Drawing.Size(175, 91);
            this.PainelSubMenuCadastro.TabIndex = 1;
            // 
            // btLivrosCadastro
            // 
            this.btLivrosCadastro.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btLivrosCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btLivrosCadastro.FlatAppearance.BorderSize = 0;
            this.btLivrosCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btLivrosCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLivrosCadastro.Location = new System.Drawing.Point(0, 0);
            this.btLivrosCadastro.Name = "btLivrosCadastro";
            this.btLivrosCadastro.Size = new System.Drawing.Size(175, 30);
            this.btLivrosCadastro.TabIndex = 0;
            this.btLivrosCadastro.Text = "Livros";
            this.btLivrosCadastro.UseVisualStyleBackColor = false;
            this.btLivrosCadastro.Click += new System.EventHandler(this.btLivrosCadastro_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "NULL";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 30);
            this.button4.TabIndex = 2;
            this.button4.Text = "NULL";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.PainelSubMenuCadastro);
            this.panel1.Controls.Add(this.btCadastro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 527);
            this.panel1.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(173, 33);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(848, 546);
            this.userControl11.TabIndex = 3;
            this.userControl11.Visible = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 579);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.MaximumSize = new System.Drawing.Size(1037, 618);
            this.MinimumSize = new System.Drawing.Size(1037, 618);
            this.Name = "TelaInicial";
            this.PainelSubMenuCadastro.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Panel PainelSubMenuCadastro;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btLivrosCadastro;
        private System.Windows.Forms.Panel panel1;
        private UserControl1 userControl11;
    }
}