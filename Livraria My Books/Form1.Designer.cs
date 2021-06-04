
namespace Livraria_My_Books
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btCriar = new System.Windows.Forms.Button();
            this.btRecSenha = new System.Windows.Forms.Button();
            this.btEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 23);
            this.textBox2.TabIndex = 3;
            // 
            // btCriar
            // 
            this.btCriar.Location = new System.Drawing.Point(256, 202);
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(84, 28);
            this.btCriar.TabIndex = 4;
            this.btCriar.Text = "Criar conta";
            this.btCriar.UseVisualStyleBackColor = true;
            // 
            // btRecSenha
            // 
            this.btRecSenha.Location = new System.Drawing.Point(12, 202);
            this.btRecSenha.Name = "btRecSenha";
            this.btRecSenha.Size = new System.Drawing.Size(158, 28);
            this.btRecSenha.TabIndex = 5;
            this.btRecSenha.Text = "Recuperar a senha";
            this.btRecSenha.UseVisualStyleBackColor = true;
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(232, 12);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(108, 40);
            this.btEntrar.TabIndex = 6;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(352, 242);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.btRecSenha);
            this.Controls.Add(this.btCriar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(368, 281);
            this.MinimumSize = new System.Drawing.Size(368, 281);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btCriar;
        private System.Windows.Forms.Button btRecSenha;
        private System.Windows.Forms.Button btEntrar;
    }
}

