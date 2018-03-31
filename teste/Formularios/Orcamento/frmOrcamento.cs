using Frameworks.Componentes;
using MaisGamers.DLL.Orcamento;
using MaisGamers.Model.Orcamento;
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
using static MaisGamers.Modulos.Util;

namespace MaisGamers.Formularios.Orcamento
{
    public partial class frmOrcamento : Form
    {
        public ModoTela modo_tela;
        public int idOrcamento;
        public frmOrcamento()
        {
            InitializeComponent();

            Util.CentralizaGrupo(grpBotoes);
            Util.CentralizaTab(tbControl);

            CarregaComboStatus();
        }

        private void CarregaComboStatus()
        {
            

                List<mStatusOrcamento> list = new List<mStatusOrcamento>();

                try
                {
                    bStatusOrcamento _bStatus = new bStatusOrcamento();

                    list = _bStatus.CarregaStatusOrcamento();


                    cmdStatusPesquisa.CarregaCombo(list, "IDStatusOrcamento", "StatusOrcamento", SuperComboBox.PrimeiraLinha.Selecione);
                    cmdStatus.CarregaCombo(list, "IDStatusOrcamento", "StatusOrcamento", SuperComboBox.PrimeiraLinha.Selecione);

            }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
            }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            modo_tela = ModoTela.NOVO;
            atualizaTela();
        }

        private void atualizaTela()
        {
            
            if (modo_tela == ModoTela.NOVO)
            {

                
                tbControl.SelectTab("tpCadastro");
                tbControl.Refresh();
                idOrcamento = 0;
                LimpaCampos();

                txtValor.Enabled = false;
                txtDataEntrega.ShowCheckBox = true;
                txtDataEntrega.Checked = false;
                txtGarantia.Enabled = false;
                cmbTipoPagamento.Enabled = false;
                cmdStatus.SelectedValue = "1";
                cmdStatus.Enabled = false;


            }
        }

        private void LimpaCampos()
        {
            txtNome.Text = string.Empty;
            cmdStatus.ResetarValores();
            txtProduto.Text = string.Empty;
            txtNumeroSerie.Text = string.Empty;
            txtDefeito.Text = string.Empty;
            txtObservacao.Text = string.Empty;
            txtTelefone1.Text = string.Empty;
            txtTelefone2.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtGarantia.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(idOrcamento == 0)
                {

                    mOrcamento orcamento = new mOrcamento();
                    bOrcamento _b = new bOrcamento();

                    //inserir novo orcamento 
                    if (!ValidateChildren()){
                        return;
                    }


                    

                    orcamento.NomeCliente = txtNome.Text;
                    orcamento.IdStatusOrcamento = Convert.ToInt32(cmdStatus.ObterValor());
                    orcamento.Produto = txtProduto.Text;
                    orcamento.Defeito = txtDefeito.Text;
                    orcamento.Observacao = txtObservacao.Text;
                    orcamento.Telefone1 = txtTelefone1.Text;
                    orcamento.Telefone2 = txtTelefone2.Text;
                    orcamento.Data_Entrada = txtDataEntrada.Value;
                    orcamento.Data_Entrega = null;
                    orcamento.Data_Retorno = null;

                    if (_b.Inserir(orcamento))
                    {
                        if (Mensagem(this,"Orçamento inserido com sucesso , deseja imprimir o comprovante ?", Frameworks.Classes.CMsgBox.TipoBotoes.SimNao, Frameworks.Classes.CMsgBox.TipoErro.Informacao) == DialogResult.Yes)
                        {
                            //imprimindo 
                        }
                        else
                        {
                            this.Close();
                        }

                        
                    }



                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
