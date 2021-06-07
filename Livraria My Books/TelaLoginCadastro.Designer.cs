
namespace Livraria_My_Books
{
    partial class TelaLoginCadastro
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txLoginC = new System.Windows.Forms.TextBox();
            this.txtEmailC = new System.Windows.Forms.TextBox();
            this.txtSenhaC = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // txLoginC
            // 
            this.txLoginC.Location = new System.Drawing.Point(77, 116);
            this.txLoginC.Name = "txLoginC";
            this.txLoginC.Size = new System.Drawing.Size(240, 23);
            this.txLoginC.TabIndex = 4;
            // 
            // txtEmailC
            // 
            this.txtEmailC.Location = new System.Drawing.Point(77, 199);
            this.txtEmailC.Name = "txtEmailC";
            this.txtEmailC.Size = new System.Drawing.Size(243, 23);
            this.txtEmailC.TabIndex = 5;
            // 
            // txtSenhaC
            // 
            this.txtSenhaC.Location = new System.Drawing.Point(76, 159);
            this.txtSenhaC.Name = "txtSenhaC";
            this.txtSenhaC.Size = new System.Drawing.Size(241, 23);
            this.txtSenhaC.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Livraria_My_Books.Properties.Resources.baseline_chevron_left_black_24dp;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // TelaLoginCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(373, 347);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSenhaC);
            this.Controls.Add(this.txtEmailC);
            this.Controls.Add(this.txLoginC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(389, 386);
            this.MinimumSize = new System.Drawing.Size(389, 386);
            this.Name = "TelaLoginCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaLoginCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txLoginC;
        private System.Windows.Forms.TextBox txtEmailC;
        private System.Windows.Forms.TextBox txtSenhaC;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}