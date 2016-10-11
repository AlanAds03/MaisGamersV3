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
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.Rbmenucadastro = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.rbCliente = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.rbJogos = new System.Windows.Forms.RibbonButton();
            this.Rbmenuorcamento = new System.Windows.Forms.RibbonTab();
            this.Rbmenumanutencao = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.Rbcontroles = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.Rbconsoles = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel7 = new System.Windows.Forms.RibbonPanel();
            this.Rbcelularetablet = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel8 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.Rblocacaodejogos = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.Rblocacaocliente = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonTab5 = new System.Windows.Forms.RibbonTab();
            this.Rbps4 = new System.Windows.Forms.RibbonPanel();
            this.Rbiconeps4 = new System.Windows.Forms.RibbonButton();
            this.Rbxboxone = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.Rbps3 = new System.Windows.Forms.RibbonPanel();
            this.Rbiconeps3 = new System.Windows.Forms.RibbonButton();
            this.Rbxbox360 = new System.Windows.Forms.RibbonPanel();
            this.Rbx360 = new System.Windows.Forms.RibbonButton();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel9 = new System.Windows.Forms.RibbonPanel();
            this.Rblancahora = new System.Windows.Forms.RibbonButton();
            this.Rbfluxo = new System.Windows.Forms.RibbonPanel();
            this.Rbcaixa = new System.Windows.Forms.RibbonButton();
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
            this.ribbon1.Size = new System.Drawing.Size(1354, 122);
            this.ribbon1.TabIndex = 4;
            this.ribbon1.Tabs.Add(this.Rbmenucadastro);
            this.ribbon1.Tabs.Add(this.Rbmenuorcamento);
            this.ribbon1.Tabs.Add(this.Rbmenumanutencao);
            this.ribbon1.Tabs.Add(this.Rblocacaodejogos);
            this.ribbon1.Tabs.Add(this.ribbonTab5);
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
            this.ribbon1.Text = "Manuntenção";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            this.ribbon1.Click += new System.EventHandler(this.ribbon1_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // Rbmenucadastro
            // 
            this.Rbmenucadastro.Panels.Add(this.ribbonPanel1);
            this.Rbmenucadastro.Panels.Add(this.ribbonPanel2);
            this.Rbmenucadastro.Text = "Cadastro";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.rbCliente);
            this.ribbonPanel1.Text = "Cliente";
            // 
            // rbCliente
            // 
            this.rbCliente.Image = global::MaisGamers.Properties.Resources.iconesCliente;
            this.rbCliente.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbCliente.SmallImage")));
            this.rbCliente.Click += new System.EventHandler(this.rbCliente_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.rbJogos);
            this.ribbonPanel2.Text = "Jogos";
            // 
            // rbJogos
            // 
            this.rbJogos.Image = global::MaisGamers.Properties.Resources.games_icon;
            this.rbJogos.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbJogos.SmallImage")));
            this.rbJogos.Text = "";
            // 
            // Rbmenuorcamento
            // 
            this.Rbmenuorcamento.Text = "Orçamento";
            // 
            // Rbmenumanutencao
            // 
            this.Rbmenumanutencao.Panels.Add(this.ribbonPanel4);
            this.Rbmenumanutencao.Panels.Add(this.ribbonPanel6);
            this.Rbmenumanutencao.Panels.Add(this.ribbonPanel7);
            this.Rbmenumanutencao.Panels.Add(this.ribbonPanel8);
            this.Rbmenumanutencao.Text = "Manutenção";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.Rbcontroles);
            this.ribbonPanel4.Text = "Controles";
            // 
            // Rbcontroles
            // 
            this.Rbcontroles.Image = global::MaisGamers.Properties.Resources.games_icon;
            this.Rbcontroles.SmallImage = ((System.Drawing.Image)(resources.GetObject("Rbcontroles.SmallImage")));
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.Rbconsoles);
            this.ribbonPanel6.Text = "Consoles";
            // 
            // Rbconsoles
            // 
            this.Rbconsoles.Image = global::MaisGamers.Properties.Resources.ConsolePs4_fw;
            this.Rbconsoles.SmallImage = ((System.Drawing.Image)(resources.GetObject("Rbconsoles.SmallImage")));
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.Items.Add(this.Rbcelularetablet);
            this.ribbonPanel7.Text = "Celulares&Tablets";
            // 
            // Rbcelularetablet
            // 
            this.Rbcelularetablet.Image = global::MaisGamers.Properties.Resources.celular_tablet_fw;
            this.Rbcelularetablet.SmallImage = ((System.Drawing.Image)(resources.GetObject("Rbcelularetablet.SmallImage")));
            // 
            // ribbonPanel8
            // 
            this.ribbonPanel8.Items.Add(this.ribbonButton3);
            this.ribbonPanel8.Text = "Computadores";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = global::MaisGamers.Properties.Resources.ICONEPCNOTE_fw;
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            // 
            // Rblocacaodejogos
            // 
            this.Rblocacaodejogos.Panels.Add(this.ribbonPanel3);
            this.Rblocacaodejogos.Panels.Add(this.ribbonPanel5);
            this.Rblocacaodejogos.Text = "Locação de Jogos";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.Rblocacaocliente);
            this.ribbonPanel3.Text = "Cadastrar Cliente";
            // 
            // Rblocacaocliente
            // 
            this.Rblocacaocliente.Image = global::MaisGamers.Properties.Resources.cliente_fw;
            this.Rblocacaocliente.SmallImage = global::MaisGamers.Properties.Resources.cliente1;
            this.Rblocacaocliente.Click += new System.EventHandler(this.Rblocacaocliente_Click);
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.ribbonButton2);
            this.ribbonPanel5.Text = "Locação de Jogo";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = global::MaisGamers.Properties.Resources.ICONECD1;
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            // 
            // ribbonTab5
            // 
            this.ribbonTab5.Panels.Add(this.Rbps4);
            this.ribbonTab5.Panels.Add(this.Rbxboxone);
            this.ribbonTab5.Panels.Add(this.Rbps3);
            this.ribbonTab5.Panels.Add(this.Rbxbox360);
            this.ribbonTab5.Text = "Venda de Jogos";
            // 
            // Rbps4
            // 
            this.Rbps4.Items.Add(this.Rbiconeps4);
            this.Rbps4.Text = "PS4";
            // 
            // Rbiconeps4
            // 
            this.Rbiconeps4.Image = global::MaisGamers.Properties.Resources.iconeps4_fw;
            this.Rbiconeps4.SmallImage = ((System.Drawing.Image)(resources.GetObject("Rbiconeps4.SmallImage")));
            // 
            // Rbxboxone
            // 
            this.Rbxboxone.Items.Add(this.ribbonButton4);
            this.Rbxboxone.Text = "Xbox One";
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = global::MaisGamers.Properties.Resources.Xbox_one_icon_fw;
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            // 
            // Rbps3
            // 
            this.Rbps3.Items.Add(this.Rbiconeps3);
            this.Rbps3.Text = "PS3";
            // 
            // Rbiconeps3
            // 
            this.Rbiconeps3.Image = global::MaisGamers.Properties.Resources.iconeps3_fw;
            this.Rbiconeps3.SmallImage = ((System.Drawing.Image)(resources.GetObject("Rbiconeps3.SmallImage")));
            // 
            // Rbxbox360
            // 
            this.Rbxbox360.Items.Add(this.Rbx360);
            this.Rbxbox360.Text = "Xbox 360";
            // 
            // Rbx360
            // 
            this.Rbx360.Image = global::MaisGamers.Properties.Resources.iconex360_fw;
            this.Rbx360.SmallImage = ((System.Drawing.Image)(resources.GetObject("Rbx360.SmallImage")));
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Panels.Add(this.ribbonPanel9);
            this.ribbonTab3.Panels.Add(this.Rbfluxo);
            this.ribbonTab3.Text = "Locação por Hora";
            // 
            // ribbonPanel9
            // 
            this.ribbonPanel9.Items.Add(this.Rblancahora);
            this.ribbonPanel9.Text = "Lançar Hora";
            // 
            // Rblancahora
            // 
            this.Rblancahora.Image = global::MaisGamers.Properties.Resources.relogio_fw;
            this.Rblancahora.SmallImage = ((System.Drawing.Image)(resources.GetObject("Rblancahora.SmallImage")));
            this.Rblancahora.Click += new System.EventHandler(this.Rblancahora_Click);
            // 
            // Rbfluxo
            // 
            this.Rbfluxo.Items.Add(this.Rbcaixa);
            this.Rbfluxo.Text = "Caixa";
            // 
            // Rbcaixa
            // 
            this.Rbcaixa.Image = global::MaisGamers.Properties.Resources.Sem_título_1_fw;
            this.Rbcaixa.SmallImage = ((System.Drawing.Image)(resources.GetObject("Rbcaixa.SmallImage")));
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 574);
            this.Controls.Add(this.ribbon1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mais Gamers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonTab Rbmenucadastro;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton rbCliente;
        private System.Windows.Forms.RibbonTab Rbmenuorcamento;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton rbJogos;
        private System.Windows.Forms.RibbonTab Rbmenumanutencao;
        private System.Windows.Forms.RibbonTab Rblocacaodejogos;
        private System.Windows.Forms.RibbonTab ribbonTab5;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton Rbcontroles;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.RibbonPanel ribbonPanel8;
        private System.Windows.Forms.RibbonButton Rblocacaocliente;
        private System.Windows.Forms.RibbonButton Rbconsoles;
        private System.Windows.Forms.RibbonButton Rbcelularetablet;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonPanel ribbonPanel9;
        private System.Windows.Forms.RibbonButton Rblancahora;
        private System.Windows.Forms.RibbonPanel Rbps4;
        private System.Windows.Forms.RibbonButton Rbiconeps4;
        private System.Windows.Forms.RibbonPanel Rbxboxone;
        private System.Windows.Forms.RibbonPanel Rbps3;
        private System.Windows.Forms.RibbonPanel Rbxbox360;
        private System.Windows.Forms.RibbonPanel Rbfluxo;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonButton Rbiconeps3;
        private System.Windows.Forms.RibbonButton Rbx360;
        private System.Windows.Forms.RibbonButton Rbcaixa;
    }
}

