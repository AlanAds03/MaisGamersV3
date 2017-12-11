namespace MaisGamers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.menuCadastro = new System.Windows.Forms.RibbonTab();
            this.rbJogos = new System.Windows.Forms.RibbonPanel();
            this.rbAnotacao = new System.Windows.Forms.RibbonPanel();
            this.menuJogos = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.menuVendas = new System.Windows.Forms.RibbonTab();
            this.Rbps4 = new System.Windows.Forms.RibbonPanel();
            this.Rbxboxone = new System.Windows.Forms.RibbonPanel();
            this.Rbps3 = new System.Windows.Forms.RibbonPanel();
            this.Rbxbox360 = new System.Windows.Forms.RibbonPanel();
            this.rbCliente = new System.Windows.Forms.RibbonPanel();
            this.rbObjetos = new System.Windows.Forms.RibbonPanel();
            this.menuLancamento = new System.Windows.Forms.RibbonTab();
            this.menuCaixa = new System.Windows.Forms.RibbonTab();
            this.rbRelatorio = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.btnCliente = new System.Windows.Forms.RibbonButton();
            this.btnJogo = new System.Windows.Forms.RibbonButton();
            this.btnAnotacao = new System.Windows.Forms.RibbonButton();
            this.btnObjeto = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.btnRelatorio = new System.Windows.Forms.RibbonButton();
            this.Rbiconeps4 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.Rbiconeps3 = new System.Windows.Forms.RibbonButton();
            this.Rbx360 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
            this.rbConsole = new System.Windows.Forms.RibbonPanel();
            this.btnConsole = new System.Windows.Forms.RibbonButton();
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
            this.ribbon1.Tabs.Add(this.menuCaixa);
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
            // menuVendas
            // 
            this.menuVendas.Panels.Add(this.Rbps4);
            this.menuVendas.Panels.Add(this.Rbxboxone);
            this.menuVendas.Panels.Add(this.Rbps3);
            this.menuVendas.Panels.Add(this.Rbxbox360);
            this.menuVendas.Text = "Vendas";
            // 
            // Rbps4
            // 
            this.Rbps4.ButtonMoreEnabled = false;
            this.Rbps4.ButtonMoreVisible = false;
            this.Rbps4.Items.Add(this.Rbiconeps4);
            this.Rbps4.Text = "PS4";
            // 
            // Rbxboxone
            // 
            this.Rbxboxone.ButtonMoreEnabled = false;
            this.Rbxboxone.ButtonMoreVisible = false;
            this.Rbxboxone.Items.Add(this.ribbonButton4);
            this.Rbxboxone.Text = "Xbox One";
            // 
            // Rbps3
            // 
            this.Rbps3.ButtonMoreEnabled = false;
            this.Rbps3.ButtonMoreVisible = false;
            this.Rbps3.Items.Add(this.Rbiconeps3);
            this.Rbps3.Text = "PS3";
            // 
            // Rbxbox360
            // 
            this.Rbxbox360.ButtonMoreEnabled = false;
            this.Rbxbox360.ButtonMoreVisible = false;
            this.Rbxbox360.Items.Add(this.Rbx360);
            this.Rbxbox360.Text = "Xbox 360";
            // 
            // rbCliente
            // 
            this.rbCliente.Items.Add(this.btnCliente);
            this.rbCliente.Text = "Cliente";
            // 
            // rbObjetos
            // 
            this.rbObjetos.Items.Add(this.btnObjeto);
            this.rbObjetos.Text = "Objetos";
            // 
            // menuLancamento
            // 
            this.menuLancamento.Text = "Lançamento";
            // 
            // menuCaixa
            // 
            this.menuCaixa.Text = "Caixa";
            // 
            // rbRelatorio
            // 
            this.rbRelatorio.Items.Add(this.btnRelatorio);
            this.rbRelatorio.Text = "Relatórios";
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
            // Rbiconeps4
            // 
            this.Rbiconeps4.Image = ((System.Drawing.Image)(resources.GetObject("Rbiconeps4.Image")));
            this.Rbiconeps4.SmallImage = ((System.Drawing.Image)(resources.GetObject("Rbiconeps4.SmallImage")));
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            // 
            // Rbiconeps3
            // 
            this.Rbiconeps3.Image = ((System.Drawing.Image)(resources.GetObject("Rbiconeps3.Image")));
            this.Rbiconeps3.SmallImage = ((System.Drawing.Image)(resources.GetObject("Rbiconeps3.SmallImage")));
            // 
            // Rbx360
            // 
            this.Rbx360.Image = ((System.Drawing.Image)(resources.GetObject("Rbx360.Image")));
            this.Rbx360.SmallImage = ((System.Drawing.Image)(resources.GetObject("Rbx360.SmallImage")));
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.Image")));
            this.ribbonButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.SmallImage")));
            // 
            // rbConsole
            // 
            this.rbConsole.Items.Add(this.btnConsole);
            this.rbConsole.Text = "Consoles";
            // 
            // btnConsole
            // 
            this.btnConsole.Image = global::MaisGamers.Properties.Resources.iconeNintendo_fw;
            this.btnConsole.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnConsole.SmallImage")));
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
        private System.Windows.Forms.RibbonPanel Rbps4;
        private System.Windows.Forms.RibbonButton Rbiconeps4;
        private System.Windows.Forms.RibbonPanel Rbxboxone;
        private System.Windows.Forms.RibbonPanel Rbps3;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonButton Rbiconeps3;
        private System.Windows.Forms.RibbonButton Rbx360;
        private System.Windows.Forms.RibbonPanel Rbxbox360;
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
        private System.Windows.Forms.RibbonTab menuCaixa;
        private System.Windows.Forms.RibbonPanel rbConsole;
        private System.Windows.Forms.RibbonButton btnConsole;
    }
}

