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
using static MaisGamers.Modulos.util;
using MaisGamers.DLL.Locacao;
using MaisGamers.Model.Locacao;

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmLocacao : Form
    {
        public util.ModoTela modo_tela = ModoTela.CONSULTA;
        public int idClienteLocacao;
        public int idLocacao;

        public frmLocacao()
        {
            InitializeComponent();
        }

        private void frmCadJogo_Load(object sender, EventArgs e)
        {
            util.CentralizaGrupo(grpBotoes);
            util.CentralizaTab(tabControl1);

            CarregaComboConsole(cmbConsolePesquisa);

            if (modo_tela != ModoTela.CONSULTA)
            {
                atualizaTela();
            }
            
            
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
            modo_tela = util.ModoTela.NOVO;
            atualizaTela();
        }


        private void atualizaTela()
        {
            if (modo_tela == util.ModoTela.CONSULTA)
            {
                tabControl1.SelectTab("tpPesquisa");
                btnFechar.Text = "Fechar";

                PesquisaGrid(txtPesqNome.Text, cmbConsolePesquisa.SelectedValue.ToString());


            }
            else if (modo_tela == util.ModoTela.ALTERACAO)
            {
                tabControl1.SelectTab("tpLocacao");
                btnFechar.Text = "Voltar";

                bClienteLocacao _bclienteLocacao = new bClienteLocacao();
                mClienteLocacao _mClienteLocacao = new mClienteLocacao();


                _mClienteLocacao = _bclienteLocacao.PesquisaClienteID(idClienteLocacao);

                lblCliente.Text = _mClienteLocacao.Nome;
                lblRG.Text = _mClienteLocacao.RG;
                lblCPF.Text = _mClienteLocacao.CPF;

                PesquisaGrid(4);

            }

            else if (modo_tela == util.ModoTela.NOVO)
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
            if (modo_tela == util.ModoTela.CONSULTA)
            {
                this.Close();
                this.Dispose();
            }
            else
            {
                modo_tela = util.ModoTela.CONSULTA;
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

            

            PesquisaGrid(txtPesqNome.Text, cmbConsolePesquisa.SelectedValue.ToString());
        }


        private void PesquisaGrid(string NomeJogo, string Console)
        {


            bJogo _bJogo = new bJogo();
            mJogo jogo = new mJogo();
            List<mJogo> Jogos = new List<mJogo>();
            string json;

            try
            {
                

                if (!string.IsNullOrEmpty(NomeJogo))
                {
                    jogo.NomeJogo = NomeJogo;
                }

                if (!string.IsNullOrEmpty(Console))
                {
                    jogo.cIdConsole = Convert.ToInt32(Console);
                }

                    lvPesquisa.CarregaListaView<mJogo>(_bJogo.PesquisaJogo(jogo, "Nome"));
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }




        }

        private void cmbConsolePesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbConsolePesquisa.Carregado == true)
            {
                PesquisaGrid(txtPesqNome.Text, cmbConsolePesquisa.SelectedValue.ToString());
            }

        }

        private void lvPesquisa_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            if (e.Item.Checked == true)
            {


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



                lvLocacao.CarregaListaView<dynamic>(_bLocacao.PesquisaLocacao(idLocacao));

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            modo_tela = util.ModoTela.ALTERACAO;
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



                 //_pesquisJOgo.idJogo

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
