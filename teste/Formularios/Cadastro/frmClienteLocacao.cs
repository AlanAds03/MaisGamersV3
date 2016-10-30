using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaisGamers.Modulos;
using static MaisGamers.Modulos.util;
using MaisGamersV2.DAL.Locacao;
using MaisGamers.Model.Locacao;
using MaisGamers.Model;
using Frameworks.Componentes;
using MaisGamers.DLL;
using MaisGamers.DLL.Locacao;
using System.Web.Script.Serialization;

namespace MaisGamers.Formularios.Cadastro
{


    public partial class frmClienteLocacao : Form
    {

        public ModoTela modo_tela;



        public frmClienteLocacao()
        {
            InitializeComponent();
        }

        private void frmClienteLocacao_Load(object sender, EventArgs e)
        {

            util.CentralizaGrupo(grpBotoes);
            util.CentralizaTab(tbControl);

            CarregaComboEstado(cmbEstado);
            CarregaComboCidade(cmbCidade, Convert.ToInt16(cmbEstado.SelectedValue));

            modo_tela = ModoTela.CONSULTA;
            atualizaTela();

        }

        private void CarregaComboEstado(SuperComboBox cmbEstado)
        {

            List<mEstado> list = new List<mEstado>();

            try
            {
                bEstado _estado = new bEstado();

                list = _estado.CarregaEstado();


                cmbEstado.CarregaCombo(list, "cEstado", "rEstado", SuperComboBox.PrimeiraLinha.Selecione);

            }
            catch (Exception)
            {

                throw;
            }
        }



        private void CarregaComboCidade(SuperComboBox comboCidade, int cEstado)
        {
            List<mCidade> list = new List<mCidade>();

            try
            {
                bCidade _cidade = new bCidade();
                DataTable table = new DataTable();

                table.Columns.Add("cCidade");
                table.Columns.Add("rCidade");


                list = _cidade.CarregaCidade(cEstado);

                comboCidade.CarregaCombo(list, "cCidade", "rCidade", SuperComboBox.PrimeiraLinha.Selecione);


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PesquisaGrid(txtPesquisaNome.Text);
        }

        private void PesquisaGrid(string nome)
        {
            bClienteLocacao _bCli = new bClienteLocacao();
            mClienteLocacao cli = new mClienteLocacao();
            List<mClienteLocacao> locacao = new List<mClienteLocacao>();
            string json;

            cli.Nome = nome;
            json = _bCli.PesquisaCliente(cli);



            //lvPesquisa.CarregaListaView(locacao);
            lvPesquisa.CarregaListaView< mClienteLocacao>(json);
            


        }

        private void button4_Click(object sender, EventArgs e)
        {

            modo_tela = ModoTela.NOVO;
            atualizaTela();
        }

        private void atualizaTela()
        {

            if (modo_tela == ModoTela.CONSULTA)
            {
                tbControl.SelectTab("tpPesquisa");
                btnFechar.Text = "Fechar";
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;

            }
            else if (modo_tela == ModoTela.NOVO)
            {
                tbControl.SelectTab("tpDetalhe");
                btnFechar.Text = "Voltar";
                btnSalvar.Enabled = true;
                btnNovo.Enabled = false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            if (modo_tela == ModoTela.CONSULTA)
            {
                this.Close();
                this.Dispose();
            }
            else
            {
                modo_tela = ModoTela.CONSULTA;
                atualizaTela();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            mClienteLocacao _mClilocacao = new mClienteLocacao();
            bClienteLocacao _cliente = new bClienteLocacao();


            _mClilocacao.Nome = txtNome.Text;
            _mClilocacao.CPF = txtCpf.Text;
            _mClilocacao.RG = txtRG.Text;
            _mClilocacao.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
            _mClilocacao.Rua = txtRua.Text;
            _mClilocacao.Numero = txtNumero.Text;
            _mClilocacao.CEP = txtCEP.Text;
            _mClilocacao.Bairro = txtBairro.Text;
            _mClilocacao.cEstado = Convert.ToInt16(cmbEstado.SelectedValue);
            _mClilocacao.cCidade = Convert.ToInt16(cmbCidade.SelectedValue);


            _cliente.IncluirCliente(_mClilocacao);



        }

        private Boolean ValidarCampos()
        {


            return true;

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigo = 0;

            Int32.TryParse(cmbEstado.SelectedValue.ToString(),out codigo);
            if (codigo != 0)
            {
                CarregaComboCidade(cmbCidade, codigo);
            }
            
            
        }
    }
}
