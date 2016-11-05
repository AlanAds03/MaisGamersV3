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
using MaisGamers.Formularios;
using System.Runtime.InteropServices;
//using MaisGamers.Formularios.Locacao;

namespace MaisGamers.Formularios.Cadastro
{


    public partial class frmClienteLocacao : Form
    {

        public ModoTela modo_tela;

        public int idClienteLocacao;

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
            lvPesquisa.CarregaListaView<mClienteLocacao>(json);



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

                idClienteLocacao = 0;
            }

            else if (modo_tela == ModoTela.ALTERACAO)
            {
                tbControl.SelectTab("tpDetalhe");
                btnFechar.Text = "Voltar";
                btnSalvar.Enabled = true;
                btnNovo.Enabled = false;

                bClienteLocacao _bCli = new bClienteLocacao();
                mClienteLocacao cliente = new mClienteLocacao();
                cliente = _bCli.ObterCliente(idClienteLocacao);

                txtCodigo.Text = idClienteLocacao.ToString();
                txtNome.Text = cliente.Nome;
                txtCpf.Text = cliente.CPF;
                txtRG.Text = cliente.RG;
                txtDataNascimento.Text = Convert.ToString(cliente.DataNascimento);
                txtRua.Text = cliente.Rua;
                txtNumero.Text = cliente.Numero;
                txtCEP.Text = cliente.CEP;
                txtBairro.Text = cliente.Bairro;

                cmbEstado.SelectedValue = cliente.Estado.cEstado;

                int codigo = 0;

                Int32.TryParse(cmbEstado.SelectedValue.ToString(), out codigo);
                if (codigo != 0)
                {
                    CarregaComboCidade(cmbCidade, codigo);
                }

                cmbCidade.SelectedValue = cliente.Cidade.cCidade;




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

            if (idClienteLocacao != 0)
            {
                _mClilocacao.idClienteLocacao = idClienteLocacao;
            }

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


            if (_cliente.IncluirCliente(_mClilocacao) == true)
            {
                if(_mClilocacao.idClienteLocacao != 0)
                {
                   MessageBox.Show("Registro alteraco com sucesso");
                }
                else
                {
                    MessageBox.Show("Registro inclído com sucesso");
                }
               
            }
            else
            {
                MessageBox.Show("Erro ao incluir o registro");
            }
        }
        private Boolean ValidarCampos()
        {


            return true;

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigo = 0;

            Int32.TryParse(cmbEstado.SelectedValue.ToString(), out codigo);
            if (codigo != 0)
            {
                CarregaComboCidade(cmbCidade, codigo);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            modo_tela = ModoTela.ALTERACAO;
            atualizaTela();
        }

        private void lvPesquisa_ItemChecked(object sender, ItemCheckedEventArgs e)
        {


            if (e.Item.Checked == true)
            {
                idClienteLocacao = lvPesquisa.ObterChave();
            }

        }


        private void lvPesquisa_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (var i = 0; i <= lvPesquisa.Items.Count - 1; i++)
            {
                if (lvPesquisa.Items[i].Checked == true)
                {
                    if (i == e.Index)
                    {
                        continue;
                    }
                    lvPesquisa.Items[i].Checked = false;
                }

            }




        }

        private void grpCadastra_Enter(object sender, EventArgs e)
        {

        }

        private void grpBotoes_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //frmLocacaoJogo _locacao = new frmLocacaoJogo();
            //_locacao.MdiParent = this.MdiParent;
            //_locacao.Show();
            //MostraFormulario(frmCliente);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmFoto _foto = new frmFoto();

            _foto.ShowDialog();

        }

      

    }
}
