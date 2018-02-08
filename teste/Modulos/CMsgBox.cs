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
        private Label lblMensagem;
        private Panel panel1;
        private Panel panel2;
        private Label labelTitulo;
        private Button btnNo;
        private Button btnYes;
        private Button btnOK;
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
                btnOK.Visible = false;
                btnYes.Left = this.Bounds.Width / 2 - 100;
                btnNo.Left = this.Bounds.Width / 2;
            }
            else
            {
                btnYes.Visible = false;
                btnNo.Visible = false;
                btnOK.Visible = true;
                btnOK.Left = this.Bounds.Width / 2 - 40;
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
                labelTitulo.Text = "Confirmação";
            }
            else if (tipoErro == TipoErro.Informacao)
            {
                panel2.BackColor = Color.CadetBlue;
                labelTitulo.Text = "Informação";
            }
            else if (tipoErro == TipoErro.Erro)
            {
                panel2.BackColor = Color.Brown;
                labelTitulo.Text = "Erro";
            }

        }

        private void InitializeComponent()
        {
            this.lblMensagem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMensagem.Location = new System.Drawing.Point(3, 13);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(423, 32);
            this.lblMensagem.TabIndex = 4;
            this.lblMensagem.Text = "Registro inserido com sucesso";
            this.lblMensagem.Click += new System.EventHandler(this.lblMensagem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnNo);
            this.panel1.Controls.Add(this.btnYes);
            this.panel1.Controls.Add(this.lblMensagem);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 203);
            this.panel1.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(177, 153);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 47);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Location = new System.Drawing.Point(383, 153);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(97, 47);
            this.btnNo.TabIndex = 8;
            this.btnNo.Text = "NAO";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Location = new System.Drawing.Point(280, 153);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(97, 47);
            this.btnYes.TabIndex = 7;
            this.btnYes.Text = "SIM";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.labelTitulo);
            this.panel2.Location = new System.Drawing.Point(-5, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 45);
            this.panel2.TabIndex = 6;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitulo.Location = new System.Drawing.Point(17, 13);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(116, 24);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Confirmação";
            // 
            // CMsgBox
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 289);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CMsgBox";
            this.ShowIcon = false;
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

        private void btnYes_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            this.Close();
        }
    }
}
