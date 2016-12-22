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
        private GroupBox grpBotoes;
        private Panel panel2;
        private Label label1;
        public DialogResult result;


        public enum TipoBotoes {
            SimNao,
            OK
            
        }
        public CMsgBox(string mensagem, TipoBotoes tipoBotoes)
        {
            
            InitializeComponent();

            if (tipoBotoes == TipoBotoes.SimNao)
            {
                btnYes.Visible = true;
                btnNo.Visible = true;
            }
            else
            {
                btnYes.Visible = true;
                btnNo.Visible = false;
            }

            util.CentralizaGrupo(grpBotoes,false);

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



        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMsgBox));
            this.btnYes = new System.Windows.Forms.PictureBox();
            this.btnNo = new System.Windows.Forms.PictureBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpBotoes = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpBotoes.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Image = ((System.Drawing.Image)(resources.GetObject("btnYes.Image")));
            this.btnYes.Location = new System.Drawing.Point(15, 9);
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
            this.btnNo.Location = new System.Drawing.Point(85, 9);
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
            this.panel1.Controls.Add(this.grpBotoes);
            this.panel1.Controls.Add(this.lblMensagem);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 204);
            this.panel1.TabIndex = 5;
            // 
            // grpBotoes
            // 
            this.grpBotoes.Controls.Add(this.btnYes);
            this.grpBotoes.Controls.Add(this.btnNo);
            this.grpBotoes.Location = new System.Drawing.Point(146, 100);
            this.grpBotoes.Name = "grpBotoes";
            this.grpBotoes.Size = new System.Drawing.Size(167, 80);
            this.grpBotoes.TabIndex = 5;
            this.grpBotoes.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-5, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 33);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirmação";
            // 
            // CMsgBox
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 252);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CMsgBox";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBotoes.ResumeLayout(false);
            this.grpBotoes.PerformLayout();
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
