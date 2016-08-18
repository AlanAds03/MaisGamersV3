namespace teste
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogatinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finançasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenuCadastro = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMenuLocacao = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lembretesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlMenuCadastro.SuspendLayout();
            this.pnlMenuLocacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.locacaoToolStripMenuItem,
            this.jogatinaToolStripMenuItem,
            this.orçamentoToolStripMenuItem,
            this.finançasToolStripMenuItem,
            this.lembretesToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // locacaoToolStripMenuItem
            // 
            this.locacaoToolStripMenuItem.Name = "locacaoToolStripMenuItem";
            this.locacaoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.locacaoToolStripMenuItem.Text = "&Locacao";
            this.locacaoToolStripMenuItem.Click += new System.EventHandler(this.locacaoToolStripMenuItem_Click);
            // 
            // jogatinaToolStripMenuItem
            // 
            this.jogatinaToolStripMenuItem.Name = "jogatinaToolStripMenuItem";
            this.jogatinaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.jogatinaToolStripMenuItem.Text = "Jogatina";
            // 
            // orçamentoToolStripMenuItem
            // 
            this.orçamentoToolStripMenuItem.Name = "orçamentoToolStripMenuItem";
            this.orçamentoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.orçamentoToolStripMenuItem.Text = "Orçamento";
            // 
            // finançasToolStripMenuItem
            // 
            this.finançasToolStripMenuItem.Name = "finançasToolStripMenuItem";
            this.finançasToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.finançasToolStripMenuItem.Text = "Finanças";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // pnlMenuCadastro
            // 
            this.pnlMenuCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenuCadastro.Controls.Add(this.button2);
            this.pnlMenuCadastro.Controls.Add(this.button1);
            this.pnlMenuCadastro.Location = new System.Drawing.Point(0, 24);
            this.pnlMenuCadastro.Name = "pnlMenuCadastro";
            this.pnlMenuCadastro.Size = new System.Drawing.Size(905, 87);
            this.pnlMenuCadastro.TabIndex = 2;
            this.pnlMenuCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenuCadastro_Paint);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::MaisGamersV2.Properties.Resources._8394_32x32;
            this.button2.Location = new System.Drawing.Point(93, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::MaisGamersV2.Properties.Resources._1_128x128;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlMenuLocacao
            // 
            this.pnlMenuLocacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenuLocacao.Controls.Add(this.pictureBox2);
            this.pnlMenuLocacao.Location = new System.Drawing.Point(0, 117);
            this.pnlMenuLocacao.Name = "pnlMenuLocacao";
            this.pnlMenuLocacao.Size = new System.Drawing.Size(905, 101);
            this.pnlMenuLocacao.TabIndex = 3;
            this.pnlMenuLocacao.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenuLocacao_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MaisGamersV2.Properties.Resources._11292_32x32;
            this.pictureBox2.Location = new System.Drawing.Point(25, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lembretesToolStripMenuItem
            // 
            this.lembretesToolStripMenuItem.Name = "lembretesToolStripMenuItem";
            this.lembretesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.lembretesToolStripMenuItem.Text = "Lembretes";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 372);
            this.Controls.Add(this.pnlMenuLocacao);
            this.Controls.Add(this.pnlMenuCadastro);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mais Gamers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMenuCadastro.ResumeLayout(false);
            this.pnlMenuLocacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMenuCadastro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlMenuLocacao;
        private System.Windows.Forms.ToolStripMenuItem locacaoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem orçamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finançasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogatinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lembretesToolStripMenuItem;
    }
}

