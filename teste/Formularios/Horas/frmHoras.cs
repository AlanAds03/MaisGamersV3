using Frameworks.Componentes;
using MaisGamers.DLL.Hora;
using MaisGamers.Model.Hora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaisGamers.Formularios.Horas
{
    public partial class frmHoras : Form
    {

        public bool IniciarPS1 = false;
        public DateTime horaFinal;
        public DateTime horaRestante;
        public frmHoras()
        {
            InitializeComponent();
            CarregaCombo(cmdHora);

            timer1.Start();




        }

        private void CarregaCombo(SuperComboBox combo)
        {
            try
            {
                bHora _bHora = new bHora();
                List<mHora> horas = new List<mHora>();

                horas = _bHora.CarregarHora(1);
                combo.CarregaCombo(horas, "vPreco", "Descricao", Frameworks.Componentes.SuperComboBox.PrimeiraLinha.Selecione);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cmdHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValorPagar1.Text = cmdHora.ObterValor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string retorno;

            retorno = cmdHora.ObterTexto();

            lblInicio1.Text = System.DateTime.Now.ToLongTimeString();

            IniciarPS1 = true;

            if (retorno == "retorno")
            {
                return;
            }

            if (retorno == "30 Minutos")
            {
                lblFIM1.Text = System.DateTime.Now.AddMinutes(30).ToLongTimeString();
            }
            else if (retorno == "1 Hora")
            {
                lblFIM1.Text = System.DateTime.Now.AddMinutes(60).ToLongTimeString();
            }
            else if (retorno == "1 Hora e Meia")
            {
                lblFIM1.Text = System.DateTime.Now.AddMinutes(90).ToLongTimeString();
            }
            else if (retorno == "2 Horas")
            {
                lblFIM1.Text = System.DateTime.Now.AddMinutes(120).ToLongTimeString();
            }
            else if (retorno == "2 Horas e Meia")
            {
                lblFIM1.Text = System.DateTime.Now.AddMinutes(150).ToLongTimeString();
            }
            else if (retorno == "3 Horas")
            {
                horaFinal = System.DateTime.Now.AddMinutes(180);

                lblFIM1.Text = horaFinal.ToLongTimeString();

                
            }

            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IniciarPS1 == true)
            {

                var a = horaFinal.Subtract(System.DateTime.Now);
                lblRestante1.Text = a.ToString();

            }
            
        }
    }
}
