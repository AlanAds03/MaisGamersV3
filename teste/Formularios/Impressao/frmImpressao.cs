using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MaisGamers.Formularios.Impressao
{
    public partial class frmImpressao : Form
    {
        public frmImpressao()
        {
            InitializeComponent();
        }


        public void CarregarImpressoras()
        {

            DataTable data = new DataTable();

            data.Columns.Add("id");
            data.Columns.Add("texto");

            int contador = 1;
            foreach (var impr in PrinterSettings.InstalledPrinters)
            {
                data.Rows.Add(contador, impr);
                contador += 1;
            }


            cmbImpressora.DataSource = data;
            cmbImpressora.ValueMember = "id";
            cmbImpressora.DisplayMember = "texto";

            

        }

        private void frmImpressao_Load(object sender, EventArgs e)
        {
            CarregarImpressoras();
            CarregaAutorizado();
        }

        private void CarregaAutorizado()
        {

            DataTable data = new DataTable();

            data.Columns.Add("id");
            data.Columns.Add("texto");

            data.Rows.Add("1", "Sim");
            data.Rows.Add("2", "Não");

            cmbAutorizado.DataSource = data;
            cmbAutorizado.ValueMember = "id";
            cmbAutorizado.DisplayMember = "texto";

        }

        private void button1_Click(object sender, EventArgs e)
        {


             

            //ProcessStartInfo info = new ProcessStartInfo();

            //info.Verb = "print";
            //info.FileName = @"C:\Users\maisg\Desktop\LOCAÇÃO\CONTRATO.docx";
            //info.Arguments = "\"" + cmbImpressora.Text + "\"";
            //info.CreateNoWindow = true;
            //info.WindowStyle = ProcessWindowStyle.Hidden;

            //Process p = new Process();
            //p.StartInfo = info;
            //p.Start();

            //p.WaitForInputIdle();
            //System.Threading.Thread.Sleep(3000);
            //if (false == p.CloseMainWindow())
             //   p.Kill();



        }
    }
}
