namespace panorama
{
    partial class historico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(historico));
            dataGridHistorico = new DataGridView();
            lbl_cadastrar = new Label();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            btn_voltar = new PictureBox();
            btn_novo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridHistorico).BeginInit();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_voltar).BeginInit();
            SuspendLayout();
            // 
            // dataGridHistorico
            // 
            dataGridHistorico.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHistorico.GridColor = Color.Black;
            dataGridHistorico.Location = new Point(244, 69);
            dataGridHistorico.Margin = new Padding(3, 4, 3, 4);
            dataGridHistorico.Name = "dataGridHistorico";
            dataGridHistorico.ReadOnly = true;
            dataGridHistorico.RowHeadersWidth = 51;
            dataGridHistorico.Size = new Size(914, 516);
            dataGridHistorico.TabIndex = 0;
            // 
            // lbl_cadastrar
            // 
            lbl_cadastrar.AccessibleRole = AccessibleRole.None;
            lbl_cadastrar.AutoSize = true;
            lbl_cadastrar.BackColor = Color.CadetBlue;
            lbl_cadastrar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cadastrar.ForeColor = Color.White;
            lbl_cadastrar.Location = new Point(603, 9);
            lbl_cadastrar.Name = "lbl_cadastrar";
            lbl_cadastrar.RightToLeft = RightToLeft.No;
            lbl_cadastrar.Size = new Size(164, 38);
            lbl_cadastrar.TabIndex = 8;
            lbl_cadastrar.Text = "HISTÓRICO";
            lbl_cadastrar.UseMnemonic = false;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.CadetBlue;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem11 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(7, 3, 0, 3);
            menuStrip2.Size = new Size(1377, 30);
            menuStrip2.TabIndex = 6;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4 });
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(47, 24);
            toolStripMenuItem1.Text = " ";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Image = (Image)resources.GetObject("toolStripMenuItem3.Image");
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(138, 26);
            toolStripMenuItem3.Text = "home";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Image = (Image)resources.GetObject("toolStripMenuItem4.Image");
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(138, 26);
            toolStripMenuItem4.Text = "Pedido";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, cadastrarToolStripMenuItem1 });
            toolStripMenuItem11.Image = (Image)resources.GetObject("toolStripMenuItem11.Image");
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(47, 24);
            toolStripMenuItem11.Text = " ";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Image = (Image)resources.GetObject("loginToolStripMenuItem.Image");
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(155, 26);
            loginToolStripMenuItem.Text = "Login";
            // 
            // cadastrarToolStripMenuItem1
            // 
            cadastrarToolStripMenuItem1.Image = (Image)resources.GetObject("cadastrarToolStripMenuItem1.Image");
            cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            cadastrarToolStripMenuItem1.Size = new Size(155, 26);
            cadastrarToolStripMenuItem1.Text = "Cadastrar";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.CadetBlue;
            pictureBox2.Location = new Point(-10, 28);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1375, 33);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btn_voltar
            // 
            btn_voltar.Image = (Image)resources.GetObject("btn_voltar.Image");
            btn_voltar.Location = new Point(-10, 51);
            btn_voltar.Margin = new Padding(3, 4, 3, 4);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(1375, 611);
            btn_voltar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_voltar.TabIndex = 23;
            btn_voltar.TabStop = false;
            // 
            // btn_novo
            // 
            btn_novo.BackColor = Color.FromArgb(0, 64, 64);
            btn_novo.FlatStyle = FlatStyle.Flat;
            btn_novo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_novo.ForeColor = SystemColors.ButtonHighlight;
            btn_novo.Location = new Point(617, 604);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(133, 41);
            btn_novo.TabIndex = 26;
            btn_novo.Text = "VOLTAR";
            btn_novo.UseVisualStyleBackColor = false;
            btn_novo.Click += btn_novo_Click;
            // 
            // historico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 657);
            Controls.Add(btn_novo);
            Controls.Add(lbl_cadastrar);
            Controls.Add(menuStrip2);
            Controls.Add(dataGridHistorico);
            Controls.Add(pictureBox2);
            Controls.Add(btn_voltar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "historico";
            Text = "historico";
            WindowState = FormWindowState.Maximized;
            Load += historico_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridHistorico).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_voltar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridHistorico;
        private Label lbl_cadastrar;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem1;
        private PictureBox pictureBox2;
        private PictureBox btn_voltar;
        private Button btn_novo;
    }
}