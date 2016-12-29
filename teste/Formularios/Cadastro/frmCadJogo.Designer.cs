namespace MaisGamers.Formularios.Cadastro
{
    partial class frmCadJogo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbConsolePesquisa = new Frameworks.Componentes.SuperComboBox();
            this.txtPesqNome = new Frameworks.Componentes.SuperTextBox();
            this.lvPesquisa = new Frameworks.Componentes.SuperLV();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.grpGrid = new System.Windows.Forms.GroupBox();
            this.grpBotoes = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPesquisa = new System.Windows.Forms.TabPage();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrecoVenda = new Frameworks.Componentes.SuperTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecoPago = new Frameworks.Componentes.SuperTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSenha = new Frameworks.Componentes.SuperTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new Frameworks.Componentes.SuperTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoJogo = new Frameworks.Componentes.SuperComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidade = new Frameworks.Componentes.SuperTextBox();
            this.txtNome = new Frameworks.Componentes.SuperTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbConsole = new Frameworks.Componentes.SuperComboBox();
            this.grpFiltro.SuspendLayout();
            this.grpGrid.SuspendLayout();
            this.grpBotoes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpPesquisa.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Console:";
            // 
            // cmbConsolePesquisa
            // 
            this.cmbConsolePesquisa.FormattingEnabled = true;
            this.cmbConsolePesquisa.Location = new System.Drawing.Point(70, 45);
            this.cmbConsolePesquisa.Name = "cmbConsolePesquisa";
            this.cmbConsolePesquisa.Size = new System.Drawing.Size(121, 21);
            this.cmbConsolePesquisa.TabIndex = 2;
            this.cmbConsolePesquisa.SelectedIndexChanged += new System.EventHandler(this.cmbConsolePesquisa_SelectedIndexChanged);
            // 
            // txtPesqNome
            // 
            this.txtPesqNome.Location = new System.Drawing.Point(70, 19);
            this.txtPesqNome.Name = "txtPesqNome";
            this.txtPesqNome.Size = new System.Drawing.Size(277, 20);
            this.txtPesqNome.TabIndex = 3;
            // 
            // lvPesquisa
            // 
            this.lvPesquisa.Location = new System.Drawing.Point(19, 19);
            this.lvPesquisa.Name = "lvPesquisa";
            this.lvPesquisa.Size = new System.Drawing.Size(727, 297);
            this.lvPesquisa.TabIndex = 5;
            this.lvPesquisa.UseCompatibleStateImageBehavior = false;
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.txtPesqNome);
            this.grpFiltro.Controls.Add(this.label1);
            this.grpFiltro.Controls.Add(this.label2);
            this.grpFiltro.Controls.Add(this.cmbConsolePesquisa);
            this.grpFiltro.Controls.Add(this.button4);
            this.grpFiltro.Location = new System.Drawing.Point(18, 6);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(762, 91);
            this.grpFiltro.TabIndex = 6;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtro";
            // 
            // button4
            // 
            this.button4.Image = global::MaisGamers.Properties.Resources.iconeSearch32X32;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(379, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 32);
            this.button4.TabIndex = 3;
            this.button4.Text = "Pesquisar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // grpGrid
            // 
            this.grpGrid.Controls.Add(this.lvPesquisa);
            this.grpGrid.Location = new System.Drawing.Point(18, 99);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(762, 322);
            this.grpGrid.TabIndex = 7;
            this.grpGrid.TabStop = false;
            // 
            // grpBotoes
            // 
            this.grpBotoes.Controls.Add(this.button3);
            this.grpBotoes.Controls.Add(this.btnSalvar);
            this.grpBotoes.Controls.Add(this.btnNovo);
            this.grpBotoes.Controls.Add(this.button2);
            this.grpBotoes.Controls.Add(this.btnFechar);
            this.grpBotoes.Location = new System.Drawing.Point(136, 493);
            this.grpBotoes.Name = "grpBotoes";
            this.grpBotoes.Size = new System.Drawing.Size(490, 77);
            this.grpBotoes.TabIndex = 8;
            this.grpBotoes.TabStop = false;
            // 
            // button3
            // 
            this.button3.Image = global::MaisGamers.Properties.Resources.iconeSalvar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(103, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Editar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::MaisGamers.Properties.Resources.iconeSalvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(200, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 50);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::MaisGamers.Properties.Resources.iconenovo;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(6, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(91, 50);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // button2
            // 
            this.button2.Image = global::MaisGamers.Properties.Resources.iconeLimpar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(297, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Limpar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::MaisGamers.Properties.Resources.iconeFechar32;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(396, 19);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(91, 50);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPesquisa);
            this.tabControl1.Controls.Add(this.tpCadastro);
            this.tabControl1.Location = new System.Drawing.Point(40, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 453);
            this.tabControl1.TabIndex = 9;
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Controls.Add(this.grpFiltro);
            this.tpPesquisa.Controls.Add(this.grpGrid);
            this.tpPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tpPesquisa.Name = "tpPesquisa";
            this.tpPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tpPesquisa.Size = new System.Drawing.Size(798, 427);
            this.tpPesquisa.TabIndex = 0;
            this.tpPesquisa.Text = "Pesquisa";
            this.tpPesquisa.UseVisualStyleBackColor = true;
            // 
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.groupBox1);
            this.tpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(798, 427);
            this.tpCadastro.TabIndex = 1;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecoVenda);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPrecoPago);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbTipoJogo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbConsole);
            this.groupBox1.Location = new System.Drawing.Point(34, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 371);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(86, 235);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(123, 20);
            this.txtPrecoVenda.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Preço Venda:";
            // 
            // txtPrecoPago
            // 
            this.txtPrecoPago.Location = new System.Drawing.Point(86, 204);
            this.txtPrecoPago.Name = "txtPrecoPago";
            this.txtPrecoPago.Size = new System.Drawing.Size(123, 20);
            this.txtPrecoPago.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Preço Pago:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(86, 143);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(212, 20);
            this.txtSenha.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Senha:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(295, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo Jogo:";
            // 
            // cmbTipoJogo
            // 
            this.cmbTipoJogo.FormattingEnabled = true;
            this.cmbTipoJogo.Location = new System.Drawing.Point(86, 87);
            this.cmbTipoJogo.Name = "cmbTipoJogo";
            this.cmbTipoJogo.Size = new System.Drawing.Size(156, 21);
            this.cmbTipoJogo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(86, 174);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(68, 20);
            this.txtQuantidade.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(86, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(295, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Console:";
            // 
            // cmbConsole
            // 
            this.cmbConsole.FormattingEnabled = true;
            this.cmbConsole.Location = new System.Drawing.Point(86, 57);
            this.cmbConsole.Name = "cmbConsole";
            this.cmbConsole.Size = new System.Drawing.Size(156, 21);
            this.cmbConsole.TabIndex = 3;
            // 
            // frmCadJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1057, 585);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadJogo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadJogo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadJogo_Load);
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.grpGrid.ResumeLayout(false);
            this.grpBotoes.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpPesquisa.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Frameworks.Componentes.SuperComboBox cmbConsolePesquisa;
        private Frameworks.Componentes.SuperTextBox txtPesqNome;
        private Frameworks.Componentes.SuperLV lvPesquisa;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.GroupBox grpGrid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox grpBotoes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPesquisa;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.Label label3;
        private Frameworks.Componentes.SuperTextBox txtNome;
        private Frameworks.Componentes.SuperComboBox cmbConsole;
        private System.Windows.Forms.Label label4;
        private Frameworks.Componentes.SuperTextBox txtQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private Frameworks.Componentes.SuperComboBox cmbTipoJogo;
        private Frameworks.Componentes.SuperTextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Frameworks.Componentes.SuperTextBox txtSenha;
        private Frameworks.Componentes.SuperTextBox txtPrecoPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Frameworks.Componentes.SuperTextBox txtPrecoVenda;
    }
}