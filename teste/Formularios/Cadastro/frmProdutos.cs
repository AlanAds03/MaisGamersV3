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

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmProdutos : Form
    {
        public Util.ModoTela modo_tela;
        public int idProduto;
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmCadJogo_Load(object sender, EventArgs e)
        {
            Util.CentralizaGrupo(grpBotoes);
            Util.CentralizaTab(tabControl1);

        }

        private void CarregaComboConsole(SuperComboBox combo)
        {
            try
            {
                bConsole _bConsole = new bConsole();

                List<mConsole> console = new List<mConsole>();

                console = _bConsole.CarregaConsole();
                combo.CarregaCombo(console, "idConsole", "NomeConsole", Frameworks.Componentes.SuperComboBox.PrimeiraLinha.Selecione);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CarregaComboTipoJogo(SuperComboBox combo, int value)
        {
            try
            {
                bTipoJogo _bTipo = new bTipoJogo();

                List<mTipoJogo> Tipo = new List<mTipoJogo>();

                Tipo = _bTipo.CarregaTipoJogo();
                combo.CarregaCombo(Tipo, "IDTipoJogo", "NomeTipoJogo", Frameworks.Componentes.SuperComboBox.PrimeiraLinha.Nenhum);
                combo.SelectedValue = value;

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

            pnlPreco.Visible = false;
            if (modo_tela == Util.ModoTela.CONSULTA)
            {
                tabControl1.SelectTab("tpPesquisa");
                btnFechar.Text = "Fechar";


            }
            else if (modo_tela == Util.ModoTela.ALTERACAO)
            {
                tabControl1.SelectTab("tpCadastro");
                btnFechar.Text = "Voltar";

                bProduto _bProduto = new bProduto();
                mProduto _mProduto = new mProduto();

                _mProduto = _bProduto.PesquisarProdutoID(idProduto);

                txtProduto.Text = _mProduto.Produto;
                txtQuantidade.Text = _mProduto.Quantidade.ToString();
                txtValorUnitario.Text = _mProduto.Unitario.ToString("0.00");
                txtCusto.Text = _mProduto.Custo.ToString("0.00");
                txtFornecedor.Text =  _mProduto.Fornecedor;

            }

            else if (modo_tela == Util.ModoTela.NOVO)
            {
                LimpaCampos();
                tabControl1.SelectTab("tpCadastro");
                btnFechar.Text = "Voltar";
                pnlPreco.Visible = true;

            }
        }

        private void LimpaCampos()
        {
            idProduto = 0;
            txtProduto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtValorUnitario.Text = string.Empty;
            txtCusto.Text = string.Empty;
            txtFornecedor.Text = string.Empty;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (modo_tela == Util.ModoTela.CONSULTA)
            {
                this.Close();
                this.Dispose();
            }
            else
            {
                modo_tela = Util.ModoTela.CONSULTA;
                atualizaTela();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {

                if (ValidarCampos() == false)
                {
                    return;
                }

                bProduto _bProduto = new bProduto();
                mProduto produto = new mProduto();

                produto.Produto = txtProduto.Text;
                produto.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                produto.Unitario = Convert.ToDouble(txtValorUnitario.Text);

                if (!string.IsNullOrEmpty(txtCusto.Text))
                {
                    produto.Custo = Convert.ToDouble(txtCusto.Text);
                }
                if (!string.IsNullOrEmpty(produto.Fornecedor))
                {
                    produto.Fornecedor = txtFornecedor.Text;

                }

               


                if (idProduto != 0)
                {
                    produto.IDProduto = idProduto;
                }
                

                if (_bProduto.InserirProduto(produto))
                {
                    if (idProduto != 0)
                    {
                        Mensagem("Produto alterado com sucesso", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Ok);
                    }
                    else
                    {
                        Mensagem("Produto inserido com sucesso", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Ok);
                    }

                    modo_tela = ModoTela.CONSULTA;
                    atualizaTela();
                }
                else
                {
                    Mensagem("Produto inserido com erro", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Erro);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private bool ValidarCampos()
        {

            bool retorno = true;

            if (string.IsNullOrEmpty(txtProduto.Text))
            {
                errorProvider1.SetError(txtProduto, "Informar o produto");
                retorno = false;
            }


            if (string.IsNullOrEmpty(txtQuantidade.Text))
            {
                errorProvider1.SetError(txtQuantidade, "Informar a quantidade");
                retorno = false;
            }


            if (string.IsNullOrEmpty(txtValorUnitario.Text))
            {
                errorProvider1.SetError(txtValorUnitario, "Informar o valor");
                retorno = false;
            }

            return retorno;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PesquisaGrid(txtPesqNome.Text);
        }


        private void PesquisaGrid(string NomeProduto)
        {


            bProduto _bProduto = new bProduto();
            mProduto _mProduto = new mProduto();
            List<mProduto> produtos = new List<mProduto>();
            string json = "";

            try
            {


                if (!string.IsNullOrEmpty(NomeProduto))
                {
                    _mProduto.Produto = NomeProduto;
                }

                

                lvPesquisa.CarregaListaView<mProduto>(_bProduto.PesquisaProduto(_mProduto, "Nome"));

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
                idProduto = Convert.ToInt32(lvPesquisa.ObterChave());

            }

            btnExcluir.Enabled = e.Item.Checked;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            modo_tela = Util.ModoTela.ALTERACAO;
            atualizaTela();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void txtPrecoPrimaria_Leave(object sender, EventArgs e)
        {
            double valor = 0;
        }

        private void txtPrecoSecundaria_Leave(object sender, EventArgs e)
        {
            double valor = 0;            
        }

        public void ControleCamposTipojogo()
        {

        }
        private void cmbTipoJogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControleCamposTipojogo();
        }
        private void cmbTipoJogo_SelectedValueChanged(object sender, EventArgs e)
        {
            ControleCamposTipojogo();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Mensagem("Deseja excluir este jogo ?", Frameworks.Classes.CMsgBox.TipoBotoes.SimNao, Frameworks.Classes.CMsgBox.TipoErro.Informacao) == DialogResult.Yes)
            {
                using (var bProduto = new bProduto())
                {
                    bProduto.ExcluirProduto(idProduto);
                }
            }

        }
        

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                if (pnlPreco.Visible == true)
                {
                    pnlPreco.Visible = false;
                }
                else
                {
                    pnlPreco.Visible = true;
                }
            }
           
        }

      
    }
}

