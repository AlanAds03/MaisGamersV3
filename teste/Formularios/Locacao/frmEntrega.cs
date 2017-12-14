using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaisGamers.Formularios.Locacao
{

    public partial class frmEntrega : Form
    {
        public DateTime DataEntrega { get { return txtDataEntrega.Value; } set { txtDataEntrega.Value = Convert.ToDateTime(value); } }
        public string ValorDevido { get { return txtvalordevido.Text; } set { txtvalordevido.Text = value; } }

        public double ValorPago { get { return (string.IsNullOrEmpty(txtValorPagoLocacao.Text) ? 0 : Convert.ToDouble(txtValorPagoLocacao.Text)); } set { txtValorPagoLocacao.Text = value.ToString("0,00"); } }

        public string acao { get; set; }

        public frmEntrega()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            acao = "Concluir";
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            acao = "Fechar";
            this.Close();
        }
    }
}
