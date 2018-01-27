namespace MaisGamers.Formularios.Locacao
{
    partial class frmPopupFehamento
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
            this.txtValorPagoLocacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvalordevido = new System.Windows.Forms.TextBox();
            this.txtRestantePagar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorTroco = new System.Windows.Forms.TextBox();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataLocacao = new System.Windows.Forms.DateTimePicker();
            this.txtDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtDataPrevista = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pago na Locação:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtValorPagoLocacao
            // 
            this.txtValorPagoLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagoLocacao.Location = new System.Drawing.Point(170, 163);
            this.txtValorPagoLocacao.Name = "txtValorPagoLocacao";
            this.txtValorPagoLocacao.Size = new System.Drawing.Size(163, 31);
            this.txtValorPagoLocacao.TabIndex = 2;
            this.txtValorPagoLocacao.TextChanged += new System.EventHandler(this.txtValorPagoLocacao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Devido:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Restante a Pagar:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtvalordevido
            // 
            this.txtvalordevido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalordevido.Location = new System.Drawing.Point(170, 131);
            this.txtvalordevido.Name = "txtvalordevido";
            this.txtvalordevido.Size = new System.Drawing.Size(163, 31);
            this.txtvalordevido.TabIndex = 5;
            // 
            // txtRestantePagar
            // 
            this.txtRestantePagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestantePagar.Location = new System.Drawing.Point(170, 195);
            this.txtRestantePagar.Name = "txtRestantePagar";
            this.txtRestantePagar.Size = new System.Drawing.Size(163, 31);
            this.txtRestantePagar.TabIndex = 6;
            this.txtRestantePagar.TextChanged += new System.EventHandler(this.txtValorPagoEntrega_TextChanged);
            this.txtRestantePagar.Leave += new System.EventHandler(this.txtValorPagoEntrega_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Troco:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtValorTroco
            // 
            this.txtValorTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTroco.Location = new System.Drawing.Point(170, 259);
            this.txtValorTroco.Name = "txtValorTroco";
            this.txtValorTroco.Size = new System.Drawing.Size(163, 31);
            this.txtValorTroco.TabIndex = 8;
            this.txtValorTroco.TextChanged += new System.EventHandler(this.txtValorTroco_TextChanged);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(231, 304);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(102, 64);
            this.btnConcluir.TabIndex = 9;
            this.btnConcluir.Text = "Concluir locação";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data locação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Entrega:";
            // 
            // txtDataLocacao
            // 
            this.txtDataLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataLocacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataLocacao.Location = new System.Drawing.Point(170, 34);
            this.txtDataLocacao.Name = "txtDataLocacao";
            this.txtDataLocacao.Size = new System.Drawing.Size(139, 31);
            this.txtDataLocacao.TabIndex = 14;
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEntrega.Location = new System.Drawing.Point(170, 97);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(139, 31);
            this.txtDataEntrega.TabIndex = 15;
            this.txtDataEntrega.ValueChanged += new System.EventHandler(this.txtDataEntrega_ValueChanged);
            this.txtDataEntrega.Leave += new System.EventHandler(this.txtDataEntrega_Leave);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(339, 304);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(102, 64);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtDataPrevista
            // 
            this.txtDataPrevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataPrevista.Location = new System.Drawing.Point(170, 66);
            this.txtDataPrevista.Name = "txtDataPrevista";
            this.txtDataPrevista.Size = new System.Drawing.Size(139, 31);
            this.txtDataPrevista.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data Prevista:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Pago:";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(170, 227);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(163, 31);
            this.txtValorPago.TabIndex = 20;
            this.txtValorPago.TextChanged += new System.EventHandler(this.txtValorPago_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtValorPago);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtValorPagoLocacao);
            this.groupBox1.Controls.Add(this.txtDataPrevista);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnFechar);
            this.groupBox1.Controls.Add(this.txtvalordevido);
            this.groupBox1.Controls.Add(this.txtDataEntrega);
            this.groupBox1.Controls.Add(this.txtRestantePagar);
            this.groupBox1.Controls.Add(this.txtDataLocacao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtValorTroco);
            this.groupBox1.Controls.Add(this.btnConcluir);
            this.groupBox1.Location = new System.Drawing.Point(49, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 374);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(177, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 79);
            this.label9.TabIndex = 22;
            this.label9.Text = "CAIXA";
            // 
            // frmPopupFehamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(531, 520);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPopupFehamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPopupFehamento";
            this.Load += new System.EventHandler(this.frmPopupFehamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorPagoLocacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvalordevido;
        private System.Windows.Forms.TextBox txtRestantePagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorTroco;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtDataLocacao;
        private System.Windows.Forms.DateTimePicker txtDataEntrega;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DateTimePicker txtDataPrevista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
    }
}