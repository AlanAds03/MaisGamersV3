namespace MaisGamers.Formularios.Cadastro
{
    partial class frmClienteLocacao
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBotoes = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpPesquisa.SuspendLayout();
            this.grpBotoes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(24, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(711, 226);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Image = global::MaisGamers.Properties.Resources.iconeSearch32X32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pesquisar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::MaisGamers.Properties.Resources.iconeLimpar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(126, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Limpar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.textBox2);
            this.grpPesquisa.Controls.Add(this.label2);
            this.grpPesquisa.Controls.Add(this.listView1);
            this.grpPesquisa.Controls.Add(this.label1);
            this.grpPesquisa.Controls.Add(this.textBox1);
            this.grpPesquisa.Location = new System.Drawing.Point(59, 19);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(816, 383);
            this.grpPesquisa.TabIndex = 6;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisa";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // grpBotoes
            // 
            this.grpBotoes.Controls.Add(this.button2);
            this.grpBotoes.Controls.Add(this.button1);
            this.grpBotoes.Controls.Add(this.button3);
            this.grpBotoes.Location = new System.Drawing.Point(123, 408);
            this.grpBotoes.Name = "grpBotoes";
            this.grpBotoes.Size = new System.Drawing.Size(349, 77);
            this.grpBotoes.TabIndex = 7;
            this.grpBotoes.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(94, 138);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 528);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpBotoes);
            this.tabPage1.Controls.Add(this.grpPesquisa);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1051, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1051, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmClienteLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1289, 696);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmClienteLocacao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClienteLocacao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClienteLocacao_Load);
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.grpBotoes.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox grpBotoes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}