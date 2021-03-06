﻿using MaisGamers.DLL.Locacao;
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

namespace MaisGamers.Formularios.Locacao
{
    public partial class frmPopupFehamento : Form
    {
        public int idLocacao { get; set; }
        public DateTime DataLocacao { get { return txtDataLocacao.Value; } set { txtDataLocacao.Value = value; } }

        public DateTime DataPrevisao { get { return txtDataPrevista.Value; } set { txtDataPrevista.Value = value; } }
        public DateTime DataEntrega { get { return txtDataEntrega.Value; } set { txtDataEntrega.Value = value; } }

        public double ValorDevido { get { return Convert.ToDouble(txtvalordevido.Text); } set { txtvalordevido.Text = value.ToString("0.00"); } }
        public double ValorPagoLocacao { get { return Convert.ToDouble(txtValorPagoLocacao.Text); } set { txtValorPagoLocacao.Text = value.ToString("0.00"); } }

        public double ValorRestante { get { return Convert.ToDouble(txtRestantePagar.Text); } set { txtRestantePagar.Text = value.ToString("0.00"); } }

        public double Troco { get { return Convert.ToDouble(txtValorTroco.Text); } set { txtValorTroco.Text = value.ToString("0.00"); } }

        public string acao = "";

        public frmPopupFehamento()
        {
            InitializeComponent();

            //txtDataEntrega.Enabled = false;
            txtDataLocacao.Enabled = false;
            txtvalordevido.Enabled = false;
            txtValorPagoLocacao.Enabled = false;
            btnConcluir.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Validar pagamento

                if (Convert.ToDouble(txtvalordevido.Text) > (Convert.ToDouble(txtValorPagoLocacao.Text) + Convert.ToDouble(txtRestantePagar.Text)))
                {
                    MessageBox.Show("Pagar valor referente a locação");
                    return;
                }

                acao = "Concluir";
                this.Close();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            acao = "Fechar";
            this.Close();
        }

        private void txtValorPagoEntrega_Leave(object sender, EventArgs e)
        {

            double troco = 0;

            txtValorTroco.Text = string.Empty;

            if (!Util.IsNumeric(txtRestantePagar.Text))
            {
                MessageBox.Show("Digitar valor numerico");
                return;
            }
            txtRestantePagar.Text = Convert.ToDouble(txtRestantePagar.Text).ToString("0.00");

            troco = (Convert.ToDouble(txtRestantePagar.Text) + Convert.ToDouble(txtValorPagoLocacao.Text)) - Convert.ToDouble(txtvalordevido.Text);
            if (troco >= 0)
            {
                btnConcluir.Enabled = true;

                txtValorTroco.Text = troco.ToString("0.00");

            }
            else
            {
                btnConcluir.Enabled = false;
            }
        }

        private void txtDataEntrega_Leave(object sender, EventArgs e)
        {
            bLocacao _locacao = new bLocacao();
            ValorDevido = Convert.ToDouble(_locacao.PrevisaoPreco(idLocacao, Util.MinHoraData(txtDataLocacao.Value), Util.MinHoraData(txtDataEntrega.Value), true).ToString());

        }

        private void txtDataEntrega_ValueChanged(object sender, EventArgs e)
        {
            bLocacao _locacao = new bLocacao();
            ValorDevido = Convert.ToDouble(_locacao.PrevisaoPreco(idLocacao, Util.MinHoraData(txtDataLocacao.Value), Util.MinHoraData(txtDataEntrega.Value), true).ToString());

            if (!String.IsNullOrEmpty(txtValorPago.Text) && !String.IsNullOrEmpty(txtRestantePagar.Text))
            {
                txtValorTroco.Text = Convert.ToDouble(Convert.ToDouble(txtValorPago.Text) - Convert.ToDouble(txtRestantePagar.Text)).ToString("0.00");
            }

        }

        private void txtValorPagoEntrega_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorTroco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtValorPagoLocacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPopupFehamento_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtValorPago.Text)  && !String.IsNullOrEmpty(txtRestantePagar.Text))
            {
                txtValorTroco.Text = Convert.ToDouble(Convert.ToDouble(txtValorPago.Text) - Convert.ToDouble(txtRestantePagar.Text)).ToString("0.00");
            }
        }
    }
}
