namespace MaisGamers.Formularios.Cadastro
{
    partial class frmPesquisaJogo
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
            this.cmbConsolePesquisa = new Frameworks.Componentes.SuperComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.grpGrid = new System.Windows.Forms.GroupBox();
            this.lvPesquisa = new Frameworks.Componentes.SuperLV();
            this.grpBotoes = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPesquisa = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpFiltro.SuspendLayout();
            this.grpGrid.SuspendLayout();
            this.grpBotoes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpPesquisa.SuspendLayout();
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
            // txtPesqNome
            // 
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
            // grpBotoes
            // 
            this.grpBotoes.Controls.Add(this.btnSalvar);
            this.grpBotoes.Controls.Add(this.button2);
            this.grpBotoes.Controls.Add(this.btnFechar);
            this.grpBotoes.Location = new System.Drawing.Point(149, 515);
            this.grpBotoes.Name = "grpBotoes";
            this.grpBotoes.Size = new System.Drawing.Size(311, 66);
            this.grpBotoes.TabIndex = 8;
            this.grpBotoes.TabStop = false;
            // 
            // button2
            // 
            this.button2.Image = global::MaisGamers.Properties.Resources.iconeLimpar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(103, 8);
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
            this.btnFechar.Location = new System.Drawing.Point(202, 8);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 475);
            this.tabControl1.TabIndex = 9;
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Controls.Add(this.grpFiltro);
            this.tpPesquisa.Controls.Add(this.grpGrid);
            this.tpPesquisa.Location = new System.Drawing.Point(4, 22);
            this.tpPesquisa.Name = "tpPesquisa";
            this.tpPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tpPesquisa.Size = new System.Drawing.Size(804, 449);
            this.tpPesquisa.TabIndex = 0;
            this.tpPesquisa.Text = "Pesquisa";
            this.tpPesquisa.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::MaisGamers.Properties.Resources.iconeSalvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(6, 8);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 50);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmPesquisaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(854, 585);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.grpBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPesquisaJogo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadJogo";
            this.Load += new System.EventHandler(this.frmCadJogo_Load);
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.grpGrid.ResumeLayout(false);
            this.grpBotoes.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpPesquisa.ResumeLayout(false);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSalvar;
    }
}