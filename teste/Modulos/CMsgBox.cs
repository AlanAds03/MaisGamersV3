using MaisGamers.Modulos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frameworks.Classes
{
    public class CMsgBox : System.Windows.Forms.Form
    {
        private System.Windows.Forms.PictureBox btnYes;
        private System.Windows.Forms.PictureBox btnNo;
        private Label lblMensagem;
        private Panel panel1;
        private Panel panel2;
        private Label labelTitulo;
        private Panel panel3;
        public DialogResult result;


        public enum TipoBotoes {
            SimNao,
            OK
            
        }

        public enum TipoErro
        {
            Ok,
            Erro,
            Informacao
        }
        public CMsgBox(string mensagem, TipoBotoes tipoBotoes, TipoErro tipoErro)
        {
            
            InitializeComponent();

            if (tipoBotoes == TipoBotoes.SimNao)
            {
                btnYes.Visible = true;
                btnNo.Visible = true;
                btnYes.Left = this.Bounds.Width / 2 - 80;
                btnNo.Left = this.Bounds.Width / 2;
            }
            else
            {
                btnYes.Visible = true;
                btnNo.Visible = false;
                btnYes.Left = this.Bounds.Width / 2 - 40;
            }

            //util.CentralizaGrupo(grpBotoes,false);
            lblMensagem.MaximumSize = new Size(450, 0);
            lblMensagem.AutoSize = true;
            lblMensagem.Text = mensagem;
            int width;
            int height;

            width = Screen.PrimaryScreen.Bounds.Width;
            height = Screen.PrimaryScreen.Bounds.Height;

            this.StartPosition = FormStartPosition.CenterScreen;
            //this.Top = height /2;
            //this.Left = width / 2;
            this.AutoSize = true;
            //this.Text = "nome";
            //this.Width = 350;
            //this.Height = 350;

            if(tipoErro == TipoErro.Ok)
            {
                panel2.BackColor = Color.LightGreen;
                panel3.BackColor = Color.LightGreen;
                labelTitulo.Text = "Confirmação";
            }
            else if (tipoErro == TipoErro.Informacao)
            {
                panel2.BackColor = Color.CadetBlue;
                panel3.BackColor = Color.CadetBlue;
                labelTitulo.Text = "Informação";
            }
            else if (tipoErro == TipoErro.Erro)
            {
                panel2.BackColor = Color.Brown;
                panel3.BackColor = Color.Brown;
                labelTitulo.Text = "Erro";
            }

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMsgBox));
            this.btnYes = new System.Windows.Forms.PictureBox();
            this.btnNo = new System.Windows.Forms.PictureBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Image = ((System.Drawing.Image)(resources.GetObject("btnYes.Image")));
            this.btnYes.Location = new System.Drawing.Point(163, 88);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(64, 64);
            this.btnYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnYes.TabIndex = 2;
            this.btnYes.TabStop = false;
            this.btnYes.Click += new System.EventHandler(this.pictureBox1_Click);
            this.btnYes.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.btnYes.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // btnNo
            // 
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.Location = new System.Drawing.Point(256, 88);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(64, 64);
            this.btnNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnNo.TabIndex = 3;
            this.btnNo.TabStop = false;
            this.btnNo.Click += new System.EventHandler(this.pictureBox2_Click);
            this.btnNo.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.btnNo.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMensagem.Location = new System.Drawing.Point(63, 26);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(328, 30);
            this.lblMensagem.TabIndex = 4;
            this.lblMensagem.Text = "Registro inserido com sucesso";
            this.lblMensagem.Click += new System.EventHandler(this.lblMensagem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNo);
            this.panel1.Controls.Add(this.btnYes);
            this.panel1.Controls.Add(this.lblMensagem);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 218);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.labelTitulo);
            this.panel2.Location = new System.Drawing.Point(-5, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 33);
            this.panel2.TabIndex = 6;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitulo.Location = new System.Drawing.Point(205, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(116, 24);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Confirmação";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 33);
            this.panel3.TabIndex = 7;
            // 
            // CMsgBox
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(507, 289);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CMsgBox";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            this.Close();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            this.Close();
        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }
    }
}
