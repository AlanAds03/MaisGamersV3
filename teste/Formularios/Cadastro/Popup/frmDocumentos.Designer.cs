namespace MaisGamers.Formularios.Cadastro.Popup
{
    partial class frmDocumentos
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbRG = new System.Windows.Forms.RadioButton();
            this.rbContrato = new System.Windows.Forms.RadioButton();
            this.rbComprovante = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Image = global::MaisGamers.Properties.Resources.iconeSearch32X32;
            this.btnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrir.Location = new System.Drawing.Point(9, 89);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(101, 52);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::MaisGamers.Properties.Resources.iconeSalvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(116, 89);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 52);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Anexar Documento";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::MaisGamers.Properties.Resources.iconeFechar32;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(243, 89);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(125, 52);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnAbrir);
            this.groupBox1.Controls.Add(this.btnFechar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Location = new System.Drawing.Point(3, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 164);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbComprovante);
            this.groupBox2.Controls.Add(this.rbContrato);
            this.groupBox2.Controls.Add(this.rbRG);
            this.groupBox2.Location = new System.Drawing.Point(9, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 61);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Documentos";
            // 
            // rbRG
            // 
            this.rbRG.AutoSize = true;
            this.rbRG.Location = new System.Drawing.Point(16, 19);
            this.rbRG.Name = "rbRG";
            this.rbRG.Size = new System.Drawing.Size(41, 17);
            this.rbRG.TabIndex = 0;
            this.rbRG.TabStop = true;
            this.rbRG.Text = "RG";
            this.rbRG.UseVisualStyleBackColor = true;
            this.rbRG.CheckedChanged += new System.EventHandler(this.rbRG_CheckedChanged);
            // 
            // rbContrato
            // 
            this.rbContrato.AutoSize = true;
            this.rbContrato.Location = new System.Drawing.Point(63, 19);
            this.rbContrato.Name = "rbContrato";
            this.rbContrato.Size = new System.Drawing.Size(65, 17);
            this.rbContrato.TabIndex = 1;
            this.rbContrato.TabStop = true;
            this.rbContrato.Text = "Contrato";
            this.rbContrato.UseVisualStyleBackColor = true;
            this.rbContrato.CheckedChanged += new System.EventHandler(this.rbContrato_CheckedChanged);
            // 
            // rbComprovante
            // 
            this.rbComprovante.AutoSize = true;
            this.rbComprovante.Location = new System.Drawing.Point(134, 19);
            this.rbComprovante.Name = "rbComprovante";
            this.rbComprovante.Size = new System.Drawing.Size(137, 17);
            this.rbComprovante.TabIndex = 2;
            this.rbComprovante.TabStop = true;
            this.rbComprovante.Text = "Comprovante Endereço";
            this.rbComprovante.UseVisualStyleBackColor = true;
            this.rbComprovante.CheckedChanged += new System.EventHandler(this.rbComprovante_CheckedChanged);
            // 
            // frmDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 212);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDocumentos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbComprovante;
        private System.Windows.Forms.RadioButton rbContrato;
        private System.Windows.Forms.RadioButton rbRG;
    }
}