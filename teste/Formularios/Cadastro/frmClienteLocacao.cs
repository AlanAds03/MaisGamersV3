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

                cmbEstado.DataSource = list;
                cmbEstado.ValueMember = "cEstado";
                cmbEstado.DisplayMember = "rEstado";



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CarregaComboCidade(SuperComboBox cmbEstado, int cEstado)
        {
            List<mCidade> list = new List<mCidade>();

            try
            {
                bCidade _estado = new bCidade();
                DataTable table = new DataTable();

                table.Columns.Add("cCidade");
                table.Columns.Add("rCidade");


                list = _estado.CarregaCidade(cEstado);


                cmbEstado.CarregaCombo(list, "cCidade", "rCidade", SuperComboBox.PrimeiraLinha.Selecione);


                int iContador = 0;

                foreach (var a in list)
                {
                    if (iContador == 0)
                    {
                        table.Rows.Add("0", "Selecione");
                    }

                    table.Rows.Add(a.cCidade, a.rCidade);


                    iContador += 1;
                }

                cmbEstado.DataSource = table;
                cmbEstado.ValueMember = "cCidade";
                cmbEstado.DisplayMember = "rCidade";


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            _mClilocacao.Estado.cEstado = Convert.ToInt16(cmbEstado.SelectedValue);
            _mClilocacao.Cidade.cCidade = Convert.ToInt16(cmbCidade.SelectedValue);


            _cliente.IncluirCliente(_mClilocacao);



        }

        private Boolean ValidarCampos()
        {


            return true;

        }
    }
}
