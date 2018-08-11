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
using MaisGamers.DLL.Locacao;
using MaisGamers.Model.Locacao;
using MaisGamers.Formularios.Locacao;
using System.IO;
using System.Diagnostics;
using System.Drawing.Printing;
using Frameworks.Modulos;

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmLocacao : Form
    {
        public Util.ModoTela modo_tela = ModoTela.CONSULTA;
        public int idClienteLocacao;
        public int idLocacao;
        public int StatusLocação;
        public decimal idLocacaoJogo;
        public double ValorDevido;

        public frmLocacao()
        {
            InitializeComponent();
        }

        private void frmCadJogo_Load(object sender, EventArgs e)
        {


            Util.CentralizaGrupo(grpBotoes2);
            Util.CentralizaTab(tabControl1);

            picExcluir.Enabled = false;

            CarregaComboStatus(cmbStatus);

            if (modo_tela != ModoTela.CONSULTA)
            {
                atualizaTela();
            }


        }

        private void CarregaComboStatus(SuperComboBox combo)
        {
            try
            {
                bStatusLocacao _bStatus = new bStatusLocacao();
                List<mStatusLocacao> status = new List<mStatusLocacao>();

                status = _bStatus.CarregaStatusLocacao();
                combo.CarregaCombo(status, "IDStatus", "Status", Frameworks.Componentes.SuperComboBox.PrimeiraLinha.Selecione);

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
            modo_tela = Util.ModoTela.NOVO;
            atualizaTela();
        }


        private void atualizaTela()
        {

            bClienteLocacao _bclienteLocacao = new bClienteLocacao();
            mClienteLocacao _mClienteLocacao = new mClienteLocacao();
            bLocacao _blocacao = new bLocacao();
            mLocacao _mlocacao = new mLocacao();

            if (modo_tela == Util.ModoTela.CONSULTA)
            {
                tabControl1.SelectTab("tpPesquisa");
                PesquisaGrid(txtPesqNome.Text, Convert.ToInt32(cmbStatus.SelectedValue.ToString()));
            }
            else if (modo_tela == Util.ModoTela.ALTERACAO)
            {
                tabControl1.SelectTab("tpLocacao");

                _mClienteLocacao = _bclienteLocacao.BuscarClienteLocacao(idLocacao);

                lblCliente.Text = _mClienteLocacao.Nome;
                lblRG.Text = _mClienteLocacao.RG;
                lblCPF.Text = _mClienteLocacao.CPF;
                lblDataCadastro.Text = _mClienteLocacao.DataCadastrado.ToShortDateString().ToString();


                if (string.IsNullOrEmpty(_mClienteLocacao.NomeFilho))
                {
                    chkAutorizado.Visible = false;
                }
                else
                {
                    chkAutorizado.Text = _mClienteLocacao.NomeFilho;
                    chkAutorizado.Visible = true;
                }

                _mlocacao = _blocacao.Obter(idLocacao);

                if (_mlocacao != null)
                {
                    lblStatus.Text = _mlocacao.StatusLocacao.Status;
                    StatusLocação = _mlocacao.StatusLocacao.IDStatus;
                }

                btnImprimir.Enabled = _mlocacao.StatusLocacao.IDStatus != 1;


                if (_mlocacao.StatusLocacao.IDStatus == 1)
                {
                    btnJogo.Enabled = true;
                    btnExcluirJogo.Enabled = true;
                    btnEntregarCliente.Enabled = true;


                }
                else
                {
                    btnJogo.Enabled = false;
                    btnExcluirJogo.Enabled = false;
                    btnEntregarCliente.Enabled = false;
                }


                if (_mlocacao.StatusLocacao.IDStatus != 1)
                {
                    btnJogo.Enabled = false;
                    if (_mlocacao.DataPrevisaoEntrega != null)
                    {
                        txtDataEntrega.Value = Convert.ToDateTime(_mlocacao.DataPrevisaoEntrega);
                    }

                    txtDataEntrega.Enabled = false;


                }

                PesquisaGrid(idLocacao);

            }

            //else if (modo_tela == Util.ModoTela.NOVO)
            //{
            //    LimpaCampos();
            //    tabControl1.SelectTab("tpCadastro");
            //    btnFechar.Text = "Voltar";

            //}
        }

        private void LimpaCampos()
        {


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
                bJogo _bJogo = new bJogo();
                mJogo jogo = new mJogo();







                if (_bJogo.InserirJogo(jogo))
                {

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

        private void button4_Click(object sender, EventArgs e)
        {



            PesquisaGrid(txtPesqNome.Text, Convert.ToInt32(cmbStatus.SelectedValue.ToString()));
        }


        private void PesquisaGrid(string NomeCliente, int Status)
        {


            bLocacao _bLocacao = new bLocacao();
            mLocacao _mLocacao = new mLocacao();

            try
            {

                lvPesquisa.CarregaListaView<dynamic>(_bLocacao.PesquisaLocacao(NomeCliente, Status));

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }




        }

        private void cmbConsolePesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Carregado == true)
            {
                PesquisaGrid(txtPesqNome.Text, Convert.ToInt32(cmbStatus.SelectedValue.ToString()));
            }

        }

        private void lvPesquisa_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            if (e.Item.Checked == true)
            {

                idLocacao = Convert.ToInt32(lvPesquisa.ObterChave());
            }

            picExcluir.Enabled = e.Item.Checked;


        }


        private void PesquisaGrid(int idLocacao)
        {
            bLocacao _bLocacao = new bLocacao();

            List<bLocacao> Jogos = new List<bLocacao>();
            string json;

            try
            {

                lvLocacao.CarregaListaView<dynamic>(_bLocacao.PesquisaLocacaoID(idLocacao));

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            modo_tela = Util.ModoTela.ALTERACAO;
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

                PesquisaGrid(idLocacao);

                //_pesquisJOgo.idJogo

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {


            try
            {
                DateTime dataEntrega = new DateTime(txtDataEntrega.Value.Year, txtDataEntrega.Value.Month, txtDataEntrega.Value.Day);


                bLocacao _bLocacao = new bLocacao();

                lblTotal.Text = _bLocacao.PrevisaoPreco(idLocacao, MinHoraData(DateTime.Now), MinHoraData(dataEntrega), true).ToString();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnExcluirJogo_Click(object sender, EventArgs e)
        {
            try
            {

                bLocacaoJogo _bJogo = new bLocacaoJogo();

                if (idLocacaoJogo > 0)
                {
                    _bJogo.ExcluirJogo(idLocacaoJogo);
                }

                modo_tela = ModoTela.ALTERACAO;
                atualizaTela();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lvLocacao_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                idLocacaoJogo = Convert.ToInt32(lvLocacao.ObterChave());
            }

            catch (Exception)
            {

                throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                frmPopupFehamento fechamento = new frmPopupFehamento();

                bLocacao _locacao = new bLocacao();
                mLocacao _mloc = new mLocacao();
                _mloc = _locacao.Obter(idLocacao);

                fechamento.idLocacao = idLocacao;
                fechamento.DataLocacao = _mloc.DataLocacao;
                fechamento.DataPrevisao = _mloc.DataPrevisaoEntrega;
                fechamento.DataEntrega = DateTime.Now;


                fechamento.ValorDevido = Convert.ToDouble(_locacao.PrevisaoPreco(idLocacao, MinHoraData(fechamento.DataLocacao), MinHoraData(DateTime.Now), true).ToString());
                fechamento.ValorPagoLocacao = _mloc.ValorPagoInicial;
                fechamento.ValorRestante = fechamento.ValorDevido - fechamento.ValorPagoLocacao;




                fechamento.ShowDialog();


                if (fechamento.acao == "Concluir")
                {

                    //Imprimir nota de impressao e concluir
                    _locacao.FinalizarLocacao(idLocacao, fechamento.DataEntrega, fechamento.ValorDevido);
                }

                modo_tela = ModoTela.CONSULTA;
                atualizaTela();


            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                frmEntrega _entrega = new frmEntrega();



                DateTime dataEntrega = new DateTime(txtDataEntrega.Value.Year, txtDataEntrega.Value.Month, txtDataEntrega.Value.Day);

                if (dataEntrega.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    MessageBox.Show("Não pode alugar para o mesmo dia");
                    return;
                }


                bLocacao _bLocacao = new bLocacao();



                _entrega.DataEntrega = txtDataEntrega.Value;
                _entrega.ValorDevido = _bLocacao.PrevisaoPreco(idLocacao, MinHoraData(DateTime.Now), MinHoraData(dataEntrega), true).ToString();

                _entrega.ShowDialog();

                if (_entrega.acao == "Concluir")
                {
                    _bLocacao.AtualizarDataPrevistaLocacao(idLocacao, _entrega.DataEntrega, _entrega.ValorPago);
                }

                modo_tela = ModoTela.ALTERACAO;
                atualizaTela();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtDataEntrega_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime dataEntrega = new DateTime(txtDataEntrega.Value.Year, txtDataEntrega.Value.Month, txtDataEntrega.Value.Day);


                bLocacao _bLocacao = new bLocacao();

                lblTotal.Text = _bLocacao.PrevisaoPreco(idLocacao, MinHoraData(DateTime.Now), MinHoraData(dataEntrega), true).ToString();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            List<mImpressao> linhas = new List<mImpressao>();
            bLocacao _locacao = new bLocacao();
            mLocacao _mloc = new mLocacao();
            bool bDigital = false;


            try
            {

                _mloc = _locacao.Obter(idLocacao);

                List<mLocacaoJogos> Jogos = new List<mLocacaoJogos>();

                Jogos = _locacao.ObterJogos(idLocacao);

                FontFamily FAMI = new FontFamily("Arial");
                Font font = new Font(FAMI, 16.0f);
                linhas.Add(new mImpressao { linha = "Locadora Mais Gamers", Fonte = new Font(FAMI, 12.0F, FontStyle.Bold), brush = new SolidBrush(Color.Black) });
                //linhas.Add(new mImpressao { linha = "CNPJ: 23.260.093/0001-87", Fonte = new Font(FAMI, 12.0F), brush = new SolidBrush(Color.Black) });
                linhas.Add(new mImpressao { linha = "                   ", Fonte = new Font(FAMI, 12.0F), brush = new SolidBrush(Color.Black) });
                linhas.Add(new mImpressao { linha = "Telefone: 11 4382-9388", Fonte = new Font(FAMI, 10.0F), brush = new SolidBrush(Color.Black) });
                linhas.Add(new mImpressao { linha = "Whatsapp: 11 94124-7585", Fonte = new Font(FAMI, 10.0F), brush = new SolidBrush(Color.Black) });
                linhas.Add(new mImpressao { linha = "                   ", Fonte = new Font(FAMI, 12.0F), brush = new SolidBrush(Color.Black) });
                linhas.Add(new mImpressao { linha = "Comprovante de Locação", Fonte = new Font(FAMI, 10.0F, FontStyle.Bold), brush = new SolidBrush(Color.Black) });
                linhas.Add(new mImpressao { linha = "                   ", Fonte = new Font(FAMI, 12.0F), brush = new SolidBrush(Color.Black) });

                if (chkAutorizado.Checked)
                {
                    linhas.Add(new mImpressao { linha = "Autorizado : ", Fonte = new Font(FAMI, 8.0F, FontStyle.Bold), brush = new SolidBrush(Color.Black) });
                    linhas.Add(new mImpressao { linha = _mloc.IDClienteLocacao.NomeFilho, Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });
                    linhas.Add(new mImpressao { linha = "Responsável : ", Fonte = new Font(FAMI, 8.0F, FontStyle.Bold), brush = new SolidBrush(Color.Black) });
                    linhas.Add(new mImpressao { linha = _mloc.IDClienteLocacao.Nome, Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });
                }
                else
                {
                    linhas.Add(new mImpressao { linha = "Cliente : ", Fonte = new Font(FAMI, 8.0F, FontStyle.Bold), brush = new SolidBrush(Color.Black) });
                    linhas.Add(new mImpressao { linha = _mloc.IDClienteLocacao.Nome, Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });
                }
                


                if (StatusLocação == 2)
                {
                    linhas.Add(new mImpressao { linha = "Data locação:" + _mloc.DataLocacao.ToString(), Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });
                    linhas.Add(new mImpressao { linha = "Expira em:" + _mloc.DataPrevisaoEntrega.ToString(), Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });
                }
                else
                {
                    linhas.Add(new mImpressao { linha = "Data de entrega : ", Fonte = new Font(FAMI, 8), brush = new SolidBrush(Color.Black) });
                    linhas.Add(new mImpressao { linha = _mloc.DataLocacaoEntrega.ToString(), Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });
                }

                foreach (mLocacaoJogos _jogo in Jogos)
                {
                    linhas.Add(new mImpressao { linha = "Jogo : " + _jogo.IDJogo.NomeJogo, Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });
                    linhas.Add(new mImpressao { linha = "Console : " + _jogo.IDJogo.IDConsole.NomeConsole, Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });

                    if (StatusLocação == 2)
                    {
                        if (_jogo.IDJogo.IDTipoJogo.NomeTipoJogo == "Digital")
                        {
                            bDigital = true;
                            linhas.Add(new mImpressao { linha = "Email : ", Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });
                            linhas.Add(new mImpressao { linha = _jogo.IDJogo.Email, Fonte = new Font(FAMI, 8.0F, FontStyle.Underline), brush = new SolidBrush(Color.Black) });
                            linhas.Add(new mImpressao { linha = "Senha : " + _jogo.IDJogo.SenhaPSN, Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });
                        }
                    }
                }


                if (StatusLocação == 2)
                {
                    linhas.Add(new mImpressao { linha = "Valor a pagar : R$ " + _locacao.PrevisaoPreco(idLocacao, MinHoraData(_mloc.DataLocacao), MinHoraData(_mloc.DataPrevisaoEntrega), true), Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });
                    linhas.Add(new mImpressao { linha = "Valor pago : R$ " + _mloc.ValorPagoInicial.ToString("0.00"), Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });
                }
                else
                {
                    linhas.Add(new mImpressao { linha = "Valor pago na locação : R$ " + _mloc.ValorPagoInicial.ToString("0.00"), Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });
                    linhas.Add(new mImpressao { linha = "Valor total : R$ " + _mloc.ValorPagoFinal.ToString("0.00"), Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });
                }


                if (StatusLocação == 2)
                {
                    if (bDigital == false)
                    {
                        if (chkAutorizado.Checked)
                        {
                            linhas.Add(new mImpressao { linha = "______________________________", Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });
                            linhas.Add(new mImpressao { linha = "(" + _mloc.IDClienteLocacao.NomeFilho + ")", Fonte = new Font(FAMI, 8.0F, FontStyle.Bold), brush = new SolidBrush(Color.Black) });
                        }
                        else
                        {
                            linhas.Add(new mImpressao { linha = "______________________________", Fonte = new Font(FAMI, 8.0F), brush = new SolidBrush(Color.Black) });
                            linhas.Add(new mImpressao { linha = "(" + _mloc.IDClienteLocacao.Nome + ")", Fonte = new Font(FAMI, 8.0F, FontStyle.Bold), brush = new SolidBrush(Color.Black) });
                        }

                        
                    }

                }
                else
                {
                    linhas.Add(new mImpressao { linha = "(" + _mloc.IDClienteLocacao.Nome + ")", Fonte = new Font(FAMI, 8.0F, FontStyle.Bold), brush = new SolidBrush(Color.Black) });
                    linhas.Add(new mImpressao { linha = "**********DEVOLUCAO**********", Fonte = new Font(FAMI, 8.0F, FontStyle.Bold), brush = new SolidBrush(Color.Black) });
                }




                ImpressaoTermica termica = new ImpressaoTermica(linhas);
                termica.Imprimir();


                //texto.WriteLine("                                  ");
                //texto.WriteLine("Cliente : " + _mloc.IDClienteLocacao.Nome);
                //texto.WriteLine("Data Locacao : " + _mloc.DataLocacao);

                //if (StatusLocação == 2)
                //{
                //    texto.WriteLine("Data Previsao : " + _mloc.DataPrevisaoEntrega);
                //}
                //else
                //{
                //    texto.WriteLine("Data de entrega : " + _mloc.DataLocacaoEntrega);
                //}



                //texto.WriteLine("Valor pago na locacao : " + _mloc.ValorPagoInicial.ToString("0.00"));

                //if (StatusLocação == 2)
                //{
                //    texto.WriteLine("Valor a pagar : " + _locacao.PrevisaoPreco(idLocacao, MinHoraData(_mloc.DataLocacao), MinHoraData(_mloc.DataPrevisaoEntrega), true).ToString("0.00"));
                //}
                //else
                //{
                //    texto.WriteLine("Valor a pagar : " + _mloc.ValorPagoFinal.ToString("0.00"));
                //}
                //texto.WriteLine("");
                //texto.WriteLine("");
                //texto.WriteLine("");
                //if (StatusLocação == 2)
                //{
                //    texto.WriteLine("______________________________");
                //    texto.WriteLine("(" + _mloc.IDClienteLocacao.Nome + ")");

                //}
                //else
                //{
                //    texto.WriteLine("(" + _mloc.IDClienteLocacao.Nome + ")");
                //    texto.WriteLine("**********DEVOLUCAO**********");
                //}

                //texto.WriteLine(" ***** Obrigado e volte sempre **** ");

                //texto.Close();




                //Util.Imprimir(@"C:\Temp\1.txt");





            }
            catch (Exception ex)
            {
                Util.LogaErro("Erro em frmLocacao:" + ex.Message.ToString());
                throw;
            }


        }

        private void PrintReceiptPage(object sender, PrintPageEventArgs e)
        {
            string message = "AAA";
            int y;
            // Print receipt
            Font myFont = new Font("Times New Roman", 15, FontStyle.Bold);
            y = e.MarginBounds.Y;
            e.Graphics.DrawString(message, myFont, Brushes.Red, e.MarginBounds.X, y);
        }


        private void txtDataEntrega_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dataEntrega = new DateTime(txtDataEntrega.Value.Year, txtDataEntrega.Value.Month, txtDataEntrega.Value.Day);


                bLocacao _bLocacao = new bLocacao();

                lblTotal.Text = _bLocacao.PrevisaoPreco(idLocacao, MinHoraData(DateTime.Now), MinHoraData(dataEntrega), true).ToString();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            modo_tela = Util.ModoTela.NOVO;
            atualizaTela();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            modo_tela = Util.ModoTela.ALTERACAO;
            atualizaTela();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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
                    Mensagem(this, "Jogo inserido com erro", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Erro);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
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

        private void picExcluir_Click(object sender, EventArgs e)
        {

            bLocacao _bLocacao = new bLocacao();

            if (Mensagem(this, "Deseja realmente excluir ?", Frameworks.Classes.CMsgBox.TipoBotoes.SimNao, Frameworks.Classes.CMsgBox.TipoErro.Informacao) == DialogResult.Yes)
            {

                if (_bLocacao.Excluir(idLocacao))
                {
                    Mensagem(this, "Excluido com sucesso...", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Ok);
                }
                else
                {
                    Mensagem(this, "Erro ao excluir", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Erro);
                }
            }
        }

        private void lblDataCadastro_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

