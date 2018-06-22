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
using MaisGamers.DLL.Venda;
using MaisGamers.Model.Vendas;

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmVendas : Form
    {
        public int IDVenda;
        public int IDVendaProd;
        public double total;
        public bool bVendaFinalizada;
        public Dictionary<TipoPagamento, mTipoPagamento> taxas = new Dictionary<TipoPagamento, mTipoPagamento>();

        public frmVendas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            //string[] row = new string[] { "1", "Desbloqueio Xbox 360", "1000", "1111", "10" };

            //dataGridView1.Rows.Add(row);

            try
            {
                frmPesquisaProdutoNovo produto = new frmPesquisaProdutoNovo();

                produto.ShowDialog();
            }
            catch (Exception ex)
            {

                Util.LogaErro("Erro em FrmVendas :" + ex.Message.ToString());
            }
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CarregarValores();
        }

        private void CarregarValores()
        {
            decimal total = 0;
            try
            {
                if(dataGridView1.Rows.Count > 0)
                {
                    foreach(DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Util.IsNumeric(row.Cells[4].Value.ToString()))
                        {
                            total += Convert.ToDecimal(row.Cells[4].Value);
                        }
                    }

                    txtTotal.Text = total.ToString("0.00");
                }
            }
            catch (Exception ex)
            {

                Util.LogaErro("Erro em frmVendas :" + ex.Message.ToString());
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CarregarValores();
        }


        //private void CarregaComboQuantidade(SuperComboBox combo)
        //{
        //    try
        //    {
        //        Dictionary<String, String> listas = new Dictionary<string, string>();

        //        listas.Add("1", "2x");
        //        listas.Add("2", "3x");
        //        listas.Add("3", "4x");
        //        listas.Add("4", "5x");
        //        listas.Add("5", "6x");



        //        combo.CarregaCombo(listas, "IDTipoPagamento", "TipoPagamento", Frameworks.Componentes.SuperComboBox.PrimeiraLinha.Nenhum);

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message.ToString());
        //    }
        //}

        //private void CarregaComboTipoPagamento(SuperComboBox combo)
        //{

        //    try
        //    {
        //        bTipoPagamento _bPagamento = new bTipoPagamento();

        //        List<mTipoPagamento> pagamentos = new List<mTipoPagamento>();

        //        pagamentos = _bPagamento.CarregaComboTipoPagamento();

        //        // guardar as taxas 

        //        foreach (mTipoPagamento _tipo in pagamentos)
        //        {
        //            taxas.Add((TipoPagamento)_tipo.IDTipoPagamento, _tipo);
        //        }


        //        combo.CarregaCombo(pagamentos, "IDTipoPagamento", "TipoPagamento", Frameworks.Componentes.SuperComboBox.PrimeiraLinha.Nenhum);

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message.ToString());
        //    }
        //}
        //private void btnAdicionarProduto_Click(object sender, EventArgs e)
        //{
        //    frmPesquisaProduto thays = new frmPesquisaProduto();

        //    thays.idVenda = IDVenda;
        //    thays.ShowDialog();

        //    CarregaGrid();
        //    //CarregaTotal();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    frmPesquisaJogo jogo = new frmPesquisaJogo();

        //    jogo.ShowDialog();
        //}

        //public void CarregaGrid()
        //{
        //    bVenda _vendas = new bVenda();

        //    lvLocacao.CarregaListaView<dynamic>(_vendas.CarregaGridVendas(IDVenda));

        //    CarregaTotal();



        //}

        //public void CarregaTotal()
        //{
        //    bVenda _vendas = new bVenda();
        //    txtTotal.Text = _vendas.TotalVenda(IDVenda).ToString("0.00");
        //    total = Convert.ToDouble(txtTotal.Text);
        //}

        //private void pictureBox6_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void lvLocacao_ItemChecked(object sender, ItemCheckedEventArgs e)
        //{

        //    if (e.Item.Checked)
        //    {
        //        IDVendaProd = Convert.ToInt32(lvLocacao.ObterChave().ToString());
        //    }
        //    else
        //    {
        //        IDVendaProd = 0;
        //    }
        //}

        //private void frmVendas_Load(object sender, EventArgs e)
        //{
        //    CarregaGrid();
        //    CarregaComboTipoPagamento(cmdTipoPagamento);
        //    CarregaComboQuantidade(cmbQuantidade);
        //    //Util.CentralizaGrupo(grpBotoes2);
        //    Util.CentralizaTab(tbVendas, false);

        //}

        //private void btnExcluirJogo_Click(object sender, EventArgs e)
        //{
        //    if (IDVendaProd == 0)
        //    {
        //        Mensagem(this, "Selecionar um produto para exclusão", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Informacao);
        //        return;
        //    }
        //    bVenda _bVenda = new bVenda();

        //    _bVenda.ExcluirProdutoVenda(IDVendaProd);

        //    CarregaGrid();
        //}

        //public void CalcularTroco()
        //{
        //    if (Util.IsNumeric(txtTotal.Text) && Util.IsNumeric(txtValorPago.Text))
        //    {
        //        txtTroco.Text = (Convert.ToDouble(txtValorPago.Text) - Convert.ToDouble(txtTotal.Text)).ToString("0.00");
        //    }
        //    else
        //    {
        //        txtTroco.Text = string.Empty;
        //    }
        //}
        //private void txtValorPago_TextChanged(object sender, EventArgs e)
        //{
        //    CalcularTroco();


        //}

        //private void cmdTipoPagamento_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    bTipoPagamento _pTipoPagamento = new bTipoPagamento();

        //    if (Util.IsNumeric(cmdTipoPagamento.ObterValor()))
        //    {

        //        if ((TipoPagamento)Convert.ToInt32(cmdTipoPagamento.ObterValor()) == TipoPagamento.DINHEIRO)
        //        {
        //            txtTotal.Text = total.ToString("0.00");
        //            cmbQuantidade.Visible = false;
        //            return;
        //        }

        //        var x = taxas[(TipoPagamento)Convert.ToInt32(cmdTipoPagamento.ObterValor())];

        //        if ((TipoPagamento)Convert.ToInt32(cmdTipoPagamento.ObterValor()) != TipoPagamento.PARCELADO)
        //        {
        //            txtTotal.Text = (((Convert.ToDecimal(total) * x.Taxa) / 100) + Convert.ToDecimal(total)).ToString("0.00");
        //            cmbQuantidade.Visible = false;

        //        }
        //        else if ((TipoPagamento)Convert.ToInt32(cmdTipoPagamento.ObterValor()) == TipoPagamento.PARCELADO)
        //        {

        //            CalcularParcelado();
        //        }


        //        CalcularTroco();
        //    }
        //}

        //private void CalcularParcelado()
        //{
        //    var taxaCredito = taxas[TipoPagamento.CARTAO].Taxa;
        //    var taxaParcelado = taxas[TipoPagamento.PARCELADO].Taxa;

        //    if (Util.IsNumeric(cmbQuantidade.ObterValor()))
        //    {
        //        var xTaxa = taxaCredito + (taxaParcelado * Convert.ToDecimal(cmbQuantidade.ObterValor()));

        //        txtTotal.Text = ((Convert.ToDecimal(total) * xTaxa) / 100 + Convert.ToDecimal(total)).ToString("0.00");
        //        cmbQuantidade.Visible = true;
        //    }
        //}

        //private void txtValorPago_Leave(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(txtValorPago.Text))
        //    {
        //        txtValorPago.Text = Convert.ToDouble(txtValorPago.Text).ToString("0.00");
        //        total = Convert.ToDouble(txtValorPago.Text);
        //    }

        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void btnFinalizar_Click(object sender, EventArgs e)
        //{
        //    if (ValidaCampos() == false)
        //    {
        //        return;
        //    }

        //    bVenda _bVenda = new bVenda();
        //    mVenda _mVenda = new mVenda();
        //    bProduto _bProduto = new bProduto();
        //    //Pegar lista do produtos para dar baixa no estoque 

        //    string chaves = lvLocacao.ObterTodosRegistros(";").ToString();

        //    foreach (string chave in chaves.Split(Convert.ToChar(";")))
        //    {
        //        if (string.IsNullOrEmpty(chave))
        //        {
        //            continue;
        //        }
        //        Int32 idProduto = _bVenda.RetornoCodigoProduto(Convert.ToInt32(chave));

        //        _bProduto.BaixarEstoqueProduto(idProduto);
        //    }
        //    // com os ids buscar os produtos para dar baixar


        //    _mVenda.IDVenda = IDVenda;
        //    _mVenda.vValorTotal = Convert.ToDouble(txtTotal.Text);
        //    _mVenda.vValorPago = Convert.ToDouble(txtValorPago.Text);
        //    _mVenda.dVenda = System.DateTime.Now;
        //    _mVenda.rCliente = txtCliente.Text;

        //    if (_bVenda.FinalizarVenda(_mVenda))
        //    {
        //        bVendaFinalizada = true;

        //        if (Mensagem(this, "Venda finalizada, deseja imprimir o comprovante ?", Frameworks.Classes.CMsgBox.TipoBotoes.SimNao, Frameworks.Classes.CMsgBox.TipoErro.Informacao) == DialogResult.Yes)
        //        {
        //            ImprimirComprovante();
        //        }

        //    }



        //}

        //private void ImprimirComprovante()
        //{

        //    bVenda _bVEnda = new bVenda();
        //    List<dynamic> lista = new List<dynamic>();

        //    try
        //    {



        //        if (File.Exists(@"C:\Temp\vendas.txt"))
        //        {
        //            File.Delete(@"C:\Temp\vendas.txt");
        //        }

        //        StreamWriter texto = new StreamWriter(@"C:\Temp\vendas.txt");


        //        lista = _bVEnda.CarregaGridVendas(IDVenda);

        //        texto.WriteLine("                                    ");
        //        texto.WriteLine("             LOCADORA MAIS GAMERS               ");
        //        texto.WriteLine("             CNPJ: 23.260.093/0001-87           ");
        //        texto.WriteLine("************************************************");
        //        texto.WriteLine("             COMPROVANTE DE PAGAMENTO           ");
        //        texto.WriteLine("             NOTA NAO FISCAL                    ");
        //        texto.WriteLine("************************************************");
        //        texto.WriteLine("CLIENTE : " + lista.FirstOrDefault().rCliente);
        //        texto.WriteLine("DATA : " + System.DateTime.Now.ToString());
        //        texto.WriteLine("************************************************");

        //        texto.WriteLine("DESCRICAO                     VALOR");

        //        foreach (var item in lista)
        //        {

        //            string produto = item.Produto;

        //            if (produto.Length > 30)
        //            {
        //                produto.Substring(0, 30);
        //            }
        //            texto.WriteLine(produto.PadRight(30,Convert.ToChar(" ")) + "R$ " + item.Valor.ToString("0.00"));
        //        }

        //        texto.WriteLine("************************************************");

        //        string pagamento;

        //        pagamento = "PAGAMENTO : " + (TipoPagamento)Convert.ToInt32(cmdTipoPagamento.ObterValor());


        //        if ((TipoPagamento)Convert.ToInt32(cmdTipoPagamento.ObterValor()) == TipoPagamento.PARCELADO)
        //        {
        //            pagamento = pagamento + cmbQuantidade.SelectedValue.ToString() + "x";
        //        }
        //        texto.WriteLine(pagamento);

        //        texto.WriteLine("TOTAL : R$ " + txtTotal.Text);
        //        texto.WriteLine("PAGO R$ : " + txtValorPago.Text);
        //        texto.WriteLine("TROCO R$ : " + txtTroco.Text);

        //        texto.WriteLine("************************************************");
        //        texto.WriteLine("OBRIGADO E VOLTE SEMPRE");


        //        texto.Close();

        //        //PrintDialog printDialog = new PrintDialog();
        //        //PrintDocument printDocument = new PrintDocument();
        //        //printDialog.Document = printDocument;

        //        //printDocument.PrintPage += new PrintPageEventHandler(PrintReceiptPage);

        //        //DialogResult result = printDialog.ShowDialog();

        //        //if (result == DialogResult.OK)
        //        //{
        //        //    printDocument.Print();
        //        //}



        //        ProcessStartInfo info = new ProcessStartInfo();
        //        info.Verb = "print";
        //        info.FileName = @"C:\Temp\vendas.txt";
        //        info.Arguments = "\\Fiscal4\\";

        //        info.CreateNoWindow = true;
        //        info.WindowStyle = ProcessWindowStyle.Hidden;

        //        Process p = new Process();
        //        p.StartInfo = info;
        //        p.Start();

        //        p.WaitForInputIdle();
        //        System.Threading.Thread.Sleep(3000);

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }


        //}

        //private bool ValidaCampos()
        //{
        //    bool retorno = true;


        //    if (total == 0)
        //    {
        //        Mensagem(this, "Informar produto à venda", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Informacao);
        //        return false;
        //    }
        //    if (string.IsNullOrEmpty(txtTroco.Text))
        //    {
        //        Mensagem(this, "Não foi possível  obter o troco informar valor total e valor pago", Frameworks.Classes.CMsgBox.TipoBotoes.OK, Frameworks.Classes.CMsgBox.TipoErro.Erro);
        //        retorno = false;
        //    }



        //    return retorno;
        //}

        //private void cbmQuantidade_SelectedValueChanged(object sender, EventArgs e)
        //{

        //    if (Util.IsNumeric(cmbQuantidade.ObterValor()))
        //    {


        //        var x = taxas[(TipoPagamento)Convert.ToInt32(cmdTipoPagamento.ObterValor())];


        //        var xaaa = ((Convert.ToDecimal(total) * (x.Taxa + Convert.ToDecimal(cmbQuantidade.ObterValor()))) / 100 + Convert.ToDecimal(total)).ToString("0.00");

        //        //txtTotal.Text = "sdds";
        //    }
        //}

        //private void cmbQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    CalcularParcelado();
        //    CalcularTroco();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if(total > 0)
        //    {
        //        ImprimirComprovante();
        //    }

        //}

        ////private void btnExcluirJogo_Click(object sender, EventArgs e)
        ////{
        ////    bVenda _bVenda = new bVenda();

        ////    _bVenda.ExcluirProdutoVenda(IDVenda, IDProduto);

        ////    CarregaGrid();
        ////}
    }
}

