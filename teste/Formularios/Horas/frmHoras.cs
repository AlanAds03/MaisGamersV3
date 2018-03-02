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
        public frmHoras()
        {
            InitializeComponent();
            CarregaCombo(cmdHora);


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
    }
}
