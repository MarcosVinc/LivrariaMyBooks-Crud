
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SubPainelCadastro = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btCadastro = new System.Windows.Forms.Button();
            this.btTelaInicial = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SubPainelCadastro.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.SubPainelCadastro);
            this.panel1.Controls.Add(this.btCadastro);
            this.panel1.Controls.Add(this.btTelaInicial);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 584);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::My_Books.Properties.Resources.giphy__1_;
            this.pictureBox2.Location = new System.Drawing.Point(22, 454);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // SubPainelCadastro
            // 
            this.SubPainelCadastro.BackColor = System.Drawing.Color.Honeydew;
            this.SubPainelCadastro.Controls.Add(this.button4);
            this.SubPainelCadastro.Controls.Add(this.button3);
            this.SubPainelCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPainelCadastro.Location = new System.Drawing.Point(0, 184);
            this.SubPainelCadastro.Name = "SubPainelCadastro";
            this.SubPainelCadastro.Size = new System.Drawing.Size(150, 72);
            this.SubPainelCadastro.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.DarkGreen;
            this.button4.Location = new System.Drawing.Point(0, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 36);
            this.button4.TabIndex = 1;
            this.button4.Text = "Alterar / Excluir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.DarkGreen;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = "Cadastrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btCadastro
            // 
            this.btCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCadastro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastro.ForeColor = System.Drawing.Color.White;
            this.btCadastro.Image = global::My_Books.Properties.Resources.outline_post_add_black_18dp;
            this.btCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastro.Location = new System.Drawing.Point(0, 141);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(150, 43);
            this.btCadastro.TabIndex = 2;
            this.btCadastro.Text = "Cadastrar ";
            this.btCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCadastro.UseVisualStyleBackColor = true;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // btTelaInicial
            // 
            this.btTelaInicial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTelaInicial.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.btTelaInicial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTelaInicial.ForeColor = System.Drawing.Color.White;
            this.btTelaInicial.Image = global::My_Books.Properties.Resources.outline_home_black_36dp;
            this.btTelaInicial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTelaInicial.Location = new System.Drawing.Point(0, 98);
            this.btTelaInicial.Name = "btTelaInicial";
            this.btTelaInicial.Size = new System.Drawing.Size(150, 43);
            this.btTelaInicial.TabIndex = 1;
            this.btTelaInicial.Text = "Tela Principal";
            this.btTelaInicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTelaInicial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTelaInicial.UseVisualStyleBackColor = true;
            this.btTelaInicial.Click += new System.EventHandler(this.btTelaInicial_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 98);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::My_Books.Properties.Resources.caooo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(150, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 36);
            this.panel3.TabIndex = 3;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(150, 36);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(874, 548);
            this.webBrowser1.TabIndex = 4;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1024, 584);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaInicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SubPainelCadastro.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SubPainelCadastro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button btTelaInicial;
        public System.Windows.Forms.Button btCadastro;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
    }
}