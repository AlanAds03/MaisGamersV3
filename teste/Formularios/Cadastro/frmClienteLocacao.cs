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
using Frameworks.Classes;
using System.Net;
using MaisGamers.DAL.Cadastro;
//using MaisGamers.Formularios.Locacao;

namespace MaisGamers.Formularios.Cadastro
{


    public partial class frmClienteLocacao : Form
    {

        public ModoTela modo_tela;
        public bool habilitaTabPage = false;
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

            CarregaComboTipoCliente(cmbTipoCliente);


            modo_tela = ModoTela.CONSULTA;
            atualizaTela();

            //tbControl.TabPages[1].

            //tbControl.ac
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
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

                if (list != null) {
                    comboCidade.CarregaCombo(list, "cCidade", "rCidade", SuperComboBox.PrimeiraLinha.Selecione);
                }



            }
            catch (Exception ex)
            {

                throw;
            }
        }


        private void CarregaComboTipoCliente(SuperComboBox comboCidade)
        {
            List<mTipoCliente> list = new List<mTipoCliente>();

            try
            {
                bTipoCliente _tipo = new bTipoCliente();



                list = _tipo.CarregaTipoCliente();

                if (list != null)
                {
                    comboCidade.CarregaCombo(list, "IDTipoCliente", "TipoCliente", SuperComboBox.PrimeiraLinha.Selecione);
                }



            }
            catch (Exception ex)
            {

                throw;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void PesquisaGrid(int codigo,
                                  string nome,
                                  string cpf,
                                  string rg)
        {


            bClienteLocacao _bCli = new bClienteLocacao();
            mClienteLocacao cli = new mClienteLocacao();
            List<mClienteLocacao> locacao = new List<mClienteLocacao>();
            string json;

            try
            {
                cli.idClienteLocacao = codigo;

                if (!string.IsNullOrEmpty(rg))
                {
                    cli.RG = rg;
                }

                if (!string.IsNullOrEmpty(cpf))
                {
                    cli.CPF = cpf;
                }


                cli.Nome = nome;
                json = _bCli.PesquisaCliente(cli,"Nome");

                if (!string.IsNullOrEmpty(json))
                {
                    lvPesquisa.CarregaListaView<mClienteLocacao>(json);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }




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
                habilitaTabPage = false;

            }
            else if (modo_tela == ModoTela.NOVO)
            {
                habilitaTabPage = true;
                tbControl.SelectTab("tpDetalhe");
                btnFechar.Text = "Voltar";
                btnSalvar.Enabled = true;
                btnNovo.Enabled = false;
                pnlCodigo.Visible = false;
                idClienteLocacao = 0;
                LimpaCampos();

                
            }

            else if (modo_tela == ModoTela.ALTERACAO)
            {
                habilitaTabPage = true;
                tbControl.Enabled = true;
                tbControl.SelectTab("tpDetalhe");

                btnFechar.Text = "Voltar";
                btnSalvar.Enabled = true;
                btnNovo.Enabled = false;
                pnlCodigo.Visible = true;
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
                txtTelefone.Text = cliente.Telefone;
                cmbTipoCliente.SelectedValue = cliente.TipoCliente.IDTipoCliente;
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

        private void LimpaCampos()
        {
            idClienteLocacao = 0;
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtDataNascimento.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtBairro.Text = string.Empty;
            cmbEstado.SelectedValue = string.Empty;
            cmbCidade.SelectedValue = string.Empty;
            txtAutoriza.Text = string.Empty;
            txtCpfFilho.Text = string.Empty;
            txtRGFilho.Text = string.Empty;

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

            if (ValidarCampos() == false)
            {
                return;
            }
            if (idClienteLocacao != 0)
            {
                _mClilocacao.idClienteLocacao = idClienteLocacao;
            }

            _mClilocacao.Nome = txtNome.Text;
            _mClilocacao.CPF = txtCpf.Text;
            _mClilocacao.RG = txtRG.Text;
            if (util.isDate(txtDataNascimento.Text))
            {
                _mClilocacao.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);

            }
            else
            {
                MessageBox.Show("Informar a data de nascimento");
                txtDataNascimento.Text = string.Empty;
                return;
            }



            _mClilocacao.Rua = txtRua.Text;
            _mClilocacao.Numero = txtNumero.Text;
            _mClilocacao.CEP = txtCEP.Text;
            _mClilocacao.Bairro = txtBairro.Text;
            _mClilocacao.cEstado = Convert.ToInt16(cmbEstado.SelectedValue);
            _mClilocacao.cCidade = Convert.ToInt16(cmbCidade.SelectedValue);
            _mClilocacao.Telefone = txtTelefone.Text;
            _mClilocacao.IDTipoCliente = Convert.ToInt32(cmbTipoCliente.SelectedValue); 


            if (_cliente.IncluirCliente(_mClilocacao) == true)
            {
                if (idClienteLocacao == 0)
                {
                    MessageBox.Show("Registro incluído com sucesso");

                }
                else
                {
                    if (Mensagem("Registro alterado com sucesso", CMsgBox.TipoBotoes.OK) == DialogResult.Yes)
                    {

                    }
                }

            }
            else
            {
                MessageBox.Show("Erro ao incluir o registro");
            }

            modo_tela = ModoTela.CONSULTA;
            atualizaTela();
        }
        private Boolean ValidarCampos()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                errorProvider1.SetError(txtNome, "Informar o nome do cliente");
                retorno = false;
            }
            else
            {
                errorProvider1.SetError(txtNome, "");
            }
            

            if (string.IsNullOrEmpty(txtRG.Text))
            {
                errorProvider1.SetError(txtRG, "Informar o rg do cliente");
                retorno = false;
            }
            else
            {
                errorProvider1.SetError(txtRG, "");
            }


            if (string.IsNullOrEmpty(txtCpf.Text.Replace(".","").Replace("-","").Replace(",","").Trim()))
            {
                errorProvider1.SetError(txtCpf, "Informar o cpf do cliente");
                errorProvider1.SetError(txtCpf, "Informar o cpf do cliente");
                errorProvider1.SetError(txtCpf, "Informar o cpf do cliente");
                errorProvider1.SetError(txtCpf, "Informar o cpf do cliente");
                retorno = false;
            }
            else
            {
                errorProvider1.SetError(txtCpf, "");
            }



            return retorno;

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigo = 0;

            Int32.TryParse(Convert.ToString(cmbEstado.SelectedValue), out codigo);
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

            btnExcluir.Enabled = e.Item.Checked;


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

        private void button2_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }


        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (habilitaTabPage == false)
            {
                e.Cancel = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            

            if (Mensagem("Deseja realmente excluir este registro?",CMsgBox.TipoBotoes.SimNao) == DialogResult.Yes)
            {
                bClienteLocacao _cli = new bClienteLocacao();
                _cli.ExcluirCliente(idClienteLocacao);

            }
            int codigo = 0;

            if (!string.IsNullOrEmpty(txtPesquisaCodigo.Text))
            {
                codigo = Convert.ToInt32(txtPesquisaCodigo.Text);
            }

            PesquisaGrid(codigo, txtPesquisaNome.Text, txtPesquisarg.Text, txtPesquisaCPF.Text);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int codigo = 0;

            if (!string.IsNullOrEmpty(txtPesquisaCodigo.Text))
            {
                codigo = Convert.ToInt32(txtPesquisaCodigo.Text);
            }

            PesquisaGrid(codigo,
                         txtPesquisaNome.Text,
                         txtPesquisaCPF.Text,
                         txtPesquisarg.Text);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LimpaCamposFiltro();
        }

        private void LimpaCamposFiltro()
        {
            txtPesquisaCodigo.Text = "";
            txtPesquisaNome.Text = "";
            txtPesquisaCPF.Text = "";
            txtPesquisarg.Text = "";
            lvPesquisa.Clear();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (chkBusca.Checked)
            {
                EnderecoCEP _endereco = new EnderecoCEP();
                _endereco =  util.RetornoCEP(txtCEP.Text);

                if (_endereco != null)
                {
                    txtRua.Text = _endereco.logradouro;
                    txtBairro.Text = _endereco.bairro;

                    bEstado _estado = new bEstado();

                    _estado.ConsultaUF(_endereco.uf);
                    cmbEstado.SelectedValue = _estado.ConsultaUF(_endereco.uf);

                    CarregaComboCidade(cmbCidade,Convert.ToInt32(cmbEstado.SelectedValue));

                }
            }
            
        }

        
        
    }
}
