namespace MaisGamers.Formularios.Orcamento
{
    partial class frmOrcamento
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
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grpGrid = new System.Windows.Forms.GroupBox();
            this.grpBotoes = new System.Windows.Forms.GroupBox();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tpPesquisa = new System.Windows.Forms.TabPage();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdutoPesq = new Frameworks.Componentes.SuperTextBox();
            this.txtPesqNome = new Frameworks.Componentes.SuperTextBox();
            this.cmdStatusPesquisa = new Frameworks.Componentes.SuperComboBox();
            this.lvPesquisa = new Frameworks.Componentes.SuperLV();
            this.cmbTipoPagamento = new Frameworks.Componentes.SuperComboBox();
            this.txtGarantia = new Frameworks.Componentes.SuperTextBox();
            this.txtValor = new Frameworks.Componentes.SuperTextBox();
            this.txtTelefone2 = new Frameworks.Componentes.SuperTextBox();
            this.txtTelefone1 = new Frameworks.Componentes.SuperTextBox();
            this.txtNumeroSerie = new Frameworks.Componentes.SuperTextBox();
            this.txtProduto = new Frameworks.Componentes.SuperTextBox();
            this.txtObservacao = new Frameworks.Componentes.SuperTextBox();
            this.txtDefeito = new Frameworks.Componentes.SuperTextBox();
            this.cmdStatus = new Frameworks.Componentes.SuperComboBox();
            this.txtNome = new Frameworks.Componentes.SuperTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnComprovante = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTirarFoto = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.grpFiltro.SuspendLayout();
            this.grpGrid.SuspendLayout();
            this.grpBotoes.SuspendLayout();
            this.tbControl.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto:";
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.txtProdutoPesq);
            this.grpFiltro.Controls.Add(this.label11);
            this.grpFiltro.Controls.Add(this.txtPesqNome);
            this.grpFiltro.Controls.Add(this.label1);
            this.grpFiltro.Controls.Add(this.label2);
            this.grpFiltro.Controls.Add(this.cmdStatusPesquisa);
            this.grpFiltro.Controls.Add(this.btnPesquisar);
            this.grpFiltro.Location = new System.Drawing.Point(18, 6);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(762, 121);
            this.grpFiltro.TabIndex = 6;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Status:";
            // 
            // grpGrid
            // 
            this.grpGrid.Controls.Add(this.lvPesquisa);
            this.grpGrid.Location = new System.Drawing.Point(18, 133);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(762, 350);
            this.grpGrid.TabIndex = 7;
            this.grpGrid.TabStop = false;
            // 
            // grpBotoes
            // 
            this.grpBotoes.Controls.Add(this.btnEditar);
            this.grpBotoes.Controls.Add(this.btnSalvar);
            this.grpBotoes.Controls.Add(this.btnNovo);
            this.grpBotoes.Controls.Add(this.btnLimpar);
            this.grpBotoes.Controls.Add(this.btnFechar);
            this.grpBotoes.Location = new System.Drawing.Point(153, 471);
            this.grpBotoes.Name = "grpBotoes";
            this.grpBotoes.Size = new System.Drawing.Size(490, 77);
            this.grpBotoes.TabIndex = 8;
            this.grpBotoes.TabStop = false;
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tpPesquisa);
            this.tbControl.Controls.Add(this.tpCadastro);
            this.tbControl.Location = new System.Drawing.Point(40, 38);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(806, 427);
            this.tbControl.TabIndex = 9;
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Controls.Add(this.grpFiltro);
            this.tpPesquisa.Controls.Add(this.grpGrid);
            this.tpPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tpPesquisa.Name = "tpPesquisa";
            this.tpPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tpPesquisa.Size = new System.Drawing.Size(798, 401);
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
            this.tpCadastro.Size = new System.Drawing.Size(798, 401);
            this.tpCadastro.TabIndex = 1;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnComprovante);
            this.groupBox1.Controls.Add(this.cmbTipoPagamento);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnCaixa);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.txtDataEntrega);
            this.groupBox1.Controls.Add(this.txtDataEntrada);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnTirarFoto);
            this.groupBox1.Controls.Add(this.txtGarantia);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.txtTelefone2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtTelefone1);
            this.groupBox1.Controls.Add(this.txtNumeroSerie);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtDefeito);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmdStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(24, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 377);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(375, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 20);
            this.label14.TabIndex = 87;
            this.label14.Text = "Tipo de Pagamento:";
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEntrega.Location = new System.Drawing.Point(397, 336);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.ShowCheckBox = true;
            this.txtDataEntrega.Size = new System.Drawing.Size(129, 26);
            this.txtDataEntrega.TabIndex = 12;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEntrada.Location = new System.Drawing.Point(274, 338);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(100, 26);
            this.txtDataEntrada.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(204, 260);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 20);
            this.label16.TabIndex = 28;
            this.label16.Text = "Telefone 2:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(145, 315);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Garantia:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(41, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Telefone 1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Valor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Observação:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(393, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Data Entrega:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Data Entrada:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(342, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Defeito:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(342, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Número S/N:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Produto:";
            // 
            // txtProdutoPesq
            // 
            this.txtProdutoPesq.CampoObrigatorio = false;
            this.txtProdutoPesq.DescricaoObrigatorio = null;
            this.txtProdutoPesq.Location = new System.Drawing.Point(105, 44);
            this.txtProdutoPesq.Name = "txtProdutoPesq";
            this.txtProdutoPesq.Size = new System.Drawing.Size(185, 20);
            this.txtProdutoPesq.TabIndex = 5;
            this.txtProdutoPesq.TipoTexto = null;
            // 
            // txtPesqNome
            // 
            this.txtPesqNome.CampoObrigatorio = false;
            this.txtPesqNome.DescricaoObrigatorio = null;
            this.txtPesqNome.Location = new System.Drawing.Point(105, 19);
            this.txtPesqNome.Name = "txtPesqNome";
            this.txtPesqNome.Size = new System.Drawing.Size(277, 20);
            this.txtPesqNome.TabIndex = 3;
            this.txtPesqNome.TipoTexto = null;
            // 
            // cmdStatusPesquisa
            // 
            this.cmdStatusPesquisa.CampoObrigatorio = false;
            this.cmdStatusPesquisa.Carregado = false;
            this.cmdStatusPesquisa.FormattingEnabled = true;
            this.cmdStatusPesquisa.Location = new System.Drawing.Point(105, 70);
            this.cmdStatusPesquisa.Name = "cmdStatusPesquisa";
            this.cmdStatusPesquisa.Size = new System.Drawing.Size(185, 21);
            this.cmdStatusPesquisa.TabIndex = 2;
            // 
            // lvPesquisa
            // 
            this.lvPesquisa.Location = new System.Drawing.Point(6, 14);
            this.lvPesquisa.Name = "lvPesquisa";
            this.lvPesquisa.Size = new System.Drawing.Size(727, 330);
            this.lvPesquisa.TabIndex = 5;
            this.lvPesquisa.UseCompatibleStateImageBehavior = false;
            this.lvPesquisa.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvPesquisa_ItemChecked);
            // 
            // cmbTipoPagamento
            // 
            this.cmbTipoPagamento.CampoObrigatorio = false;
            this.cmbTipoPagamento.Carregado = false;
            this.cmbTipoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPagamento.FormattingEnabled = true;
            this.cmbTipoPagamento.Location = new System.Drawing.Point(379, 283);
            this.cmbTipoPagamento.Name = "cmbTipoPagamento";
            this.cmbTipoPagamento.Size = new System.Drawing.Size(149, 28);
            this.cmbTipoPagamento.TabIndex = 13;
            // 
            // txtGarantia
            // 
            this.txtGarantia.CampoObrigatorio = false;
            this.txtGarantia.DescricaoObrigatorio = null;
            this.txtGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGarantia.Location = new System.Drawing.Point(149, 338);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(99, 26);
            this.txtGarantia.TabIndex = 10;
            this.txtGarantia.TipoTexto = Frameworks.Componentes.SuperTextBox.eTipoTexto.NUMERO;
            // 
            // txtValor
            // 
            this.txtValor.CampoObrigatorio = false;
            this.txtValor.DescricaoObrigatorio = null;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(45, 338);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(89, 26);
            this.txtValor.TabIndex = 9;
            this.txtValor.TipoTexto = Frameworks.Componentes.SuperTextBox.eTipoTexto.NUMERO;
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.CampoObrigatorio = false;
            this.txtTelefone2.DescricaoObrigatorio = null;
            this.txtTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2.Location = new System.Drawing.Point(208, 286);
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(149, 26);
            this.txtTelefone2.TabIndex = 8;
            this.txtTelefone2.TipoTexto = Frameworks.Componentes.SuperTextBox.eTipoTexto.NUMERO;
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.CampoObrigatorio = true;
            this.txtTelefone1.DescricaoObrigatorio = null;
            this.txtTelefone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone1.Location = new System.Drawing.Point(45, 286);
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(149, 26);
            this.txtTelefone1.TabIndex = 7;
            this.txtTelefone1.TipoTexto = Frameworks.Componentes.SuperTextBox.eTipoTexto.NUMERO;
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.CampoObrigatorio = true;
            this.txtNumeroSerie.DescricaoObrigatorio = null;
            this.txtNumeroSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroSerie.Location = new System.Drawing.Point(346, 101);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(180, 26);
            this.txtNumeroSerie.TabIndex = 4;
            this.txtNumeroSerie.TipoTexto = null;
            // 
            // txtProduto
            // 
            this.txtProduto.CampoObrigatorio = true;
            this.txtProduto.DescricaoObrigatorio = null;
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(45, 101);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(295, 26);
            this.txtProduto.TabIndex = 3;
            this.txtProduto.TipoTexto = Frameworks.Componentes.SuperTextBox.eTipoTexto.NENHUM;
            // 
            // txtObservacao
            // 
            this.txtObservacao.CampoObrigatorio = true;
            this.txtObservacao.DescricaoObrigatorio = "Informar a observação";
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(45, 218);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(481, 39);
            this.txtObservacao.TabIndex = 6;
            this.txtObservacao.TipoTexto = null;
            // 
            // txtDefeito
            // 
            this.txtDefeito.CampoObrigatorio = true;
            this.txtDefeito.DescricaoObrigatorio = null;
            this.txtDefeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefeito.Location = new System.Drawing.Point(45, 153);
            this.txtDefeito.Multiline = true;
            this.txtDefeito.Name = "txtDefeito";
            this.txtDefeito.Size = new System.Drawing.Size(481, 39);
            this.txtDefeito.TabIndex = 5;
            this.txtDefeito.TipoTexto = null;
            // 
            // cmdStatus
            // 
            this.cmdStatus.CampoObrigatorio = false;
            this.cmdStatus.Carregado = false;
            this.cmdStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStatus.FormattingEnabled = true;
            this.cmdStatus.Location = new System.Drawing.Point(346, 47);
            this.cmdStatus.Name = "cmdStatus";
            this.cmdStatus.Size = new System.Drawing.Size(183, 28);
            this.cmdStatus.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.CampoObrigatorio = true;
            this.txtNome.DescricaoObrigatorio = "Informar o nome do Cliente";
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(45, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(295, 26);
            this.txtNome.TabIndex = 0;
            this.txtNome.TipoTexto = null;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::MaisGamers.Properties.Resources.iconeSearch32X32;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(317, 63);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 32);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnComprovante
            // 
            this.btnComprovante.Image = global::MaisGamers.Properties.Resources.iconeimpressora;
            this.btnComprovante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprovante.Location = new System.Drawing.Point(624, 295);
            this.btnComprovante.Name = "btnComprovante";
            this.btnComprovante.Size = new System.Drawing.Size(110, 40);
            this.btnComprovante.TabIndex = 89;
            this.btnComprovante.Text = "Comprovante";
            this.btnComprovante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprovante.UseVisualStyleBackColor = true;
            // 
            // btnCaixa
            // 
            this.btnCaixa.Image = global::MaisGamers.Properties.Resources.iconePAgamento32;
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.Location = new System.Drawing.Point(624, 240);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(94, 40);
            this.btnCaixa.TabIndex = 86;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaixa.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::MaisGamers.Properties.Resources.iconeimpressora;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(625, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 40);
            this.button5.TabIndex = 85;
            this.button5.Text = "Imprimir";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::MaisGamers.Properties.Resources.camera32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(625, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 40);
            this.button1.TabIndex = 82;
            this.button1.Text = "Ver Fotos";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTirarFoto
            // 
            this.btnTirarFoto.Image = global::MaisGamers.Properties.Resources.camera32;
            this.btnTirarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTirarFoto.Location = new System.Drawing.Point(625, 87);
            this.btnTirarFoto.Name = "btnTirarFoto";
            this.btnTirarFoto.Size = new System.Drawing.Size(93, 40);
            this.btnTirarFoto.TabIndex = 81;
            this.btnTirarFoto.Text = "Tirar Fotos";
            this.btnTirarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTirarFoto.UseVisualStyleBackColor = true;
            this.btnTirarFoto.Click += new System.EventHandler(this.btnTirarFoto_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::MaisGamers.Properties.Resources.iconeSalvar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(103, 19);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 50);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            // btnLimpar
            // 
            this.btnLimpar.Image = global::MaisGamers.Properties.Resources.iconeLimpar;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(297, 19);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(93, 50);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
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
            // frmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 711);
            this.ControlBox = false;
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.grpBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrcamento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadJogo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.grpGrid.ResumeLayout(false);
            this.grpBotoes.ResumeLayout(false);
            this.tbControl.ResumeLayout(false);
            this.tpPesquisa.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Frameworks.Componentes.SuperComboBox cmdStatusPesquisa;
        private Frameworks.Componentes.SuperTextBox txtPesqNome;
        private Frameworks.Componentes.SuperLV lvPesquisa;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.GroupBox grpGrid;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox grpBotoes;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tpPesquisa;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.Label label3;
        private Frameworks.Componentes.SuperTextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private Frameworks.Componentes.SuperComboBox cmdStatus;
        private System.Windows.Forms.Label label7;
        private Frameworks.Componentes.SuperTextBox txtDefeito;
        private Frameworks.Componentes.SuperTextBox txtProdutoPesq;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private Frameworks.Componentes.SuperTextBox txtValor;
        private Frameworks.Componentes.SuperTextBox txtTelefone2;
        private System.Windows.Forms.Label label16;
        private Frameworks.Componentes.SuperTextBox txtTelefone1;
        private Frameworks.Componentes.SuperTextBox txtNumeroSerie;
        private Frameworks.Componentes.SuperTextBox txtProduto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private Frameworks.Componentes.SuperTextBox txtObservacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTirarFoto;
        private System.Windows.Forms.DateTimePicker txtDataEntrega;
        private System.Windows.Forms.DateTimePicker txtDataEntrada;
        private System.Windows.Forms.Button button5;
        private Frameworks.Componentes.SuperTextBox txtGarantia;
        private Frameworks.Componentes.SuperComboBox cmbTipoPagamento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnComprovante;
    }
}