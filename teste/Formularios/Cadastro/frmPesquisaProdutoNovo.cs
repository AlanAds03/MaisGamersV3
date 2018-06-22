using MaisGamers.DLL.Cadastro;
using MaisGamers.Model.Cadastro;
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

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmPesquisaProdutoNovo : Form
    {
        public frmPesquisaProdutoNovo()
        {
            InitializeComponent();
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarProduto(txtPesquisar.Text);
        }

        private void PesquisarProduto(string produto)
        {
            bProduto _produto = new bProduto();
            mProduto _mProduto = new mProduto();
            List<mProduto> produtos = new List<mProduto>();

            try
            {
                _mProduto.Produto = produto;
                produtos = _produto.PesquisaProduto(_mProduto,"0");


                

                dataGridView1.DataSource = produtos.Select(x=> new { x.Produto,x.Quantidade ,x.Unitario}).ToList();
                dataGridView1.Columns[0].Width = 300;

            }
            catch (Exception ex)
            {

                Util.LogaErro("Erro em frmPesquisaProdutoNovo:" + ex.Message.ToString());
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            PesquisarProduto(txtPesquisar.Text);
        }

        private void frmPesquisaProdutoNovo_Load(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
        }
    }
}
