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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadJogo));
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGrid = new System.Windows.Forms.GroupBox();
            this.grpBotoes = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpPesquisa = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPesqNome = new Frameworks.Componentes.SuperTextBox();
            this.cmbConsolePesquisa = new Frameworks.Componentes.SuperComboBox();
            this.lvPesquisa = new Frameworks.Componentes.SuperLV();
            this.txtPrecoSecundaria = new Frameworks.Componentes.SuperTextBox();
            this.txtPrecoPrimaria = new Frameworks.Componentes.SuperTextBox();
            this.txtPrecoVenda = new Frameworks.Componentes.SuperTextBox();
            this.txtPrecoPago = new Frameworks.Componentes.SuperTextBox();
            this.txtSenha = new Frameworks.Componentes.SuperTextBox();
            this.txtEmail = new Frameworks.Componentes.SuperTextBox();
            this.cmbTipoJogo = new Frameworks.Componentes.SuperComboBox();
            this.txtQuantidade = new Frameworks.Componentes.SuperTextBox();
            this.txtNome = new Frameworks.Componentes.SuperTextBox();
            this.cmbConsole = new Frameworks.Componentes.SuperComboBox();
            this.grpFiltro.SuspendLayout();
            this.grpGrid.SuspendLayout();
            this.grpBotoes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.label11);
            this.grpFiltro.Controls.Add(this.label1);
            this.grpFiltro.Controls.Add(this.txtPesqNome);
            this.grpFiltro.Controls.Add(this.cmbConsolePesquisa);
            this.grpFiltro.Controls.Add(this.button4);
            this.grpFiltro.Location = new System.Drawing.Point(18, 6);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(762, 100);
            this.grpFiltro.TabIndex = 6;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(327, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Console:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // grpGrid
            // 
            this.grpGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpGrid.Controls.Add(this.lvPesquisa);
            this.grpGrid.Location = new System.Drawing.Point(18, 122);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(762, 295);
            this.grpGrid.TabIndex = 7;
            this.grpGrid.TabStop = false;
            // 
            // grpBotoes
            // 
            this.grpBotoes.Controls.Add(this.btnExcluir);
            this.grpBotoes.Controls.Add(this.button3);
            this.grpBotoes.Controls.Add(this.btnSalvar);
            this.grpBotoes.Controls.Add(this.btnNovo);
            this.grpBotoes.Controls.Add(this.button2);
            this.grpBotoes.Controls.Add(this.btnFechar);
            this.grpBotoes.Location = new System.Drawing.Point(132, 515);
            this.grpBotoes.Name = "grpBotoes";
            this.grpBotoes.Size = new System.Drawing.Size(691, 77);
            this.grpBotoes.TabIndex = 8;
            this.grpBotoes.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPesquisa);
            this.tabControl1.Controls.Add(this.tpCadastro);
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 475);
            this.tabControl1.TabIndex = 9;
            // 
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.groupBox1);
            this.tpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(1001, 449);
            this.tpCadastro.TabIndex = 1;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPrecoSecundaria);
            this.groupBox1.Controls.Add(this.txtPrecoPrimaria);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrecoVenda);
            this.groupBox1.Controls.Add(this.txtPrecoPago);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.cmbTipoJogo);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.cmbConsole);
            this.groupBox1.Location = new System.Drawing.Point(34, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 371);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(364, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Digital Secundária:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Digital Primária:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(362, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Preço Venda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Preço Pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Quantidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(362, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tipo de Jogo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Console:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome:";
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Controls.Add(this.grpFiltro);
            this.tpPesquisa.Controls.Add(this.grpGrid);
            this.tpPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tpPesquisa.Name = "tpPesquisa";
            this.tpPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tpPesquisa.Size = new System.Drawing.Size(1001, 449);
            this.tpPesquisa.TabIndex = 0;
            this.tpPesquisa.Text = "Pesquisa";
            this.tpPesquisa.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(297, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 50);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
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
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button2.Location = new System.Drawing.Point(394, 21);
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
            this.btnFechar.Location = new System.Drawing.Point(490, 21);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(91, 50);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // button4
            // 
            this.button4.Image = global::MaisGamers.Properties.Resources.iconeSearch32X32;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(588, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "Pesquisar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtPesqNome
            // 
            this.txtPesqNome.CampoObrigatorio = false;
            this.txtPesqNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqNome.Location = new System.Drawing.Point(29, 36);
            this.txtPesqNome.Name = "txtPesqNome";
            this.txtPesqNome.Size = new System.Drawing.Size(277, 26);
            this.txtPesqNome.TabIndex = 3;
            // 
            // cmbConsolePesquisa
            // 
            this.cmbConsolePesquisa.Carregado = false;
            this.cmbConsolePesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConsolePesquisa.FormattingEnabled = true;
            this.cmbConsolePesquisa.Location = new System.Drawing.Point(330, 36);
            this.cmbConsolePesquisa.Name = "cmbConsolePesquisa";
            this.cmbConsolePesquisa.Size = new System.Drawing.Size(181, 28);
            this.cmbConsolePesquisa.TabIndex = 2;
            this.cmbConsolePesquisa.SelectedIndexChanged += new System.EventHandler(this.cmbConsolePesquisa_SelectedIndexChanged);
            // 
            // lvPesquisa
            // 
            this.lvPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvPesquisa.Location = new System.Drawing.Point(19, 31);
            this.lvPesquisa.Name = "lvPesquisa";
            this.lvPesquisa.Size = new System.Drawing.Size(727, 227);
            this.lvPesquisa.TabIndex = 5;
            this.lvPesquisa.UseCompatibleStateImageBehavior = false;
            this.lvPesquisa.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvPesquisa_ItemChecked);
            // 
            // txtPrecoSecundaria
            // 
            this.txtPrecoSecundaria.CampoObrigatorio = false;
            this.txtPrecoSecundaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoSecundaria.Location = new System.Drawing.Point(365, 308);
            this.txtPrecoSecundaria.Name = "txtPrecoSecundaria";
            this.txtPrecoSecundaria.Size = new System.Drawing.Size(123, 26);
            this.txtPrecoSecundaria.TabIndex = 25;
            this.txtPrecoSecundaria.Leave += new System.EventHandler(this.txtPrecoSecundaria_Leave);
            // 
            // txtPrecoPrimaria
            // 
            this.txtPrecoPrimaria.CampoObrigatorio = false;
            this.txtPrecoPrimaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoPrimaria.Location = new System.Drawing.Point(35, 308);
            this.txtPrecoPrimaria.Name = "txtPrecoPrimaria";
            this.txtPrecoPrimaria.Size = new System.Drawing.Size(123, 26);
            this.txtPrecoPrimaria.TabIndex = 24;
            this.txtPrecoPrimaria.Leave += new System.EventHandler(this.txtPrecoPrimaria_Leave);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.CampoObrigatorio = false;
            this.txtPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVenda.Location = new System.Drawing.Point(365, 234);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(123, 26);
            this.txtPrecoVenda.TabIndex = 7;
            // 
            // txtPrecoPago
            // 
            this.txtPrecoPago.CampoObrigatorio = false;
            this.txtPrecoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoPago.Location = new System.Drawing.Point(35, 234);
            this.txtPrecoPago.Name = "txtPrecoPago";
            this.txtPrecoPago.Size = new System.Drawing.Size(123, 26);
            this.txtPrecoPago.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.CampoObrigatorio = false;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(365, 136);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(212, 26);
            this.txtSenha.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.CampoObrigatorio = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(35, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(295, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // cmbTipoJogo
            // 
            this.cmbTipoJogo.Carregado = false;
            this.cmbTipoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoJogo.FormattingEnabled = true;
            this.cmbTipoJogo.Location = new System.Drawing.Point(35, 85);
            this.cmbTipoJogo.Name = "cmbTipoJogo";
            this.cmbTipoJogo.Size = new System.Drawing.Size(156, 28);
            this.cmbTipoJogo.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CampoObrigatorio = false;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(35, 185);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(68, 26);
            this.txtQuantidade.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.CampoObrigatorio = true;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(35, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(295, 26);
            this.txtNome.TabIndex = 0;
            // 
            // cmbConsole
            // 
            this.cmbConsole.Carregado = false;
            this.cmbConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConsole.FormattingEnabled = true;
            this.cmbConsole.Location = new System.Drawing.Point(365, 36);
            this.cmbConsole.Name = "cmbConsole";
            this.cmbConsole.Size = new System.Drawing.Size(156, 28);
            this.cmbConsole.TabIndex = 1;
            // 
            // frmCadJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1057, 585);
            this.ControlBox = false;
            this.Controls.Add(this.grpBotoes);
            this.Controls.Add(this.tabControl1);
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
            this.tpCadastro.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private Frameworks.Componentes.SuperTextBox txtNome;
        private Frameworks.Componentes.SuperComboBox cmbConsole;
        private Frameworks.Componentes.SuperTextBox txtQuantidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private Frameworks.Componentes.SuperComboBox cmbTipoJogo;
        private Frameworks.Componentes.SuperTextBox txtEmail;
        private Frameworks.Componentes.SuperTextBox txtSenha;
        private Frameworks.Componentes.SuperTextBox txtPrecoPago;
        private Frameworks.Componentes.SuperTextBox txtPrecoVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private Frameworks.Componentes.SuperTextBox txtPrecoSecundaria;
        private Frameworks.Componentes.SuperTextBox txtPrecoPrimaria;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}