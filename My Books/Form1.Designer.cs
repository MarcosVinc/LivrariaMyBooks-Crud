
namespace My_Books
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        [System.Obsolete]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSenhaU = new MetroFramework.Controls.MetroTextBox();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 181);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Logim :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 232);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Senha :";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(94, 314);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(203, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Entrar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clique aqui !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Esqueceu a senha ?";
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DimGray;
            this.metroButton2.Location = new System.Drawing.Point(94, 372);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(203, 23);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Criar uma nova conta";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Feito por Marcos Nascimento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtSenhaU
            // 
            // 
            // 
            // 
            this.txtSenhaU.CustomButton.Image = null;
            this.txtSenhaU.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtSenhaU.CustomButton.Name = "";
            this.txtSenhaU.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSenhaU.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenhaU.CustomButton.TabIndex = 1;
            this.txtSenhaU.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenhaU.CustomButton.UseSelectable = true;
            this.txtSenhaU.CustomButton.Visible = false;
            this.txtSenhaU.Icon = global::My_Books.Properties.Resources.baseline_account_circle_black_24dp;
            this.txtSenhaU.Lines = new string[0];
            this.txtSenhaU.Location = new System.Drawing.Point(94, 232);
            this.txtSenhaU.MaxLength = 32767;
            this.txtSenhaU.Name = "txtSenhaU";
            this.txtSenhaU.PasswordChar = '*';
            this.txtSenhaU.PromptText = "Senha";
            this.txtSenhaU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenhaU.SelectedText = "";
            this.txtSenhaU.SelectionLength = 0;
            this.txtSenhaU.SelectionStart = 0;
            this.txtSenhaU.ShortcutsEnabled = true;
            this.txtSenhaU.Size = new System.Drawing.Size(203, 23);
            this.txtSenhaU.TabIndex = 5;
            this.txtSenhaU.UseSelectable = true;
            this.txtSenhaU.WaterMark = "Senha";
            this.txtSenhaU.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenhaU.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Icon = global::My_Books.Properties.Resources.baseline_account_circle_black_24dp;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(94, 181);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PromptText = "Usuario";
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(203, 23);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMark = "Usuario";
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtSenhaU);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtUsuario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(364, 416);
            this.MinimumSize = new System.Drawing.Size(364, 416);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox txtSenhaU;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

