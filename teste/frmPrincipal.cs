using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaisGamers.Model;
using MaisGamers.Formularios.Cadastro;
using MaisGamers.Formularios.LocacaoHora;
using MaisGamers.Formularios.Orcamento;

namespace MaisGamers
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {

           
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CentralizaMenus();


            var db = new Contexto();

            db.Database.CreateIfNotExists();



        }

        private void posicionarBotoesFechar()
        {
            
        }

        private void CentralizaMenus()
        {

            if (Screen.PrimaryScreen.Bounds.Height < 800)
            {
                ribbon1.Height = 100;
            }
            else
            {
                ribbon1.Height = 150;
            }

            
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void locacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlMenuCadastro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cliquei");
        }

        private void pnlMenuLocacao_Paint(object sender, PaintEventArgs e)
        {

        }




        private void pnlIcone1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void pnlIcone1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;
            this.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmClienteLocacao frmCliente = new frmClienteLocacao();

            MostraFormulario(frmCliente);

        }


        private void MostraFormulario(Form _nameFormulario)
        {
            _nameFormulario.MdiParent = this;
            _nameFormulario.Width = Screen.PrimaryScreen.Bounds.Width;
            _nameFormulario.Height = Screen.PrimaryScreen.Bounds.Height - 24;
            _nameFormulario.Show();

        }

        enum tela
        {
            CadastroDeJogo = 1
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void rbCliente_Click(object sender, EventArgs e)
        {

            

        }

     

        private void Rblancahora_Click(object sender, EventArgs e)
        {
            frmlocacaohora frmhora = new frmlocacaohora();
            MostraFormulario(frmhora);
      
        }

        private void Rblocacaocliente_Click(object sender, EventArgs e)
        {
            frmClienteLocacao frmCliente = new frmClienteLocacao();
            MostraFormulario(frmCliente);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Rbmenuorcamento_ActiveChanged(object sender, EventArgs e)
        {
          
        }

        private void Rbmenuorcamento_TabBoundsChanged(object sender, EventArgs e)
        {
            frmClienteLocacao frmCliente = new frmClienteLocacao();
            MostraFormulario(frmCliente);
        }

        private void Rbcontroles_Click(object sender, EventArgs e)
        {

        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            frmCadJogo frmCadjogo = new frmCadJogo();
            MostraFormulario(frmCadjogo);
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            frmLocacao _frmLocacao = new frmLocacao();
            MostraFormulario(_frmLocacao);
        }
    }
}
