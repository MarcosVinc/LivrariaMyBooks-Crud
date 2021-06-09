
namespace My_Books
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtAutor = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtVolume = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtEdicao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbEditora = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtTitulo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbAtuacao = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(721, 512);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.pictureBox2);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.txtAutor);
            this.metroTabPage1.Controls.Add(this.pictureBox1);
            this.metroTabPage1.Controls.Add(this.txtVolume);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.txtEdicao);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.cbEditora);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.txtTitulo);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.cbAtuacao);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(713, 470);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Cadastro";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(633, 424);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(60, 19);
            this.metroLabel10.TabIndex = 19;
            this.metroLabel10.Text = "Cancelar";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::My_Books.Properties.Resources.cancel;
            this.pictureBox2.Location = new System.Drawing.Point(565, 411);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(511, 424);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(48, 19);
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "Gravar";
            // 
            // txtAutor
            // 
            // 
            // 
            // 
            this.txtAutor.CustomButton.Image = null;
            this.txtAutor.CustomButton.Location = new System.Drawing.Point(409, 1);
            this.txtAutor.CustomButton.Name = "";
            this.txtAutor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAutor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAutor.CustomButton.TabIndex = 1;
            this.txtAutor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAutor.CustomButton.UseSelectable = true;
            this.txtAutor.CustomButton.Visible = false;
            this.txtAutor.Lines = new string[0];
            this.txtAutor.Location = new System.Drawing.Point(25, 188);
            this.txtAutor.MaxLength = 32767;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.PasswordChar = '\0';
            this.txtAutor.PromptText = "Nome do Autor";
            this.txtAutor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAutor.SelectedText = "";
            this.txtAutor.SelectionLength = 0;
            this.txtAutor.SelectionStart = 0;
            this.txtAutor.ShortcutsEnabled = true;
            this.txtAutor.Size = new System.Drawing.Size(533, 23);
            this.txtAutor.TabIndex = 20;
            this.txtAutor.UseSelectable = true;
            this.txtAutor.WaterMark = "Nome do Autor";
            this.txtAutor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAutor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_Books.Properties.Resources.diskette1;
            this.pictureBox1.Location = new System.Drawing.Point(443, 411);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtVolume
            // 
            // 
            // 
            // 
            this.txtVolume.CustomButton.Image = null;
            this.txtVolume.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.txtVolume.CustomButton.Name = "";
            this.txtVolume.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVolume.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVolume.CustomButton.TabIndex = 1;
            this.txtVolume.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVolume.CustomButton.UseSelectable = true;
            this.txtVolume.CustomButton.Visible = false;
            this.txtVolume.Lines = new string[0];
            this.txtVolume.Location = new System.Drawing.Point(185, 324);
            this.txtVolume.MaxLength = 32767;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.PasswordChar = '\0';
            this.txtVolume.PromptText = "Volume da edição";
            this.txtVolume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVolume.SelectedText = "";
            this.txtVolume.SelectionLength = 0;
            this.txtVolume.SelectionStart = 0;
            this.txtVolume.ShortcutsEnabled = true;
            this.txtVolume.Size = new System.Drawing.Size(110, 23);
            this.txtVolume.TabIndex = 17;
            this.txtVolume.UseSelectable = true;
            this.txtVolume.WaterMark = "Volume da edição";
            this.txtVolume.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVolume.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(185, 301);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(53, 19);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "Volume";
            // 
            // txtEdicao
            // 
            // 
            // 
            // 
            this.txtEdicao.CustomButton.Image = null;
            this.txtEdicao.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtEdicao.CustomButton.Name = "";
            this.txtEdicao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEdicao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEdicao.CustomButton.TabIndex = 1;
            this.txtEdicao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEdicao.CustomButton.UseSelectable = true;
            this.txtEdicao.CustomButton.Visible = false;
            this.txtEdicao.Lines = new string[0];
            this.txtEdicao.Location = new System.Drawing.Point(25, 324);
            this.txtEdicao.MaxLength = 32767;
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.PasswordChar = '\0';
            this.txtEdicao.PromptText = "Edição do Livro";
            this.txtEdicao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEdicao.SelectedText = "";
            this.txtEdicao.SelectionLength = 0;
            this.txtEdicao.SelectionStart = 0;
            this.txtEdicao.ShortcutsEnabled = true;
            this.txtEdicao.Size = new System.Drawing.Size(142, 23);
            this.txtEdicao.TabIndex = 15;
            this.txtEdicao.UseSelectable = true;
            this.txtEdicao.WaterMark = "Edição do Livro";
            this.txtEdicao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEdicao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(25, 302);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(48, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Edição";
            // 
            // cbEditora
            // 
            this.cbEditora.FormattingEnabled = true;
            this.cbEditora.ItemHeight = 23;
            this.cbEditora.Items.AddRange(new object[] {
            "Companhia da Letras",
            "Aleph",
            "Suma",
            "Editora Intrínseca",
            "Grupo Editorial Record",
            "Editora Rocco",
            "Globo Livros",
            "Darkside Books",
            "Haper Collins",
            "Nerd Book",
            "Editora Arqueiro",
            "Leya",
            "Saraiva",
            "FTD",
            "Sextante",
            "Gente"});
            this.cbEditora.Location = new System.Drawing.Point(25, 253);
            this.cbEditora.Name = "cbEditora";
            this.cbEditora.Size = new System.Drawing.Size(533, 29);
            this.cbEditora.Style = MetroFramework.MetroColorStyle.Green;
            this.cbEditora.TabIndex = 13;
            this.cbEditora.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(25, 231);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Editora";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(25, 166);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(103, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Nome do Autor";
            // 
            // txtTitulo
            // 
            // 
            // 
            // 
            this.txtTitulo.CustomButton.Image = null;
            this.txtTitulo.CustomButton.Location = new System.Drawing.Point(409, 1);
            this.txtTitulo.CustomButton.Name = "";
            this.txtTitulo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitulo.CustomButton.TabIndex = 1;
            this.txtTitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitulo.CustomButton.UseSelectable = true;
            this.txtTitulo.CustomButton.Visible = false;
            this.txtTitulo.Lines = new string[0];
            this.txtTitulo.Location = new System.Drawing.Point(25, 131);
            this.txtTitulo.MaxLength = 32767;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.PromptText = "Título do livro";
            this.txtTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.SelectionLength = 0;
            this.txtTitulo.SelectionStart = 0;
            this.txtTitulo.ShortcutsEnabled = true;
            this.txtTitulo.Size = new System.Drawing.Size(533, 23);
            this.txtTitulo.TabIndex = 7;
            this.txtTitulo.UseSelectable = true;
            this.txtTitulo.WaterMark = "Título do livro";
            this.txtTitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 109);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Título";
            // 
            // cbAtuacao
            // 
            this.cbAtuacao.FormattingEnabled = true;
            this.cbAtuacao.ItemHeight = 23;
            this.cbAtuacao.Items.AddRange(new object[] {
            "Poesia ",
            "Teatral",
            "Romance",
            "Conto",
            "Suspense",
            "Fantasia",
            "Crônica",
            "Fábula",
            "Comédia."});
            this.cbAtuacao.Location = new System.Drawing.Point(25, 73);
            this.cbAtuacao.Name = "cbAtuacao";
            this.cbAtuacao.Size = new System.Drawing.Size(533, 29);
            this.cbAtuacao.Style = MetroFramework.MetroColorStyle.Green;
            this.cbAtuacao.TabIndex = 5;
            this.cbAtuacao.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 51);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Área de atuação";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(728, 517);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        public MetroFramework.Controls.MetroTextBox txtAutor;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroTextBox txtVolume;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        public MetroFramework.Controls.MetroTextBox txtEdicao;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        public MetroFramework.Controls.MetroComboBox cbEditora;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroTextBox txtTitulo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroComboBox cbAtuacao;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}
