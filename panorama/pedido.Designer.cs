namespace costura
{
    partial class pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pedido));
            pictureBox2 = new PictureBox();
            lbl_pedido = new Label();
            flow_pedidos = new FlowLayoutPanel();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            históricoToolStripMenuItem = new ToolStripMenuItem();
            btn_novo = new Button();
            btn_atualizar = new Button();
            btn_historico = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-105, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1291, 642);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // lbl_pedido
            // 
            lbl_pedido.AccessibleRole = AccessibleRole.None;
            lbl_pedido.Anchor = AnchorStyles.Top;
            lbl_pedido.AutoSize = true;
            lbl_pedido.BackColor = Color.CadetBlue;
            lbl_pedido.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_pedido.ForeColor = Color.White;
            lbl_pedido.Location = new Point(513, 9);
            lbl_pedido.Name = "lbl_pedido";
            lbl_pedido.RightToLeft = RightToLeft.No;
            lbl_pedido.Size = new Size(107, 30);
            lbl_pedido.TabIndex = 28;
            lbl_pedido.Text = "PEDIDOS";
            lbl_pedido.UseMnemonic = false;
            lbl_pedido.Click += lbl_pedido_Click;
            // 
            // flow_pedidos
            // 
            flow_pedidos.Anchor = AnchorStyles.None;
            flow_pedidos.AutoScroll = true;
            flow_pedidos.BackColor = Color.FromArgb(64, 64, 64);
            flow_pedidos.ForeColor = SystemColors.ControlLightLight;
            flow_pedidos.Location = new Point(74, 67);
            flow_pedidos.Name = "flow_pedidos";
            flow_pedidos.Size = new Size(992, 457);
            flow_pedidos.TabIndex = 29;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.CadetBlue;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1183, 28);
            menuStrip2.TabIndex = 30;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, históricoToolStripMenuItem });
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(42, 24);
            toolStripMenuItem1.Text = " ";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = (Image)resources.GetObject("toolStripMenuItem2.Image");
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(184, 26);
            toolStripMenuItem2.Text = "Cadastrar";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Image = (Image)resources.GetObject("toolStripMenuItem3.Image");
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(184, 26);
            toolStripMenuItem3.Text = "home";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // históricoToolStripMenuItem
            // 
            históricoToolStripMenuItem.Image = (Image)resources.GetObject("históricoToolStripMenuItem.Image");
            históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            históricoToolStripMenuItem.Size = new Size(184, 26);
            históricoToolStripMenuItem.Text = "Histórico";
            históricoToolStripMenuItem.Click += históricoToolStripMenuItem_Click;
            // 
            // btn_novo
            // 
            btn_novo.Anchor = AnchorStyles.Bottom;
            btn_novo.BackColor = Color.FromArgb(0, 64, 64);
            btn_novo.FlatStyle = FlatStyle.Flat;
            btn_novo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_novo.ForeColor = SystemColors.ButtonHighlight;
            btn_novo.Location = new Point(487, 543);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(133, 41);
            btn_novo.TabIndex = 25;
            btn_novo.Text = "NOVO";
            btn_novo.UseVisualStyleBackColor = false;
            btn_novo.Click += button1_Click;
            // 
            // btn_atualizar
            // 
            btn_atualizar.Anchor = AnchorStyles.Bottom;
            btn_atualizar.BackColor = Color.Olive;
            btn_atualizar.FlatStyle = FlatStyle.Flat;
            btn_atualizar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_atualizar.ForeColor = SystemColors.ButtonHighlight;
            btn_atualizar.Location = new Point(237, 543);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(133, 41);
            btn_atualizar.TabIndex = 31;
            btn_atualizar.Text = "ATUALIZAR";
            btn_atualizar.UseVisualStyleBackColor = false;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // btn_historico
            // 
            btn_historico.Anchor = AnchorStyles.Bottom;
            btn_historico.BackColor = Color.Navy;
            btn_historico.FlatStyle = FlatStyle.Flat;
            btn_historico.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_historico.ForeColor = SystemColors.ButtonHighlight;
            btn_historico.Location = new Point(754, 543);
            btn_historico.Name = "btn_historico";
            btn_historico.Size = new Size(133, 41);
            btn_historico.TabIndex = 33;
            btn_historico.Text = "HISTÓRICO";
            btn_historico.UseVisualStyleBackColor = false;
            btn_historico.Click += btn_historico_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.CadetBlue;
            pictureBox1.Location = new Point(-493, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2102, 34);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // pedido
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            CausesValidation = false;
            ClientSize = new Size(1183, 659);
            Controls.Add(btn_historico);
            Controls.Add(btn_atualizar);
            Controls.Add(btn_novo);
            Controls.Add(flow_pedidos);
            Controls.Add(lbl_pedido);
            Controls.Add(menuStrip2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "pedido";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "pedido";
            WindowState = FormWindowState.Maximized;
            Load += pedido_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label lbl_pedido;
        private FlowLayoutPanel flow_pedidos;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Button btn_novo;
        private Button btn_atualizar;
        private Button btn_historico;
        private ToolStripMenuItem históricoToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}