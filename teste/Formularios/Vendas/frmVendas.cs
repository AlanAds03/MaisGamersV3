using MaisGamers.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaisGamers.DLL;
using MaisGamers.Model.Cadastro;
using Frameworks.Componentes;
using MaisGamers.DLL.Cadastro;
using MaisGamers.DLL.Cadastro.Cadastro;
using static MaisGamers.Modulos.Util;
using MaisGamers.DLL.Locacao;
using MaisGamers.Model.Locacao;
using MaisGamers.Formularios.Locacao;
using System.IO;
using System.Diagnostics;
using System.Drawing.Printing;
using MaisGamers.DLL.Venda;
using MaisGamers.Model.Vendas;

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmVendas : Form
    {
        public int IDVenda;
        public int IDProduto;

        public frmVendas()
        {
            InitializeComponent();
        }

        //private void frmCadJogo_Load(object sender, EventArgs e)
        //{
        //    CarregaGrid();
        //    CarregaTotal();


        //}

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto thays = new frmPesquisaProduto();

            thays.idVenda = IDVenda;
            thays.ShowDialog();

            CarregaGrid();
            //CarregaTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPesquisaJogo jogo = new frmPesquisaJogo();

            jogo.ShowDialog();
        }

        public void CarregaGrid()
        {
            //bVenda _vendas = new bVenda();

            //lvLocacao.CarregaListaView<dynamic>(_vendas.CarregaGridVendas(IDVenda));

            //CarregaTotal();



        }

        //public void CarregaTotal()
        //{
        //    bVenda _vendas = new bVenda();
        //    txtTotal.Text = _vendas.TotalVenda(IDVenda).ToString("0.00");
        //}

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvLocacao_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            if (e.Item.Checked)
            {
                IDProduto = Convert.ToInt32(lvLocacao.ObterChave().ToString());
            }
            else
            {
                IDProduto = 0;
            }
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            lvLocacao.Controls.Add(new TextBox { Text = "asdasd" });
        }

        //private void btnExcluirJogo_Click(object sender, EventArgs e)
        //{
        //    bVenda _bVenda = new bVenda();

        //    _bVenda.ExcluirProdutoVenda(IDVenda, IDProduto);

        //    CarregaGrid();
        //}
    }
}

