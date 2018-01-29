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
using MaisGamers.DLL.Venda;
using MaisGamers.Model.Vendas;

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmPesquisaProduto : Form
    {
        public Util.ModoTela modo_tela;
        public int idProduto;
        public int idVenda;
        public frmPesquisaProduto()
        {
            InitializeComponent();
        }

       

        

        private void CarregaComboTipoJogo(SuperComboBox combo)
        {
            try
            {
                bTipoJogo _bTipo = new bTipoJogo();

                List<mTipoJogo> Tipo = new List<mTipoJogo>();

                Tipo = _bTipo.CarregaTipoJogo();
                combo.CarregaCombo(Tipo, "IDTipoJogo", "NomeTipoJogo", Frameworks.Componentes.SuperComboBox.PrimeiraLinha.Selecione);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            modo_tela = Util.ModoTela.NOVO;
            atualizaTela();
        }


        private void atualizaTela()
        {
            if (modo_tela == Util.ModoTela.CONSULTA)
            {
                tabControl1.SelectTab("tpPesquisa");
                btnFechar.Text = "Fechar";

                PesquisaGrid(txtPesqNome.Text);


            }
           

        }

       

        private void btnFechar_Click(object sender, EventArgs e)
        {
                this.Close();
                this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                bVenda _bVenda = new bVenda();
                mVenda _mVenda = new mVenda();
                mProduto _produto = new mProduto();
                

                if(idProduto != 0)
                {
                    _mVenda.IDVenda = idVenda;
                    _produto.IDProduto = idProduto;

                    _bVenda.InserirVendaProduto(_mVenda, _produto);
                    
                }

                this.Close();
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            

            PesquisaGrid(txtPesqNome.Text);
        }


        private void PesquisaGrid(string NomeProduto)
        {


            bProduto _bProduto = new bProduto();
            mProduto produto = new mProduto();
            List<mProduto> Produtos = new List<mProduto>();
            string json;

            try
            {
                

                if (!string.IsNullOrEmpty(NomeProduto))
                {
                    produto.Produto = NomeProduto;
                }

                

                    lvPesquisa.CarregaListaView<mProduto>(_bProduto.PesquisaProduto(produto, "Nome"));
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }




        }

      

        private void lvPesquisa_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            if (e.Item.Checked == true)
            {
                idProduto = lvPesquisa.ObterChave();

            }

            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            modo_tela = Util.ModoTela.ALTERACAO;
            atualizaTela();
        }
    
    }
}
