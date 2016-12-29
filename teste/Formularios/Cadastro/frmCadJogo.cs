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

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmCadJogo : Form
    {
        public util.ModoTela modo_tela;

        public frmCadJogo()
        {
            InitializeComponent();
        }

        private void frmCadJogo_Load(object sender, EventArgs e)
        {
            util.CentralizaGrupo(grpBotoes);
            util.CentralizaTab(tabControl1);

            CarregaComboConsole(cmbConsolePesquisa);
            CarregaComboConsole(cmbConsole);
            CarregaComboTipoJogo(cmbTipoJogo);
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
            txtNome.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            cmbConsole.SelectedValue = "";
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

                jogo.NomeJogo = txtNome.Text;
                jogo.cIdConsole = Convert.ToInt32(cmbConsole.SelectedValue);
                jogo.cIDTipoJogo = Convert.ToInt32(cmbTipoJogo.SelectedValue);
                jogo.Email = txtEmail.Text;
                jogo.Senha = txtSenha.Text;
                if (!string.IsNullOrEmpty(txtQuantidade.Text))
                {
                    jogo.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                }
                
                jogo.PrecoPago = Convert.ToDouble(txtPrecoPago.Text);
                jogo.PrecoVenda = Convert.ToDouble(txtPrecoVenda.Text);
                if (_bJogo.InserirJogo(jogo))
                {
                    MessageBox.Show("Jogo inserido com sucesso");
                }
                else
                {
                    MessageBox.Show("Jogo inserido com erro");
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
    }
}
