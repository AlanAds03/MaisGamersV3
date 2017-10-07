namespace MaisGamers.Formularios.Impressao
{
    partial class frmImpressao
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
            this.cmbImpressora = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAutorizado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Impressora";
            // 
            // cmbImpressora
            // 
            this.cmbImpressora.FormattingEnabled = true;
            this.cmbImpressora.Location = new System.Drawing.Point(91, 37);
            this.cmbImpressora.Name = "cmbImpressora";
            this.cmbImpressora.Size = new System.Drawing.Size(198, 21);
            this.cmbImpressora.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autorizado";
            // 
            // cmbAutorizado
            // 
            this.cmbAutorizado.FormattingEnabled = true;
            this.cmbAutorizado.Location = new System.Drawing.Point(91, 74);
            this.cmbAutorizado.Name = "cmbAutorizado";
            this.cmbAutorizado.Size = new System.Drawing.Size(121, 21);
            this.cmbAutorizado.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbAutorizado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbImpressora);
            this.Controls.Add(this.label1);
            this.Name = "frmImpressao";
            this.Text = "frmImpressao";
            this.Load += new System.EventHandler(this.frmImpressao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbImpressora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAutorizado;
        private System.Windows.Forms.Button button1;
    }
}