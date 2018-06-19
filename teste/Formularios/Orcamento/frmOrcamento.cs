using Frameworks.Componentes;
using MaisGamers.DLL.Orcamento;
using MaisGamers.Formularios.Cadastro;
using MaisGamers.Model.Orcamento;
using MaisGamers.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            pnlCadastro.AutoScroll = true;
            pnlCadastro.Height = tbControl.Height;
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
                btnFechar.Text = "Voltar";

                txtValor.Enabled = false;
                txtDataEntrega.ShowCheckBox = true;
                txtDataEntrega.Checked = false;
                txtGarantia.Enabled = false;
                //cmbTipoPagamento.Enabled = false;
                cmdStatus.SelectedValue = "1";
                cmdStatus.Enabled = false;
                btnTirarFoto.Enabled = false;
                btnVerFotos.Enabled = false;
                txtDataEntrada.Value = System.DateTime.Now;


            }
            else if (modo_tela == ModoTela.ALTERACAO)
            {
                tbControl.SelectTab("tpCadastro");
                tbControl.Refresh();
                LimpaCampos();

                bOrcamento _orcamento = new bOrcamento();
                mOrcamento _mOrcamento = new mOrcamento();

                _mOrcamento = _orcamento.Obter(idOrcamento);


                txtNome.Text = _mOrcamento.NomeCliente;
                txtProduto.Text = _mOrcamento.Produto;
                txtDefeito.Text = _mOrcamento.Defeito;
                txtObservacao.Text = _mOrcamento.Observacao;
                txtTelefone1.Text = _mOrcamento.Telefone1;
                txtTelefone2.Text = _mOrcamento.Telefone2;
                txtNumeroSerie.Text = _mOrcamento.NumeroSerie;
                txtValor.Text = _mOrcamento.ValorOrcamento.ToString();
                txtGarantia.Text = _mOrcamento.Garantia.ToString();
                txtDataEntrada.Value = Convert.ToDateTime(_mOrcamento.Data_Entrada);

                cmdStatus.SelectedValue = _mOrcamento.StatusOrcamento.IDStatusOrcamento;
                btnFechar.Text = "Voltar";



            }
            else if(modo_tela == ModoTela.CONSULTA)
            {
                tbControl.SelectTab("tpPesquisa");
                tbControl.Refresh();
                btnFechar.Text = "Fechar";
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


                mOrcamento orcamento = new mOrcamento();
                bOrcamento _b = new bOrcamento();

                //inserir novo orcamento 
                
                if (!ValidateChildren())
                {
                    return;
                }




                orcamento.NomeCliente = txtNome.Text;
                
                orcamento.Produto = txtProduto.Text;
                orcamento.Defeito = txtDefeito.Text;
                orcamento.Observacao = txtObservacao.Text;
                orcamento.Telefone1 = txtTelefone1.Text;
                orcamento.Telefone2 = txtTelefone2.Text;
                orcamento.Data_Entrada = txtDataEntrada.Value;
                orcamento.Data_Entrega = null;
                orcamento.Data_Retorno = null;
                orcamento.NumeroSerie = txtNumeroSerie.Text;
                if (!string.IsNullOrEmpty(txtValor.Text))
                {
                    orcamento.ValorOrcamento = Convert.ToDecimal(txtValor.Text);
                }

                if (!string.IsNullOrEmpty(txtGarantia.Text))
                {
                    orcamento.Garantia = Convert.ToInt32(txtGarantia.Text);
                }
                

                orcamento.IdStatusOrcamento = Convert.ToInt32(cmdStatus.ObterValor());

                if (idOrcamento > 0)
                {
                    orcamento.IDOrcamento = idOrcamento;
                }



                if (_b.Inserir(orcamento))
                {

                    if (idOrcamento == 0)
                        if (Mensagem(this, "Orçamento inserido com sucesso , deseja imprimir o comprovante ?", Frameworks.Classes.CMsgBox.TipoBotoes.SimNao, Frameworks.Classes.CMsgBox.TipoErro.Informacao) == DialogResult.Yes)
                        {
                            btnTirarFoto.Enabled = true;
                            btnVerFotos.Enabled = true;
                            GerarArquivo();
                            //imprimindo 
                        }
                        else
                        {
                            this.Close();
                        }
                    else
                    {
                        Mensagem(this, "Orçamento alterado com sucesso.", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Informacao);
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
            if(modo_tela == ModoTela.ALTERACAO)
            {
                modo_tela = ModoTela.CONSULTA;
                atualizaTela();
            }
            else
            {
                this.Close();
            }
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            PesquisarOrcamento();
        }

        public void PesquisarOrcamento()
        {

            List<dynamic> lista = new List<dynamic>();
            try
            {
                bOrcamento _orcamento = new bOrcamento();


                lista = _orcamento.PesquisarOrcamento(txtPesqNome.Text, txtProdutoPesq.Text, Convert.ToInt32(cmdStatusPesquisa.ObterValor()));

                if (lista != null)
                {
                    lvPesquisa.CarregaListaView<dynamic>(lista);
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void lvPesquisa_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked == true)
            {

                idOrcamento = Convert.ToInt32(lvPesquisa.ObterChave());
            }

            btnEditar.Enabled = e.Item.Checked;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modo_tela = ModoTela.ALTERACAO;
            atualizaTela();

        }

        private void btnTirarFoto_Click(object sender, EventArgs e)
        {
            
            bFotosOrcamento _bFotos = new bFotosOrcamento();
            mFotosOrcamento _mfoto = new mFotosOrcamento();
            int contador = 0;

            try
            {

                frmFoto _foto = new frmFoto();
                _foto.ShowDialog();

                if (_foto.fotos.Count  == 0)
                {
                    return;
                }

                foreach(Byte[] _byte in _foto.fotos)
                {
                    _mfoto = new mFotosOrcamento();
                    _mfoto.DataCriacao = System.DateTime.Now;
                    _mfoto.Foto = _byte;
                    _mfoto.IDOrcamento = new mOrcamento();
                    _mfoto.IDOrcamento.IDOrcamento = idOrcamento;

                    if (_bFotos.InserirFoto(_mfoto))
                    {
                        contador += 1;
                    }
                }

                if (contador > 0)
                {
                    Mensagem(this, "Foram incluidas " + contador.ToString() + " Fotos", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Ok);
                }
                else
                {
                    Mensagem(this, "Não Foram incluidas nenhuma imagem", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Ok);
                }

                


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                frmVisualizaFoto _visualiza = new frmVisualizaFoto();

                _visualiza.id = idOrcamento;
                _visualiza.ShowDialog();



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void imgPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarOrcamento();
        }

        private void imgPesquisar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            imgPesquisar.BackColor = Color.WhiteSmoke;
        }

        private void imgPesquisar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            imgPesquisar.BackColor = Color.Transparent;
        }

        private void btnComprovante_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Util.LogaErro("Gerando arquivo Orcamento");
                GerarArquivo();

            }
            catch (Exception ex)
            {
                Util.TratarErro(ex);
            }
        }

        private void GerarArquivo()
        {
            string caminhoArquivo = string.Empty;
            string nomeArquivo = string.Empty;


            try
            {
                caminhoArquivo = Path.Combine(Environment.GetEnvironmentVariable("TEMP"), "MAISGAMERS_ARQ");

                if (!Directory.Exists(caminhoArquivo))
                {
                    Directory.CreateDirectory(caminhoArquivo);
                }

                nomeArquivo = @"\" + System.DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

                if (File.Exists(caminhoArquivo + nomeArquivo))
                {
                    File.Delete(caminhoArquivo + nomeArquivo);
                }

                StreamWriter arquivo = new StreamWriter(caminhoArquivo + nomeArquivo);
                

                arquivo.WriteLine("---------------------------------------");
                arquivo.WriteLine("--------Locadora Mais Gamers-----------");
                arquivo.WriteLine("      CNPJ: 23.260.093/0001-87         ");
                arquivo.WriteLine("      Telefone: (11)4382 - 9388        ");
                arquivo.WriteLine("      Whatsapp: (11 94124-7585         ");
                arquivo.WriteLine("---------------------------------------");
                arquivo.WriteLine("------------Orcamento------------------");
                arquivo.WriteLine("---------------------------------------");
                arquivo.WriteLine("                                       ");
                if(txtNome.Text.Length > 35)
                {
                    arquivo.WriteLine("Cliente:" + txtNome.Text.Substring(0,35).ToString());
                }
                else
                {
                    arquivo.WriteLine("Cliente:" + txtNome.Text);
                }
                
                arquivo.WriteLine("Telefone:" + txtTelefone1.Text);
                arquivo.WriteLine("Telefone 2:" + txtTelefone2.Text);
                arquivo.WriteLine("Produto:" + txtProduto.Text);
                arquivo.WriteLine("Data Entrada: " + txtDataEntrada.Value.ToShortDateString());
                arquivo.WriteLine("S/N:" + txtNumeroSerie.Text);
                arquivo.WriteLine("Defeito:" + txtDefeito.Text);
                arquivo.WriteLine("Observacao:" + txtObservacao.Text);
                arquivo.WriteLine("Previsão Orcamento:" + txtDataEntrada.Value.AddDays(3).ToShortDateString());
                arquivo.WriteLine("----------------------------------");
                arquivo.WriteLine("");
                arquivo.WriteLine("");
                arquivo.WriteLine("Orcamentos aprovados e nao retirados em 90 dias,");
                arquivo.WriteLine("o mesmo sera vendido para pagamento do servico");
                arquivo.WriteLine("prestado");
                arquivo.WriteLine("                                  ");
                arquivo.WriteLine("                                  ");
                arquivo.WriteLine("                                  ");

                arquivo.WriteLine("__________________________________");
                arquivo.WriteLine("        " + txtNome.Text + "     ");


                arquivo.WriteLine("*****Obrigado e volte sempre*****");
                arquivo.Close();

                Util.Imprimir(caminhoArquivo + nomeArquivo);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lvPesquisa_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }
    }
}
