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

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmLocacao : Form
    {
        public Util.ModoTela modo_tela = ModoTela.CONSULTA;
        public int idClienteLocacao;
        public int idLocacao;

        public frmLocacao()
        {
            InitializeComponent();
        }

        private void frmCadJogo_Load(object sender, EventArgs e)
        {
            Util.CentralizaGrupo(grpBotoes);
            Util.CentralizaTab(tabControl1);

            CarregaComboStatus(cmbStatus);

            if (modo_tela != ModoTela.CONSULTA)
            {
                atualizaTela();
            }


        }

        private void CarregaComboStatus(SuperComboBox combo)
        {
            try
            {
                bStatusLocacao _bStatus = new bStatusLocacao();
                List<mStatusLocacao> status = new List<mStatusLocacao>();

                status = _bStatus.CarregaStatusLocacao();
                combo.CarregaCombo(status, "IDStatus", "Status", Frameworks.Componentes.SuperComboBox.PrimeiraLinha.Selecione);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
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

                PesquisaGrid(txtPesqNome.Text, Convert.ToInt32(cmbStatus.SelectedValue.ToString()));


            }
            else if (modo_tela == Util.ModoTela.ALTERACAO)
            {
                tabControl1.SelectTab("tpLocacao");
                btnFechar.Text = "Voltar";

                bClienteLocacao _bclienteLocacao = new bClienteLocacao();
                mClienteLocacao _mClienteLocacao = new mClienteLocacao();


                //_mClienteLocacao = _bclienteLocacao.PesquisaClienteID(idClienteLocacao);

                //lblCliente.Text = _mClienteLocacao.Nome;
                //lblRG.Text = _mClienteLocacao.RG;
                //lblCPF.Text = _mClienteLocacao.CPF;

                PesquisaGrid(idLocacao);

            }

            else if (modo_tela == Util.ModoTela.NOVO)
            {
                LimpaCampos();
                tabControl1.SelectTab("tpCadastro");
                btnFechar.Text = "Voltar";

            }
        }

        private void LimpaCampos()
        {


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
                bJogo _bJogo = new bJogo();
                mJogo jogo = new mJogo();







                if (_bJogo.InserirJogo(jogo))
                {

                    modo_tela = ModoTela.CONSULTA;
                    atualizaTela();
                }
                else
                {
                    Mensagem("Jogo inserido com erro", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Erro);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {



            PesquisaGrid(txtPesqNome.Text, Convert.ToInt32(cmbStatus.SelectedValue.ToString()));
        }


        private void PesquisaGrid(string NomeCliente, int Status)
        {


            bLocacao _bLocacao = new bLocacao();
            mLocacao _mLocacao = new mLocacao();

            try
            {

                lvPesquisa.CarregaListaView<dynamic>(_bLocacao.PesquisaLocacao(NomeCliente, Status));

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }




        }

        private void cmbConsolePesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Carregado == true)
            {
                PesquisaGrid(txtPesqNome.Text, Convert.ToInt32(cmbStatus.SelectedValue.ToString()));
            }

        }

        private void lvPesquisa_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            if (e.Item.Checked == true)
            {

                idLocacao = lvPesquisa.ObterChave();
            }

            btnExcluir.Enabled = e.Item.Checked;


        }


        private void PesquisaGrid(int idLocacao)
        {
            bLocacao _bLocacao = new bLocacao();

            List<bLocacao> Jogos = new List<bLocacao>();
            string json;

            try
            {



                lvLocacao.CarregaListaView<dynamic>(_bLocacao.PesquisaLocacaoID(idLocacao));

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            modo_tela = Util.ModoTela.ALTERACAO;
            atualizaTela();
        }

        private void btnJogo_Click(object sender, EventArgs e)
        {
            try
            {
                frmPesquisaJogo _pesquisJOgo = new frmPesquisaJogo();
                _pesquisJOgo.ShowDialog();

                bLocacao _bLocacao = new bLocacao();
                mLocacao _mLocacao = new mLocacao();

                if (idLocacao == 0)
                {
                    _mLocacao.idClienteLocacao = idClienteLocacao;
                    _mLocacao.idStatusLocacao = 1;
                    idLocacao = _bLocacao.InserirLocacao(_mLocacao);
                }

                bLocacaoJogo _bLocacaoJogo = new bLocacaoJogo();
                mLocacaoJogos _mLocacaoJogo = new mLocacaoJogos();

                _mLocacaoJogo.idJogo = _pesquisJOgo.idJogo;
                _mLocacaoJogo.idLocacao = idLocacao;

                _bLocacaoJogo.InserirLocacaoJogo(_mLocacaoJogo);

                PesquisaGrid(idLocacao);

                //_pesquisJOgo.idJogo

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {


            try
            {
                DateTime dataEntrega = new DateTime(txtDataEntrega.Value.Year, txtDataEntrega.Value.Month, txtDataEntrega.Value.Day);


                bLocacao _bLocacao = new bLocacao();

                _bLocacao.PrevisaoPreco(idLocacao, dataEntrega,true);


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
