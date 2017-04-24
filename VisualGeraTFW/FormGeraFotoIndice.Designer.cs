namespace VisualGeraTFW
{
    partial class FormGeraFotoIndice
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
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxOffsetTexto = new System.Windows.Forms.TextBox();
            this.buttonCriarArquivoFotoIndice = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Offset do texto (m):";
            // 
            // textBoxOffsetTexto
            // 
            this.textBoxOffsetTexto.Location = new System.Drawing.Point(134, 22);
            this.textBoxOffsetTexto.Name = "textBoxOffsetTexto";
            this.textBoxOffsetTexto.Size = new System.Drawing.Size(85, 20);
            this.textBoxOffsetTexto.TabIndex = 11;
            this.textBoxOffsetTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOffsetTexto_KeyPress);
            // 
            // buttonCriarArquivoFotoIndice
            // 
            this.buttonCriarArquivoFotoIndice.Location = new System.Drawing.Point(75, 58);
            this.buttonCriarArquivoFotoIndice.Name = "buttonCriarArquivoFotoIndice";
            this.buttonCriarArquivoFotoIndice.Size = new System.Drawing.Size(96, 23);
            this.buttonCriarArquivoFotoIndice.TabIndex = 13;
            this.buttonCriarArquivoFotoIndice.Text = "Criar arquivo";
            this.buttonCriarArquivoFotoIndice.UseVisualStyleBackColor = true;
            this.buttonCriarArquivoFotoIndice.Click += new System.EventHandler(this.buttonCriarArquivoFotoIndice_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Arquivos de texto (*.txt)|*.txt";
            // 
            // FormGeraFotoIndice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 102);
            this.Controls.Add(this.buttonCriarArquivoFotoIndice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxOffsetTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGeraFotoIndice";
            this.Text = "Gerar arquivo para foto índice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxOffsetTexto;
        private System.Windows.Forms.Button buttonCriarArquivoFotoIndice;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}