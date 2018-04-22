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
using MaisGamers.DLL.Venda;
using MaisGamers.Formularios.Horas;
using MaisGamers.Modulos;

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
            try
            {

                Util.LogaErro("Inicializando Sistema Mais Gamers");
                Util.LogaErro("Centralizando os menus");
                CentralizaMenus();

                var db = new Contexto();

                db.Database.CreateIfNotExists();
                Timer time = new Timer();
                time.Interval = 1000;
                time.Tick += time_tick;
                time.Start();
            }
            catch (Exception ex)
            {
                Util.TratarErro(ex);
            }



        }

        private void time_tick(object sender, EventArgs e)
        {
            stripHora.Text = System.DateTime.Now.ToString();
            
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
           // _nameFormulario.Height = Screen.PrimaryScreen.Bounds.Height - 144;
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

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmClienteLocacao frmCliente = new frmClienteLocacao();
            MostraFormulario(frmCliente);

        }

        private void btnObjeto_Click(object sender, EventArgs e)
        {
            frmProdutos frmProdutos = new frmProdutos();
            MostraFormulario(frmProdutos);
        }

        private void BotaoMenuVendas_Click(object sender, EventArgs e)
        {
            frmVendas vendas = new frmVendas();
            bVenda _bVenda = new bVenda();

            DateTime data = System.DateTime.Now;

            vendas.IDVenda = _bVenda.InserirVenda(new Model.Vendas.mVenda { dVenda = data });
            //vendas.IDVenda = 12;


            MostraFormulario(vendas);

        }

        private void btnRelogio_Click(object sender, EventArgs e)
        {
            frmHoras horas = new frmHoras();
            MostraFormulario(horas);
        }

        private void rbOrcamento_Click(object sender, EventArgs e)
        {
            frmOrcamento orcamento = new frmOrcamento();
            MostraFormulario(orcamento);
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Util.LogaErro("Fechando sistema MaisGamers");
        }
    }
}
