
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCadastrarLivros = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btCadastrarLivros);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 609);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 101);
            this.panel2.TabIndex = 0;
            // 
            // btCadastrarLivros
            // 
            this.btCadastrarLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCadastrarLivros.FlatAppearance.BorderSize = 0;
            this.btCadastrarLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarLivros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCadastrarLivros.Image = global::My_Books.Properties.Resources.outline_book_white_24dp;
            this.btCadastrarLivros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrarLivros.Location = new System.Drawing.Point(0, 101);
            this.btCadastrarLivros.Name = "btCadastrarLivros";
            this.btCadastrarLivros.Size = new System.Drawing.Size(146, 60);
            this.btCadastrarLivros.TabIndex = 1;
            this.btCadastrarLivros.Text = "Cadastro";
            this.btCadastrarLivros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrarLivros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCadastrarLivros.UseVisualStyleBackColor = true;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 624);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1149, 624);
            this.MinimumSize = new System.Drawing.Size(1149, 624);
            this.Name = "TelaInicial";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btCadastrarLivros;
    }
}