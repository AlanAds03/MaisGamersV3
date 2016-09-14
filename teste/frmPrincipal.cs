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
            pnlMenuCadastro.Visible = false;
            //pnlMenuCadastro.BackColor = Color.Fuchsia;
            //pnlContent.Width = Screen.PrimaryScreen.Bounds.Width;
            //pnlContent.Height = Screen.PrimaryScreen.Bounds.Height;
            CentralizaMenus();


            var db = new Contexto();

            db.Database.CreateIfNotExists();



        }

        private void posicionarBotoesFechar()
        {
            iconeFecharMenuCadastro.Left = 200;
        }

        private void CentralizaMenus()
        {
            pnlMenuCadastro.Top = 24;
            pnlMenuCadastro.Width = menuStrip1.Width;


        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMenuCadastro.Visible = true;
        }

        private void locacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMenuCadastro.Visible = false;
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
            pnlMenuCadastro.Visible = false;

        }

        enum tela
        {
            CadastroDeJogo = 1
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pnlMenuCadastro.Visible = false;
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            pnlMenuCadastro.Visible = false;
        }
    }
}
