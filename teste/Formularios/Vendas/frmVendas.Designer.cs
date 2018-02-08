namespace MaisGamers.Formularios.Cadastro
{
    partial class frmVendas
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
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.tpLocacao = new System.Windows.Forms.TabPage();
            this.grpGridLocacao = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirJogo = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVendas = new System.Windows.Forms.TabControl();
            this.cmbQuantidade = new Frameworks.Componentes.SuperComboBox();
            this.cmdTipoPagamento = new Frameworks.Componentes.SuperComboBox();
            this.txtTotal = new Frameworks.Componentes.SuperTextBox();
            this.txtCliente = new Frameworks.Componentes.SuperTextBox();
            this.txtTroco = new Frameworks.Componentes.SuperTextBox();
            this.txtValorPago = new Frameworks.Componentes.SuperTextBox();
            this.lvLocacao = new Frameworks.Componentes.SuperLV();
            this.tpLocacao.SuspendLayout();
            this.grpGridLocacao.SuspendLayout();
            this.tbVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Image = global::MaisGamers.Properties.Resources.iconePagamento;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(234, 447);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(114, 60);
            this.btnFinalizar.TabIndex = 26;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // tpLocacao
            // 
            this.tpLocacao.Controls.Add(this.grpGridLocacao);
            this.tpLocacao.Location = new System.Drawing.Point(4, 22);
            this.tpLocacao.Name = "tpLocacao";
            this.tpLocacao.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocacao.Size = new System.Drawing.Size(1081, 587);
            this.tpLocacao.TabIndex = 1;
            this.tpLocacao.Text = "Vendas";
            this.tpLocacao.UseVisualStyleBackColor = true;
            // 
            // grpGridLocacao
            // 
            this.grpGridLocacao.Controls.Add(this.cmbQuantidade);
            this.grpGridLocacao.Controls.Add(this.button4);
            this.grpGridLocacao.Controls.Add(this.button2);
            this.grpGridLocacao.Controls.Add(this.btnFinalizar);
            this.grpGridLocacao.Controls.Add(this.label4);
            this.grpGridLocacao.Controls.Add(this.cmdTipoPagamento);
            this.grpGridLocacao.Controls.Add(this.txtTotal);
            this.grpGridLocacao.Controls.Add(this.label6);
            this.grpGridLocacao.Controls.Add(this.label3);
            this.grpGridLocacao.Controls.Add(this.txtCliente);
            this.grpGridLocacao.Controls.Add(this.txtTroco);
            this.grpGridLocacao.Controls.Add(this.label1);
            this.grpGridLocacao.Controls.Add(this.txtValorPago);
            this.grpGridLocacao.Controls.Add(this.btnExcluirJogo);
            this.grpGridLocacao.Controls.Add(this.btnAdicionarProduto);
            this.grpGridLocacao.Controls.Add(this.label2);
            this.grpGridLocacao.Controls.Add(this.lvLocacao);
            this.grpGridLocacao.Location = new System.Drawing.Point(6, 6);
            this.grpGridLocacao.Name = "grpGridLocacao";
            this.grpGridLocacao.Size = new System.Drawing.Size(1069, 527);
            this.grpGridLocacao.TabIndex = 1;
            this.grpGridLocacao.TabStop = false;
            // 
            // button4
            // 
            this.button4.Image = global::MaisGamers.Properties.Resources.iconeFechar32;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(458, 447);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 60);
            this.button4.TabIndex = 41;
            this.button4.Text = "Fechar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Image = global::MaisGamers.Properties.Resources.iconeimpressora;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(354, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 60);
            this.button2.TabIndex = 39;
            this.button2.Text = "Imprimir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(577, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "Tipo de Pagamento: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(577, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "Total : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(581, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Valor pago: ";
            // 
            // btnExcluirJogo
            // 
            this.btnExcluirJogo.Image = global::MaisGamers.Properties.Resources.iconemenos;
            this.btnExcluirJogo.Location = new System.Drawing.Point(77, 19);
            this.btnExcluirJogo.Name = "btnExcluirJogo";
            this.btnExcluirJogo.Size = new System.Drawing.Size(45, 29);
            this.btnExcluirJogo.TabIndex = 25;
            this.btnExcluirJogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirJogo.UseVisualStyleBackColor = true;
            this.btnExcluirJogo.Click += new System.EventHandler(this.btnExcluirJogo_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Image = global::MaisGamers.Properties.Resources.iconemais;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(26, 19);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(45, 29);
            this.btnAdicionarProduto.TabIndex = 18;
            this.btnAdicionarProduto.Text = " ";
            this.btnAdicionarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Troco: ";
            // 
            // tbVendas
            // 
            this.tbVendas.Controls.Add(this.tpLocacao);
            this.tbVendas.Location = new System.Drawing.Point(89, 28);
            this.tbVendas.Name = "tbVendas";
            this.tbVendas.SelectedIndex = 0;
            this.tbVendas.Size = new System.Drawing.Size(1089, 613);
            this.tbVendas.TabIndex = 9;
            // 
            // cmbQuantidade
            // 
            this.cmbQuantidade.CampoObrigatorio = false;
            this.cmbQuantidade.Carregado = false;
            this.cmbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuantidade.FormattingEnabled = true;
            this.cmbQuantidade.Location = new System.Drawing.Point(785, 215);
            this.cmbQuantidade.Name = "cmbQuantidade";
            this.cmbQuantidade.Size = new System.Drawing.Size(59, 37);
            this.cmbQuantidade.TabIndex = 42;
            this.cmbQuantidade.Visible = false;
            this.cmbQuantidade.SelectedIndexChanged += new System.EventHandler(this.cmbQuantidade_SelectedIndexChanged);
            this.cmbQuantidade.SelectedValueChanged += new System.EventHandler(this.cbmQuantidade_SelectedValueChanged);
            // 
            // cmdTipoPagamento
            // 
            this.cmdTipoPagamento.CampoObrigatorio = false;
            this.cmdTipoPagamento.Carregado = false;
            this.cmdTipoPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTipoPagamento.FormattingEnabled = true;
            this.cmdTipoPagamento.Location = new System.Drawing.Point(586, 215);
            this.cmdTipoPagamento.Name = "cmdTipoPagamento";
            this.cmdTipoPagamento.Size = new System.Drawing.Size(193, 37);
            this.cmdTipoPagamento.TabIndex = 37;
            this.cmdTipoPagamento.SelectedValueChanged += new System.EventHandler(this.cmdTipoPagamento_SelectedValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.CampoObrigatorio = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(582, 124);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(140, 35);
            this.txtTotal.TabIndex = 36;
            // 
            // txtCliente
            // 
            this.txtCliente.CampoObrigatorio = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(582, 54);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(391, 35);
            this.txtCliente.TabIndex = 30;
            // 
            // txtTroco
            // 
            this.txtTroco.CampoObrigatorio = false;
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(586, 368);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(140, 35);
            this.txtTroco.TabIndex = 28;
            // 
            // txtValorPago
            // 
            this.txtValorPago.CampoObrigatorio = false;
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(586, 298);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(140, 35);
            this.txtValorPago.TabIndex = 26;
            this.txtValorPago.TextChanged += new System.EventHandler(this.txtValorPago_TextChanged);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // lvLocacao
            // 
            this.lvLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLocacao.GridLines = true;
            this.lvLocacao.Location = new System.Drawing.Point(15, 54);
            this.lvLocacao.Name = "lvLocacao";
            this.lvLocacao.Size = new System.Drawing.Size(493, 372);
            this.lvLocacao.TabIndex = 0;
            this.lvLocacao.UseCompatibleStateImageBehavior = false;
            this.lvLocacao.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvLocacao_ItemChecked);
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1386, 684);
            this.ControlBox = false;
            this.Controls.Add(this.tbVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVendas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadJogo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.tpLocacao.ResumeLayout(false);
            this.grpGridLocacao.ResumeLayout(false);
            this.grpGridLocacao.PerformLayout();
            this.tbVendas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tpLocacao;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.GroupBox grpGridLocacao;
        private Frameworks.Componentes.SuperTextBox txtTroco;
        private System.Windows.Forms.Label label1;
        private Frameworks.Componentes.SuperTextBox txtValorPago;
        private System.Windows.Forms.Button btnExcluirJogo;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Label label2;
        private Frameworks.Componentes.SuperLV lvLocacao;
        private System.Windows.Forms.TabControl tbVendas;
        private System.Windows.Forms.Label label3;
        private Frameworks.Componentes.SuperTextBox txtCliente;
        private Frameworks.Componentes.SuperTextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Frameworks.Componentes.SuperComboBox cmdTipoPagamento;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private Frameworks.Componentes.SuperComboBox cmbQuantidade;
    }
}