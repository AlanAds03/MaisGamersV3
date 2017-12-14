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
            this.txtValorPagoEntrega = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Pago na Locação:";
            // 
            // txtValorPagoLocacao
            // 
            this.txtValorPagoLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagoLocacao.Location = new System.Drawing.Point(159, 142);
            this.txtValorPagoLocacao.Name = "txtValorPagoLocacao";
            this.txtValorPagoLocacao.Size = new System.Drawing.Size(163, 26);
            this.txtValorPagoLocacao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor Devido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor Pago na Entrega:";
            // 
            // txtvalordevido
            // 
            this.txtvalordevido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalordevido.Location = new System.Drawing.Point(159, 115);
            this.txtvalordevido.Name = "txtvalordevido";
            this.txtvalordevido.Size = new System.Drawing.Size(163, 26);
            this.txtvalordevido.TabIndex = 5;
            // 
            // txtValorPagoEntrega
            // 
            this.txtValorPagoEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPagoEntrega.Location = new System.Drawing.Point(159, 169);
            this.txtValorPagoEntrega.Name = "txtValorPagoEntrega";
            this.txtValorPagoEntrega.Size = new System.Drawing.Size(163, 26);
            this.txtValorPagoEntrega.TabIndex = 6;
            this.txtValorPagoEntrega.Leave += new System.EventHandler(this.txtValorPagoEntrega_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Troco:";
            // 
            // txtValorTroco
            // 
            this.txtValorTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTroco.Location = new System.Drawing.Point(159, 198);
            this.txtValorTroco.Name = "txtValorTroco";
            this.txtValorTroco.Size = new System.Drawing.Size(163, 26);
            this.txtValorTroco.TabIndex = 8;
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(106, 232);
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
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data locação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Entrega:";
            // 
            // txtDataLocacao
            // 
            this.txtDataLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataLocacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataLocacao.Location = new System.Drawing.Point(161, 25);
            this.txtDataLocacao.Name = "txtDataLocacao";
            this.txtDataLocacao.Size = new System.Drawing.Size(105, 26);
            this.txtDataLocacao.TabIndex = 14;
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEntrega.Location = new System.Drawing.Point(159, 88);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(105, 26);
            this.txtDataEntrega.TabIndex = 15;
            this.txtDataEntrega.ValueChanged += new System.EventHandler(this.txtDataEntrega_ValueChanged);
            this.txtDataEntrega.Leave += new System.EventHandler(this.txtDataEntrega_Leave);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(214, 232);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(102, 64);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtDataPrevista
            // 
            this.txtDataPrevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataPrevista.Location = new System.Drawing.Point(159, 57);
            this.txtDataPrevista.Name = "txtDataPrevista";
            this.txtDataPrevista.Size = new System.Drawing.Size(105, 26);
            this.txtDataPrevista.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data Prevista:";
            // 
            // frmPopupFehamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 330);
            this.ControlBox = false;
            this.Controls.Add(this.txtDataPrevista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtDataEntrega);
            this.Controls.Add(this.txtDataLocacao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.txtValorTroco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorPagoEntrega);
            this.Controls.Add(this.txtvalordevido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorPagoLocacao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPopupFehamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPopupFehamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorPagoLocacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvalordevido;
        private System.Windows.Forms.TextBox txtValorPagoEntrega;
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
    }
}