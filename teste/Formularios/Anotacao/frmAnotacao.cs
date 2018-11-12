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
using MaisGamers.DLL.Anotacao;
using MaisGamers.Model.Anotacao;

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmAnotacao : Form
    {
        public Util.ModoTela modo_tela;
        public int idJogo;
        public frmAnotacao()
        {
            InitializeComponent();
        }

        private void frmCadJogo_Load(object sender, EventArgs e)
        {
            Util.CentralizaGrupo(grpBotoes);
            Util.CentralizaTab(tabControl1);

            CarregaComboConsole(cmbConsolePesquisa);
            CarregaComboConsole(cmbStatus);
            
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

        private void CarregaComboTipoJogo(SuperComboBox combo , int value)
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
            if (modo_tela == Util.ModoTela.CONSULTA)
            {
                tabControl1.SelectTab("tpPesquisa");
                btnFechar.Text = "Fechar";

                PesquisaGrid(txtPesqNome.Text, cmbConsolePesquisa.SelectedValue.ToString());


            }
            else if (modo_tela == Util.ModoTela.ALTERACAO)
            {
                tabControl1.SelectTab("tpCadastro");
                btnFechar.Text = "Voltar";

                bJogo _bJogo = new bJogo();
                mJogo _mJogo = new mJogo();

                _mJogo = _bJogo.PesquisaJogoID(idJogo);

                txtDescricao.Text = _mJogo.NomeJogo;
                cmbStatus.SelectedValue = _mJogo.IDConsole.IDConsole;
                

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
            idJogo = 0;
            txtDescricao.Text = string.Empty;
            
            cmbStatus.SelectedValue = "";
            

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

                bAnotacao _bAnotacao = new bAnotacao();
                mAnotacao anotacao = new mAnotacao();

                anotacao.Descricao = txtDescricao.Text;
                anotacao.DataAnotacao = DateTime.Now;
                anotacao.idStatusAnotacao = 1;

                if (_bAnotacao.Inserir(anotacao))
                {
                    Mensagem(this, "Registro inserido com sucesso", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Ok);
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

            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                errorProvider1.SetError(txtDescricao, "Informar o nome");
                retorno = false; 
            }



            return retorno;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PesquisaGrid(txtPesqNome.Text, cmbConsolePesquisa.SelectedValue.ToString());
        }


        private void PesquisaGrid(string Descricao, string Status)
        {


            bAnotacao _bAnotacao = new bAnotacao();
            mJogo jogo = new mJogo();
            List<mJogo> Jogos = new List<mJogo>();
            string json;

            try
            {
                
                

                    lvPesquisa.CarregaListaView<dynamic>(_bAnotacao.ObterGrid(Descricao));
                
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
                idJogo = Convert.ToInt32(lvPesquisa.ObterChave());

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
            double valor= 0;

            


               
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
            if (Mensagem(this, "Deseja excluir este jogo ?",Frameworks.Classes.CMsgBox.TipoBotoes.SimNao,Frameworks.Classes.CMsgBox.TipoErro.Informacao) == DialogResult.Yes)
            {
                using (var bJogo = new bJogo())
                {
                    bJogo.ExcluirJogo(idJogo);
                }
            }

        }

        private void txtPesqNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( (Keys)e.KeyChar == Keys.Enter)
            {
                PesquisaGrid(txtPesqNome.Text, cmbConsolePesquisa.SelectedValue.ToString());
            }
        }
    }
}

