﻿namespace MaisGamers.Formularios.Horas
{
    partial class frmHoras
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.superComboBox1 = new Frameworks.Componentes.SuperComboBox();
            this.cmdHora = new Frameworks.Componentes.SuperComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPainel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblRestante1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFIM1 = new System.Windows.Forms.Label();
            this.lblInicio1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtValorPagar1 = new Frameworks.Componentes.SuperTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.superTextBox2 = new Frameworks.Componentes.SuperTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlPainel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "INICIO";
            // 
            // superComboBox1
            // 
            this.superComboBox1.CampoObrigatorio = false;
            this.superComboBox1.Carregado = false;
            this.superComboBox1.FormattingEnabled = true;
            this.superComboBox1.Location = new System.Drawing.Point(635, 151);
            this.superComboBox1.Name = "superComboBox1";
            this.superComboBox1.Size = new System.Drawing.Size(121, 21);
            this.superComboBox1.TabIndex = 3;
            // 
            // cmdHora
            // 
            this.cmdHora.CampoObrigatorio = false;
            this.cmdHora.Carregado = false;
            this.cmdHora.FormattingEnabled = true;
            this.cmdHora.Location = new System.Drawing.Point(20, 299);
            this.cmdHora.Name = "cmdHora";
            this.cmdHora.Size = new System.Drawing.Size(121, 21);
            this.cmdHora.TabIndex = 4;
            this.cmdHora.SelectedIndexChanged += new System.EventHandler(this.cmdHora_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 5;
            // 
            // pnlPainel
            // 
            this.pnlPainel.Controls.Add(this.groupBox1);
            this.pnlPainel.Controls.Add(this.superTextBox2);
            this.pnlPainel.Controls.Add(this.label4);
            this.pnlPainel.Controls.Add(this.button1);
            this.pnlPainel.Controls.Add(this.superComboBox1);
            this.pnlPainel.Controls.Add(this.label3);
            this.pnlPainel.Location = new System.Drawing.Point(12, 12);
            this.pnlPainel.Name = "pnlPainel";
            this.pnlPainel.Size = new System.Drawing.Size(1403, 545);
            this.pnlPainel.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.lblRestante1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblFIM1);
            this.groupBox1.Controls.Add(this.lblInicio1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtValorPagar1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdHora);
            this.groupBox1.Location = new System.Drawing.Point(18, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 531);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 467);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 45);
            this.button5.TabIndex = 20;
            this.button5.Text = "Guardar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(83, 467);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 45);
            this.button4.TabIndex = 19;
            this.button4.Text = "Finalizar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblRestante1
            // 
            this.lblRestante1.AutoSize = true;
            this.lblRestante1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestante1.Location = new System.Drawing.Point(81, 223);
            this.lblRestante1.Name = "lblRestante1";
            this.lblRestante1.Size = new System.Drawing.Size(80, 24);
            this.lblRestante1.TabIndex = 18;
            this.lblRestante1.Text = "19:14:00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "RESTANTE";
            // 
            // lblFIM1
            // 
            this.lblFIM1.AutoSize = true;
            this.lblFIM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFIM1.Location = new System.Drawing.Point(77, 155);
            this.lblFIM1.Name = "lblFIM1";
            this.lblFIM1.Size = new System.Drawing.Size(80, 24);
            this.lblFIM1.TabIndex = 16;
            this.lblFIM1.Text = "19:14:00";
            // 
            // lblInicio1
            // 
            this.lblInicio1.AutoSize = true;
            this.lblInicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio1.Location = new System.Drawing.Point(77, 98);
            this.lblInicio1.Name = "lblInicio1";
            this.lblInicio1.Size = new System.Drawing.Size(80, 24);
            this.lblInicio1.TabIndex = 12;
            this.lblInicio1.Text = "19:14:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Valor à Pagar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "FIM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Horas";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(85, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 45);
            this.button3.TabIndex = 13;
            this.button3.Text = "Pausar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtValorPagar1
            // 
            this.txtValorPagar1.CampoObrigatorio = false;
            this.txtValorPagar1.Location = new System.Drawing.Point(20, 351);
            this.txtValorPagar1.Name = "txtValorPagar1";
            this.txtValorPagar1.Size = new System.Drawing.Size(122, 20);
            this.txtValorPagar1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 45);
            this.button2.TabIndex = 12;
            this.button2.Text = "Iniciar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "PS4 1";
            // 
            // superTextBox2
            // 
            this.superTextBox2.CampoObrigatorio = false;
            this.superTextBox2.Location = new System.Drawing.Point(635, 303);
            this.superTextBox2.Name = "superTextBox2";
            this.superTextBox2.Size = new System.Drawing.Size(100, 20);
            this.superTextBox2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(622, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(631, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MaisGamers.Properties.Resources.iconclock;
            this.pictureBox2.Location = new System.Drawing.Point(6, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaisGamers.Properties.Resources.iconclock;
            this.pictureBox1.Location = new System.Drawing.Point(6, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 603);
            this.Controls.Add(this.pnlPainel);
            this.Name = "frmHoras";
            this.Text = "frmHoras";
            this.pnlPainel.ResumeLayout(false);
            this.pnlPainel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Frameworks.Componentes.SuperComboBox superComboBox1;
        private Frameworks.Componentes.SuperComboBox cmdHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPainel;
        private System.Windows.Forms.Label label3;
        private Frameworks.Componentes.SuperTextBox txtValorPagar1;
        private System.Windows.Forms.Label label4;
        private Frameworks.Componentes.SuperTextBox superTextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRestante1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFIM1;
        private System.Windows.Forms.Label lblInicio1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}