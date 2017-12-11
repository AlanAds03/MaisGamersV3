using MaisGamers.DLL.Locacao;
using MaisGamers.Model.Locacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Frameworks.Componentes.SuperComboBox;

namespace MaisGamers.Formularios.Cadastro.Popup
{
    public partial class frmDocumentos : Form
    {

        public int idCLienteLocacao;

        public frmDocumentos()
        {
            InitializeComponent();
            CarregaComboDocumentos();
        }



        public void CarregaComboDocumentos()
        {

            Dictionary<String, String> list = new Dictionary<string, string>();




            try
            {

                list.Add("1", "RG");
                list.Add("2", "Contrato");
                list.Add("3", "Endereço");



                cmbDocumentos.CarregaCombo(list, "cid", "rTexto", PrimeiraLinha.Selecione);
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            bClienteLocacao _bcliente = new bClienteLocacao();


            OpenFileDialog file = new OpenFileDialog();
            byte[] _byte;


            try
            {
                //RG





                file.ShowDialog();


                _byte = File.ReadAllBytes(file.FileName);


                _bcliente.SalvarDocumento(idCLienteLocacao, _byte, cmbDocumentos.Text.ToUpper());




            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            bClienteLocacao _cliente = new bClienteLocacao();

            byte[] documento;
            try
            {


                documento = _cliente.BuscarDocumento(idCLienteLocacao, cmbDocumentos.Text.ToString().ToUpper());


                if (File.Exists(@"c:\temp\aaa.docx"))
                {
                    File.Delete(@"c:\temp\aaa.docx");
                }

                File.WriteAllBytes(@"c:\temp\aaa.docx", documento);

                Process.Start(@"c:\temp\aaa.docx");



            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void cmbDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            bClienteLocacao _cliente = new bClienteLocacao();
            byte[] documento;

            btnAbrir.Enabled = false;


            if (cmbDocumentos.SelectedValue.ToString() == "1")
            {
                documento = _cliente.BuscarDocumento(idCLienteLocacao, "RG");

                if (documento == null)
                {
                    btnAbrir.Enabled = false;
                }
                else
                {
                    btnAbrir.Enabled = true;
                }

            }

            else if (cmbDocumentos.SelectedValue.ToString() == "2")
            {
                documento = _cliente.BuscarDocumento(idCLienteLocacao, "CONTRATO");

                if (documento == null)
                {
                    btnAbrir.Enabled = false;
                }
                else
                {
                    btnAbrir.Enabled = true;
                }

            }
            else if (cmbDocumentos.SelectedValue.ToString() == "3")
            {
                documento = _cliente.BuscarDocumento(idCLienteLocacao, "ENDERECO");

                if (documento == null)
                {
                    btnAbrir.Enabled = false;
                }
                else
                {
                    btnAbrir.Enabled = true;
                }

            }

        }
    }
}
