namespace VisualGeraTFW
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxQuickView = new System.Windows.Forms.CheckBox();
            this.comboBoxCamera = new System.Windows.Forms.ComboBox();
            this.comboBoxGSD = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonTFW = new System.Windows.Forms.RadioButton();
            this.radioButtonJGW = new System.Windows.Forms.RadioButton();
            this.textBoxPs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarArquivosTFWJGWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarDadosDoArquivoImportadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renomearArquivosDeSaídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarArquivoParaFotoÍndiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Arquivos de EO do POSPAC (*.txt *.eo)|*.txt;*.eo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.textBoxPs);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxLy);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxLx);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 195);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parâmetros de exportação";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxQuickView);
            this.groupBox1.Controls.Add(this.comboBoxCamera);
            this.groupBox1.Controls.Add(this.comboBoxGSD);
            this.groupBox1.Location = new System.Drawing.Point(18, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 81);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pré-definições";
            // 
            // checkBoxQuickView
            // 
            this.checkBoxQuickView.AutoSize = true;
            this.checkBoxQuickView.Location = new System.Drawing.Point(122, 51);
            this.checkBoxQuickView.Name = "checkBoxQuickView";
            this.checkBoxQuickView.Size = new System.Drawing.Size(77, 17);
            this.checkBoxQuickView.TabIndex = 13;
            this.checkBoxQuickView.Text = "QuickView";
            this.checkBoxQuickView.UseVisualStyleBackColor = true;
            this.checkBoxQuickView.CheckedChanged += new System.EventHandler(this.checkBoxQuickView_CheckedChanged);
            // 
            // comboBoxCamera
            // 
            this.comboBoxCamera.FormattingEnabled = true;
            this.comboBoxCamera.Items.AddRange(new object[] {
            "UltraCam D",
            "UltraCam Xp",
            "UltraCam Lp",
            "Nikon D610"});
            this.comboBoxCamera.Location = new System.Drawing.Point(30, 24);
            this.comboBoxCamera.Name = "comboBoxCamera";
            this.comboBoxCamera.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCamera.TabIndex = 9;
            this.comboBoxCamera.Text = "Selecione a câmera";
            this.comboBoxCamera.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCamera_SelectionChangeCommitted);
            // 
            // comboBoxGSD
            // 
            this.comboBoxGSD.FormattingEnabled = true;
            this.comboBoxGSD.Items.AddRange(new object[] {
            "4 cm",
            "6 cm",
            "8 cm",
            "10 cm",
            "12 cm",
            "16 cm"});
            this.comboBoxGSD.Location = new System.Drawing.Point(168, 24);
            this.comboBoxGSD.Name = "comboBoxGSD";
            this.comboBoxGSD.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGSD.TabIndex = 12;
            this.comboBoxGSD.Text = "Selecione o GSD";
            this.comboBoxGSD.SelectionChangeCommitted += new System.EventHandler(this.comboBoxGSD_SelectionChangeCommitted);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonTFW);
            this.groupBox4.Controls.Add(this.radioButtonJGW);
            this.groupBox4.Location = new System.Drawing.Point(257, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(84, 80);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Formato";
            // 
            // radioButtonTFW
            // 
            this.radioButtonTFW.AutoSize = true;
            this.radioButtonTFW.Checked = true;
            this.radioButtonTFW.Location = new System.Drawing.Point(17, 26);
            this.radioButtonTFW.Name = "radioButtonTFW";
            this.radioButtonTFW.Size = new System.Drawing.Size(49, 17);
            this.radioButtonTFW.TabIndex = 5;
            this.radioButtonTFW.TabStop = true;
            this.radioButtonTFW.Text = "TFW";
            this.radioButtonTFW.UseVisualStyleBackColor = true;
            this.radioButtonTFW.CheckedChanged += new System.EventHandler(this.radioButtonTFW_CheckedChanged);
            // 
            // radioButtonJGW
            // 
            this.radioButtonJGW.AutoSize = true;
            this.radioButtonJGW.Location = new System.Drawing.Point(17, 49);
            this.radioButtonJGW.Name = "radioButtonJGW";
            this.radioButtonJGW.Size = new System.Drawing.Size(49, 17);
            this.radioButtonJGW.TabIndex = 6;
            this.radioButtonJGW.TabStop = true;
            this.radioButtonJGW.Text = "JGW";
            this.radioButtonJGW.UseVisualStyleBackColor = true;
            this.radioButtonJGW.CheckedChanged += new System.EventHandler(this.radioButtonJGW_CheckedChanged);
            // 
            // textBoxPs
            // 
            this.textBoxPs.Location = new System.Drawing.Point(140, 74);
            this.textBoxPs.Name = "textBoxPs";
            this.textBoxPs.Size = new System.Drawing.Size(100, 20);
            this.textBoxPs.TabIndex = 3;
            this.textBoxPs.TextChanged += new System.EventHandler(this.textBoxLx_TextChanged);
            this.textBoxPs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLx_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tamanho do pixel (m):";
            // 
            // textBoxLy
            // 
            this.textBoxLy.Location = new System.Drawing.Point(140, 48);
            this.textBoxLy.Name = "textBoxLy";
            this.textBoxLy.Size = new System.Drawing.Size(100, 20);
            this.textBoxLy.TabIndex = 2;
            this.textBoxLy.TextChanged += new System.EventHandler(this.textBoxLx_TextChanged);
            this.textBoxLy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLx_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de linhas (yi):";
            // 
            // textBoxLx
            // 
            this.textBoxLx.Location = new System.Drawing.Point(140, 22);
            this.textBoxLx.Name = "textBoxLx";
            this.textBoxLx.Size = new System.Drawing.Size(100, 20);
            this.textBoxLx.TabIndex = 1;
            this.textBoxLx.TextChanged += new System.EventHandler(this.textBoxLx_TextChanged);
            this.textBoxLx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLx_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de colunas (xi):";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(373, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.exportarArquivosTFWJGWToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.importarToolStripMenuItem.Text = "&Importar arquivo EO...";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // exportarArquivosTFWJGWToolStripMenuItem
            // 
            this.exportarArquivosTFWJGWToolStripMenuItem.Enabled = false;
            this.exportarArquivosTFWJGWToolStripMenuItem.Name = "exportarArquivosTFWJGWToolStripMenuItem";
            this.exportarArquivosTFWJGWToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.exportarArquivosTFWJGWToolStripMenuItem.Text = "&Exportar arquivos TFW/JGW...";
            this.exportarArquivosTFWJGWToolStripMenuItem.Click += new System.EventHandler(this.exportarArquivosTFWJGWToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarDadosDoArquivoImportadoToolStripMenuItem,
            this.renomearArquivosDeSaídaToolStripMenuItem,
            this.gerarArquivoParaFotoÍndiceToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "&Ferramentas";
            // 
            // visualizarDadosDoArquivoImportadoToolStripMenuItem
            // 
            this.visualizarDadosDoArquivoImportadoToolStripMenuItem.Name = "visualizarDadosDoArquivoImportadoToolStripMenuItem";
            this.visualizarDadosDoArquivoImportadoToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.visualizarDadosDoArquivoImportadoToolStripMenuItem.Text = "&Visualizar dados do arquivo importado...";
            this.visualizarDadosDoArquivoImportadoToolStripMenuItem.Click += new System.EventHandler(this.visualizarDadosDoArquivoImportadoToolStripMenuItem_Click);
            // 
            // renomearArquivosDeSaídaToolStripMenuItem
            // 
            this.renomearArquivosDeSaídaToolStripMenuItem.Enabled = false;
            this.renomearArquivosDeSaídaToolStripMenuItem.Name = "renomearArquivosDeSaídaToolStripMenuItem";
            this.renomearArquivosDeSaídaToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.renomearArquivosDeSaídaToolStripMenuItem.Text = "&Renomear arquivos de saída...";
            // 
            // gerarArquivoParaFotoÍndiceToolStripMenuItem
            // 
            this.gerarArquivoParaFotoÍndiceToolStripMenuItem.Enabled = false;
            this.gerarArquivoParaFotoÍndiceToolStripMenuItem.Name = "gerarArquivoParaFotoÍndiceToolStripMenuItem";
            this.gerarArquivoParaFotoÍndiceToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.gerarArquivoParaFotoÍndiceToolStripMenuItem.Text = "&Gerar arquivo para foto índice...";
            this.gerarArquivoParaFotoÍndiceToolStripMenuItem.Click += new System.EventHandler(this.gerarArquivoParaFotoÍndiceToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verLogsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "A&juda";
            // 
            // verLogsToolStripMenuItem
            // 
            this.verLogsToolStripMenuItem.Name = "verLogsToolStripMenuItem";
            this.verLogsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verLogsToolStripMenuItem.Text = "&Ver logs";
            this.verLogsToolStripMenuItem.Click += new System.EventHandler(this.verLogsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus,
            this.toolStripProgressBar2});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 229);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(373, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabelStatus.Text = "Pronto";
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(250, 16);
            this.toolStripProgressBar2.Visible = false;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 15);
            // 
            // formMain
            // 
            this.ClientSize = new System.Drawing.Size(373, 251);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.Text = "Gera TFW";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button abreArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonJGW;
        private System.Windows.Forms.RadioButton radioButtonTFW;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox comboBoxCamera;
        private System.Windows.Forms.ComboBox comboBoxGSD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxQuickView;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarArquivoParaFotoÍndiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarArquivosTFWJGWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarDadosDoArquivoImportadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renomearArquivosDeSaídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.TextBox textBoxLy;
        private System.Windows.Forms.TextBox textBoxLx;
        private System.Windows.Forms.TextBox textBoxPs;
    }
}

