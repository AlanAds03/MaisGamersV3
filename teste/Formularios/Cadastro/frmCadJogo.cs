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
    public partial class frmCadJogo : Form
    {
        public Util.ModoTela modo_tela;
        public int idJogo;
        public frmCadJogo()
        {
            InitializeComponent();
        }

        private void frmCadJogo_Load(object sender, EventArgs e)
        {
            Util.CentralizaGrupo(grpBotoes);
            Util.CentralizaTab(tabControl1);

            CarregaComboConsole(cmbConsolePesquisa);
            CarregaComboConsole(cmbConsole);
            CarregaComboTipoJogo(cmbTipoJogo,1);
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

                PesquisaGrid(txtPesqNome.Text, cmbConsolePesquisa.SelectedValue.ToString(),chkFiltroLacrado.Checked);


            }
            else if (modo_tela == Util.ModoTela.ALTERACAO)
            {
                tabControl1.SelectTab("tpCadastro");
                btnFechar.Text = "Voltar";

                bJogo _bJogo = new bJogo();
                mJogo _mJogo = new mJogo();

                _mJogo = _bJogo.PesquisaJogoID(idJogo);

                txtNome.Text = _mJogo.NomeJogo;
                cmbConsole.SelectedValue = _mJogo.IDConsole.idConsole;
                cmbTipoJogo.SelectedValue = _mJogo.IDTipoJogo.IDTipoJogo;
                txtEmail.Text = _mJogo.Email;
                txtSenha.Text = _mJogo.Senha;
                txtSenhaPSN.Text = _mJogo.SenhaPSN;
                txtQuantidade.Text = Convert.ToString(_mJogo.Quantidade);
                txtPrecoPago.Text = _mJogo.PrecoPago.ToString("0.00");
                txtPrecoVenda.Text = _mJogo.PrecoVenda.ToString("0.00");
                chkLacrado.Checked = _mJogo.Lacrado;
                txtDataNascimentoConta.Text = _mJogo.DataNascimentoConta.ToString();
                txtDataVEndaPrimaria.Text = _mJogo.DataVendaPrimaria.ToString();
                txtDataVendaSecundaria.Text = _mJogo.DataVendaSecundaria.ToString();
                txtContaPai.Text = (string.IsNullOrEmpty(_mJogo.ContaPai) ? "" : _mJogo.ContaPai.ToString());
                txtPrimariaVendidoPara.Text = (string.IsNullOrEmpty(_mJogo.PrimariaVendidoPara) ? "" : _mJogo.PrimariaVendidoPara.ToString());
                txtSecundariaVendidoPara.Text = (string.IsNullOrEmpty(_mJogo.SecundariaVendidoPara) ? "" : _mJogo.SecundariaVendidoPara.ToString());

                txtPrecoPrimaria.Text = _mJogo.PrecoPrimaria.ToString("0.00");
                txtPrecoSecundaria.Text = _mJogo.PrecoSecundaria.ToString("0.00");


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
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            cmbConsole.SelectedValue = "";
            cmbTipoJogo.SelectedValue = "1";
            txtPrecoPago.Text = string.Empty;
            txtPrecoVenda.Text = string.Empty;
            txtPrecoPrimaria.Text = string.Empty;
            txtPrecoSecundaria.Text = string.Empty;
            txtSenhaPSN.Text = string.Empty;
            txtDataNascimentoConta.Text = string.Empty;
            txtDataVEndaPrimaria.Text = string.Empty;
            txtDataVendaSecundaria.Text = string.Empty;
            txtContaPai.Text = string.Empty;
            txtPrimariaVendidoPara.Text = string.Empty;
            txtSecundariaVendidoPara.Text = string.Empty;

            txtPrecoPrimaria.Text = string.Empty;
            txtPrecoSecundaria.Text = string.Empty;

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

                if (ValidarCampos() == false){
                    return;
                }

                bJogo _bJogo = new bJogo();
                mJogo jogo = new mJogo();

                jogo.NomeJogo = txtNome.Text;
                jogo.cIdConsole = Convert.ToInt32(cmbConsole.SelectedValue);
                jogo.cIDTipoJogo = Convert.ToInt32(cmbTipoJogo.SelectedValue);
                jogo.Email = txtEmail.Text;
                jogo.Senha = txtSenha.Text;
                jogo.SenhaPSN = txtSenhaPSN.Text;
                jogo.Lacrado = chkLacrado.Checked;

                jogo.DataNascimentoConta = (isDate(txtDataNascimentoConta.Text) ? Convert.ToDateTime(txtDataNascimentoConta.Text) : (DateTime?)null);
                jogo.ContaPai = txtContaPai.Text;
                jogo.PrimariaVendidoPara = txtPrimariaVendidoPara.Text;
                jogo.SecundariaVendidoPara = txtSecundariaVendidoPara.Text;
                jogo.DataVendaPrimaria = (isDate(txtDataVEndaPrimaria.Text) ?  Convert.ToDateTime(txtDataVEndaPrimaria.Text) : (DateTime?)null);
                jogo.DataVendaSecundaria = (isDate(txtDataVendaSecundaria.Text) ? Convert.ToDateTime(txtDataVendaSecundaria.Text) : (DateTime?)null);

                jogo.ValorVendaPrimaria = (Util.IsNumeric(txtValorVendaPrimaria.Text) ? Convert.ToDouble(txtValorVendaPrimaria.Text) : 0);
                jogo.ValorVendaSecundaria = (Util.IsNumeric(txtValorVendaSecundaria.Text) ? Convert.ToDouble(txtValorVendaSecundaria.Text) : 0);

            

                if (idJogo != 0)
                {
                    jogo.IDJogo = idJogo;
                }
                if (!string.IsNullOrEmpty(txtQuantidade.Text))
                {
                    jogo.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                }

                if (!string.IsNullOrEmpty(txtPrecoPago.Text))
                {
                    jogo.PrecoPago = Convert.ToDouble(txtPrecoPago.Text);
                }

                if (!string.IsNullOrEmpty(txtPrecoVenda.Text))
                {
                    jogo.PrecoVenda = Convert.ToDouble(txtPrecoVenda.Text);
                }

                if (!string.IsNullOrEmpty(txtPrecoPrimaria.Text))
                {
                    jogo.PrecoPrimaria = Convert.ToDouble(txtPrecoPrimaria.Text);
                }


                if (!string.IsNullOrEmpty(txtPrecoSecundaria.Text))
                {
                    jogo.PrecoSecundaria = Convert.ToDouble(txtPrecoSecundaria.Text);
                }


                if (_bJogo.InserirJogo(jogo))
                {
                    if(idJogo != 0)
                    {
                        Mensagem(this,"Jogo alterado com sucesso", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Ok);
                    }
                    else
                    {
                        Mensagem(this, "Jogo inserido com sucesso", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Ok);
                    }
                    
                    modo_tela = ModoTela.CONSULTA;
                    atualizaTela();
                }
                else
                {
                    Mensagem(this, "Jogo inserido com erro", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Erro);
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

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                errorProvider1.SetError(txtNome, "Informar o nome");
                retorno = false; 
            }



            return retorno;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PesquisaGrid(txtPesqNome.Text, cmbConsolePesquisa.SelectedValue.ToString(),chkFiltroLacrado.Checked);
        }


        private void PesquisaGrid(string NomeJogo, string Console, bool Lacrado)
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

                    lvPesquisa.CarregaListaView<mJogo>(_bJogo.PesquisaJogo(jogo, "Nome", Lacrado));
                
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
                PesquisaGrid(txtPesqNome.Text, cmbConsolePesquisa.SelectedValue.ToString(),chkFiltroLacrado.Checked);
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

            if (!string.IsNullOrEmpty(txtPrecoPrimaria.Text) && double.TryParse(txtPrecoPrimaria.Text,out valor))
            {
                valor = Convert.ToDouble(txtPrecoPrimaria.Text);
            }
            

            txtPrecoPrimaria.Text = valor.ToString("0.00"); 


               
        }

        private void txtPrecoSecundaria_Leave(object sender, EventArgs e)
        {
            double valor = 0;

            if (!string.IsNullOrEmpty(txtPrecoSecundaria.Text) && double.TryParse(txtPrecoSecundaria.Text, out valor))
            {
                valor = Convert.ToDouble(txtPrecoSecundaria.Text);
            }


            txtPrecoSecundaria.Text = valor.ToString("0.00");

        }

        public void ControleCamposTipojogo()
        {

            if (cmbTipoJogo.SelectedValue == null)
            {
                return;
            }


            if (cmbTipoJogo.SelectedValue.ToString() != "1")
            {
                pnlEmail.Visible = true;
                //lblPago.Visible = false;
                lblVenda.Visible = false;
                //txtPrecoPago.Visible = false;
                txtPrecoVenda.Visible = false;
            }
            else
            {
                pnlEmail.Visible = false;
                lblPago.Visible = true;
                lblVenda.Visible = true;
                txtPrecoPago.Visible = true;
                txtPrecoVenda.Visible = true;
            }

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
                PesquisaGrid(txtPesqNome.Text, cmbConsolePesquisa.SelectedValue.ToString(),chkFiltroLacrado.Checked);
            }
        }
    }
}

