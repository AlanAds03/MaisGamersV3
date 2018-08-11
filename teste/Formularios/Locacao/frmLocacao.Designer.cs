namespace MaisGamers.Formularios.Cadastro
{
    partial class frmLocacao
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
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesqNome = new Frameworks.Componentes.SuperTextBox();
            this.cmbStatus = new Frameworks.Componentes.SuperComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.grpGrid = new System.Windows.Forms.GroupBox();
            this.lvPesquisa = new Frameworks.Componentes.SuperLV();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPesquisa = new System.Windows.Forms.TabPage();
            this.tpLocacao = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpGridLocacao = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExcluirJogo = new System.Windows.Forms.Button();
            this.txtDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEntregarCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnJogo = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvLocacao = new Frameworks.Componentes.SuperLV();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.picExcluir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBotoes2 = new System.Windows.Forms.GroupBox();
            this.chkAutorizado = new System.Windows.Forms.CheckBox();
            this.grpFiltro.SuspendLayout();
            this.grpGrid.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpPesquisa.SuspendLayout();
            this.tpLocacao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpGridLocacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBotoes2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.label11);
            this.grpFiltro.Controls.Add(this.label1);
            this.grpFiltro.Controls.Add(this.txtPesqNome);
            this.grpFiltro.Controls.Add(this.cmbStatus);
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
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente:";
            // 
            // txtPesqNome
            // 
            this.txtPesqNome.CampoObrigatorio = false;
            this.txtPesqNome.DescricaoObrigatorio = null;
            this.txtPesqNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesqNome.Location = new System.Drawing.Point(29, 36);
            this.txtPesqNome.Name = "txtPesqNome";
            this.txtPesqNome.Size = new System.Drawing.Size(277, 26);
            this.txtPesqNome.TabIndex = 3;
            this.txtPesqNome.TipoTexto = null;
            // 
            // cmbStatus
            // 
            this.cmbStatus.CampoObrigatorio = false;
            this.cmbStatus.Carregado = false;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(330, 36);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(181, 28);
            this.cmbStatus.TabIndex = 2;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbConsolePesquisa_SelectedIndexChanged);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPesquisa);
            this.tabControl1.Controls.Add(this.tpLocacao);
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 475);
            this.tabControl1.TabIndex = 9;
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
            // tpLocacao
            // 
            this.tpLocacao.Controls.Add(this.groupBox1);
            this.tpLocacao.Controls.Add(this.grpGridLocacao);
            this.tpLocacao.Location = new System.Drawing.Point(4, 22);
            this.tpLocacao.Name = "tpLocacao";
            this.tpLocacao.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocacao.Size = new System.Drawing.Size(1001, 449);
            this.tpLocacao.TabIndex = 1;
            this.tpLocacao.Text = "Locacao";
            this.tpLocacao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDataCadastro);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.lblRG);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(18, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 83);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Cliente";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDataCadastro.Location = new System.Drawing.Point(812, 62);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(66, 18);
            this.lblDataCadastro.TabIndex = 9;
            this.lblDataCadastro.Text = "label10";
            this.lblDataCadastro.Click += new System.EventHandler(this.lblDataCadastro_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(436, 28);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 22);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "label9";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(79, 57);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(56, 18);
            this.lblCPF.TabIndex = 7;
            this.lblCPF.Text = "label8";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(79, 39);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(51, 18);
            this.lblRG.TabIndex = 6;
            this.lblRG.Text = "lblRG";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(79, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(82, 18);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "lblCliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(364, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(656, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Data de  Cadastro:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "RG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cliente:";
            // 
            // grpGridLocacao
            // 
            this.grpGridLocacao.Controls.Add(this.chkAutorizado);
            this.grpGridLocacao.Controls.Add(this.btnImprimir);
            this.grpGridLocacao.Controls.Add(this.btnExcluirJogo);
            this.grpGridLocacao.Controls.Add(this.txtDataEntrega);
            this.grpGridLocacao.Controls.Add(this.label8);
            this.grpGridLocacao.Controls.Add(this.btnEntregarCliente);
            this.grpGridLocacao.Controls.Add(this.button1);
            this.grpGridLocacao.Controls.Add(this.btnJogo);
            this.grpGridLocacao.Controls.Add(this.lblTotal);
            this.grpGridLocacao.Controls.Add(this.label2);
            this.grpGridLocacao.Controls.Add(this.lvLocacao);
            this.grpGridLocacao.Location = new System.Drawing.Point(18, 105);
            this.grpGridLocacao.Name = "grpGridLocacao";
            this.grpGridLocacao.Size = new System.Drawing.Size(907, 338);
            this.grpGridLocacao.TabIndex = 1;
            this.grpGridLocacao.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::MaisGamers.Properties.Resources.iconeimpressora;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(286, 277);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(87, 50);
            this.btnImprimir.TabIndex = 26;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnExcluirJogo
            // 
            this.btnExcluirJogo.Image = global::MaisGamers.Properties.Resources.iconemenos;
            this.btnExcluirJogo.Location = new System.Drawing.Point(833, 75);
            this.btnExcluirJogo.Name = "btnExcluirJogo";
            this.btnExcluirJogo.Size = new System.Drawing.Size(45, 50);
            this.btnExcluirJogo.TabIndex = 25;
            this.btnExcluirJogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirJogo.UseVisualStyleBackColor = true;
            this.btnExcluirJogo.Click += new System.EventHandler(this.btnExcluirJogo_Click);
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEntrega.Location = new System.Drawing.Point(794, 275);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(107, 20);
            this.txtDataEntrega.TabIndex = 23;
            this.txtDataEntrega.ValueChanged += new System.EventHandler(this.txtDataEntrega_ValueChanged);
            this.txtDataEntrega.Leave += new System.EventHandler(this.txtDataEntrega_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(715, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Data Previsão";
            // 
            // btnEntregarCliente
            // 
            this.btnEntregarCliente.Image = global::MaisGamers.Properties.Resources.iconecd;
            this.btnEntregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntregarCliente.Location = new System.Drawing.Point(6, 277);
            this.btnEntregarCliente.Name = "btnEntregarCliente";
            this.btnEntregarCliente.Size = new System.Drawing.Size(134, 50);
            this.btnEntregarCliente.TabIndex = 20;
            this.btnEntregarCliente.Text = "Entregar ao cliente";
            this.btnEntregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntregarCliente.UseVisualStyleBackColor = true;
            this.btnEntregarCliente.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Image = global::MaisGamers.Properties.Resources.iconePAgamento32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(146, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "Finalizar Locação";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnJogo
            // 
            this.btnJogo.Image = global::MaisGamers.Properties.Resources.iconemais;
            this.btnJogo.Location = new System.Drawing.Point(833, 19);
            this.btnJogo.Name = "btnJogo";
            this.btnJogo.Size = new System.Drawing.Size(45, 50);
            this.btnJogo.TabIndex = 18;
            this.btnJogo.Text = " ";
            this.btnJogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJogo.UseVisualStyleBackColor = true;
            this.btnJogo.Click += new System.EventHandler(this.btnJogo_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(861, 319);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(815, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total : ";
            // 
            // lvLocacao
            // 
            this.lvLocacao.Location = new System.Drawing.Point(6, 19);
            this.lvLocacao.Name = "lvLocacao";
            this.lvLocacao.Size = new System.Drawing.Size(822, 252);
            this.lvLocacao.TabIndex = 0;
            this.lvLocacao.UseCompatibleStateImageBehavior = false;
            this.lvLocacao.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvLocacao_ItemChecked);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MaisGamers.Properties.Resources.img_168133;
            this.pictureBox6.Location = new System.Drawing.Point(244, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox6.MouseEnter += new System.EventHandler(this.pictureBox6_MouseEnter);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.pictureBox6_MouseLeave);
            // 
            // picExcluir
            // 
            this.picExcluir.Image = global::MaisGamers.Properties.Resources.delete;
            this.picExcluir.Location = new System.Drawing.Point(190, 14);
            this.picExcluir.Name = "picExcluir";
            this.picExcluir.Size = new System.Drawing.Size(48, 48);
            this.picExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picExcluir.TabIndex = 22;
            this.picExcluir.TabStop = false;
            this.picExcluir.Click += new System.EventHandler(this.picExcluir_Click);
            this.picExcluir.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.picExcluir.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaisGamers.Properties.Resources.edit_document_icon_icons_com_54542__1_;
            this.pictureBox1.Location = new System.Drawing.Point(136, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // grpBotoes2
            // 
            this.grpBotoes2.Controls.Add(this.pictureBox6);
            this.grpBotoes2.Controls.Add(this.pictureBox1);
            this.grpBotoes2.Controls.Add(this.picExcluir);
            this.grpBotoes2.Location = new System.Drawing.Point(235, 511);
            this.grpBotoes2.Name = "grpBotoes2";
            this.grpBotoes2.Size = new System.Drawing.Size(558, 68);
            this.grpBotoes2.TabIndex = 27;
            this.grpBotoes2.TabStop = false;
            // 
            // chkAutorizado
            // 
            this.chkAutorizado.AutoSize = true;
            this.chkAutorizado.Location = new System.Drawing.Point(391, 280);
            this.chkAutorizado.Name = "chkAutorizado";
            this.chkAutorizado.Size = new System.Drawing.Size(80, 17);
            this.chkAutorizado.TabIndex = 27;
            this.chkAutorizado.Text = "checkBox1";
            this.chkAutorizado.UseVisualStyleBackColor = true;
            // 
            // frmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1057, 585);
            this.ControlBox = false;
            this.Controls.Add(this.grpBotoes2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLocacao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadJogo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadJogo_Load);
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.grpGrid.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpPesquisa.ResumeLayout(false);
            this.tpLocacao.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpGridLocacao.ResumeLayout(false);
            this.grpGridLocacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBotoes2.ResumeLayout(false);
            this.grpBotoes2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Frameworks.Componentes.SuperComboBox cmbStatus;
        private Frameworks.Componentes.SuperTextBox txtPesqNome;
        private Frameworks.Componentes.SuperLV lvPesquisa;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.GroupBox grpGrid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPesquisa;
        private System.Windows.Forms.TabPage tpLocacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private Frameworks.Componentes.SuperLV lvLocacao;
        private System.Windows.Forms.GroupBox grpGridLocacao;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnJogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEntregarCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtDataEntrega;
        private System.Windows.Forms.Button btnExcluirJogo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picExcluir;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.GroupBox grpBotoes2;
        private System.Windows.Forms.CheckBox chkAutorizado;
    }
}