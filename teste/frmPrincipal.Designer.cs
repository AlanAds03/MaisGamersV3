﻿namespace MaisGamers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.menuCadastro = new System.Windows.Forms.RibbonTab();
            this.rbCliente = new System.Windows.Forms.RibbonPanel();
            this.rbJogos = new System.Windows.Forms.RibbonPanel();
            this.rbAnotacao = new System.Windows.Forms.RibbonPanel();
            this.rbObjetos = new System.Windows.Forms.RibbonPanel();
            this.rbConsole = new System.Windows.Forms.RibbonPanel();
            this.menuJogos = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.rbRelatorio = new System.Windows.Forms.RibbonPanel();
            this.menuVendas = new System.Windows.Forms.RibbonTab();
            this.menuLancamento = new System.Windows.Forms.RibbonTab();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.btnCliente = new System.Windows.Forms.RibbonButton();
            this.btnJogo = new System.Windows.Forms.RibbonButton();
            this.btnAnotacao = new System.Windows.Forms.RibbonButton();
            this.btnObjeto = new System.Windows.Forms.RibbonButton();
            this.btnConsole = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.btnRelatorio = new System.Windows.Forms.RibbonButton();
            this.BotaoMenuVendas = new System.Windows.Forms.RibbonButton();
            this.BotaoMenuRelatorioVendas = new System.Windows.Forms.RibbonButton();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.CaptionBarVisible = false;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton1);
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1362, 132);
            this.ribbon1.TabIndex = 4;
            this.ribbon1.Tabs.Add(this.menuCadastro);
            this.ribbon1.Tabs.Add(this.menuJogos);
            this.ribbon1.Tabs.Add(this.menuVendas);
            this.ribbon1.Tabs.Add(this.menuLancamento);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.ribbon1.Text = "Manuntenção";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // menuCadastro
            // 
            this.menuCadastro.Panels.Add(this.rbCliente);
            this.menuCadastro.Panels.Add(this.rbJogos);
            this.menuCadastro.Panels.Add(this.rbAnotacao);
            this.menuCadastro.Panels.Add(this.rbObjetos);
            this.menuCadastro.Panels.Add(this.rbConsole);
            this.menuCadastro.Text = "Cadastro";
            // 
            // rbCliente
            // 
            this.rbCliente.Items.Add(this.btnCliente);
            this.rbCliente.Text = "Cliente";
            // 
            // rbJogos
            // 
            this.rbJogos.Items.Add(this.btnJogo);
            this.rbJogos.Text = "Jogos";
            // 
            // rbAnotacao
            // 
            this.rbAnotacao.Items.Add(this.btnAnotacao);
            this.rbAnotacao.Text = "Anotações";
            // 
            // rbObjetos
            // 
            this.rbObjetos.Items.Add(this.btnObjeto);
            this.rbObjetos.Text = "Produtos";
            // 
            // rbConsole
            // 
            this.rbConsole.Items.Add(this.btnConsole);
            this.rbConsole.Text = "Consoles";
            // 
            // menuJogos
            // 
            this.menuJogos.Panels.Add(this.ribbonPanel5);
            this.menuJogos.Panels.Add(this.rbRelatorio);
            this.menuJogos.Text = "Locação de Jogos";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.ButtonMoreEnabled = false;
            this.ribbonPanel5.ButtonMoreVisible = false;
            this.ribbonPanel5.Items.Add(this.ribbonButton2);
            this.ribbonPanel5.Text = "Locação de Jogo";
            // 
            // rbRelatorio
            // 
            this.rbRelatorio.Items.Add(this.btnRelatorio);
            this.rbRelatorio.Text = "Relatórios";
            // 
            // menuVendas
            // 
            this.menuVendas.Panels.Add(this.ribbonPanel1);
            this.menuVendas.Panels.Add(this.ribbonPanel2);
            this.menuVendas.Text = "Caixa";
            // 
            // menuLancamento
            // 
            this.menuLancamento.Text = "Lançamento";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifiacao";
            this.notifyIcon1.Visible = true;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.BotaoMenuVendas);
            this.ribbonPanel1.Text = "Vendas";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.BotaoMenuRelatorioVendas);
            this.ribbonPanel2.Text = "Relatório";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // btnCliente
            // 
            this.btnCliente.Image = global::MaisGamers.Properties.Resources.iconeCliente64;
            this.btnCliente.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCliente.SmallImage")));
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnJogo
            // 
            this.btnJogo.Image = ((System.Drawing.Image)(resources.GetObject("btnJogo.Image")));
            this.btnJogo.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnJogo.SmallImage")));
            this.btnJogo.Click += new System.EventHandler(this.ribbonButton6_Click);
            // 
            // btnAnotacao
            // 
            this.btnAnotacao.Image = global::MaisGamers.Properties.Resources.nota64;
            this.btnAnotacao.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAnotacao.SmallImage")));
            this.btnAnotacao.Text = "";
            // 
            // btnObjeto
            // 
            this.btnObjeto.Image = global::MaisGamers.Properties.Resources.objetos64;
            this.btnObjeto.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnObjeto.SmallImage")));
            this.btnObjeto.Click += new System.EventHandler(this.btnObjeto_Click);
            // 
            // btnConsole
            // 
            this.btnConsole.Image = global::MaisGamers.Properties.Resources.iconeNintendo_fw;
            this.btnConsole.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnConsole.SmallImage")));
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Click += new System.EventHandler(this.ribbonButton2_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Image = global::MaisGamers.Properties.Resources.relatorio64;
            this.btnRelatorio.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.SmallImage")));
            // 
            // BotaoMenuVendas
            // 
            this.BotaoMenuVendas.Image = global::MaisGamers.Properties.Resources.cash_register;
            this.BotaoMenuVendas.SmallImage = ((System.Drawing.Image)(resources.GetObject("BotaoMenuVendas.SmallImage")));
            this.BotaoMenuVendas.Click += new System.EventHandler(this.BotaoMenuVendas_Click);
            // 
            // BotaoMenuRelatorioVendas
            // 
            this.BotaoMenuRelatorioVendas.DropDownItems.Add(this.ribbonButton5);
            this.BotaoMenuRelatorioVendas.Image = global::MaisGamers.Properties.Resources.relatorio64;
            this.BotaoMenuRelatorioVendas.SmallImage = ((System.Drawing.Image)(resources.GetObject("BotaoMenuRelatorioVendas.SmallImage")));
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = global::MaisGamers.Properties.Resources.relatorio64;
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.Image")));
            this.ribbonButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.SmallImage")));
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 574);
            this.Controls.Add(this.ribbon1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mais Gamers";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonTab menuJogos;
        private System.Windows.Forms.RibbonTab menuVendas;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonTab menuCadastro;
        private System.Windows.Forms.RibbonPanel rbJogos;
        private System.Windows.Forms.RibbonButton btnJogo;
        private System.Windows.Forms.RibbonPanel rbAnotacao;
        private System.Windows.Forms.RibbonButton btnAnotacao;
        private System.Windows.Forms.RibbonButton ribbonButton7;
        private System.Windows.Forms.RibbonPanel rbCliente;
        private System.Windows.Forms.RibbonButton btnCliente;
        private System.Windows.Forms.RibbonPanel rbObjetos;
        private System.Windows.Forms.RibbonButton btnObjeto;
        private System.Windows.Forms.RibbonTab menuLancamento;
        private System.Windows.Forms.RibbonPanel rbRelatorio;
        private System.Windows.Forms.RibbonButton btnRelatorio;
        private System.Windows.Forms.RibbonPanel rbConsole;
        private System.Windows.Forms.RibbonButton btnConsole;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton BotaoMenuVendas;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton BotaoMenuRelatorioVendas;
        private System.Windows.Forms.RibbonButton ribbonButton5;
    }
}

