using Frameworks.Classes;
using MaisGamers.DLL.Locacao;
using MaisGamers.Model.Documento;
using MaisGamers.Model.Locacao;
using MaisGamers.Modulos;
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

            btnAbrir.Enabled = false;
            btnSalvar.Enabled = false;

            
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
            string documento;

            try
            {


                file.ShowDialog();
                if (string.IsNullOrEmpty(file.FileName))
                {
                    return;
                }

                _byte = File.ReadAllBytes(file.FileName);

                if (rbRG.Checked)
                {
                    documento = "RG";
                }
                else if (rbContrato.Checked)
                {
                    documento = "CONTRATO";
                }
                else
                {
                    documento = "COMPROVANTE";
                }

                if (_bcliente.SalvarDocumento(idCLienteLocacao, _byte, documento, Path.GetExtension(file.FileName)))
                {

                    Util.Mensagem("Registro incluído com sucesso", CMsgBox.TipoBotoes.OK, CMsgBox.TipoErro.Ok);
                }
                else
                {
                    Util.Mensagem("Erro ao salvar o documento", CMsgBox.TipoBotoes.OK, CMsgBox.TipoErro.Erro);
                }


                this.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            bClienteLocacao _cliente = new bClienteLocacao();

            mDocumento documento = new mDocumento();
            string strDoc = "";
            try
            {


                if (rbRG.Checked)
                {
                    strDoc = "RG";
                }
                else if (rbContrato.Checked)
                {
                    strDoc = "CONTRATO";
                }
                else
                {
                    strDoc = "COMPROVANTE";
                }
                documento = _cliente.BuscarDocumento(idCLienteLocacao, strDoc);



                if (File.Exists(@"c:\temp\aaa." + documento.extensaoArquivo))
                {
                    File.Delete(@"c:\temp\aaa." + documento.extensaoArquivo);
                }

                File.WriteAllBytes(@"c:\temp\aaa." + documento.extensaoArquivo, documento.documentos);

                Process.Start(@"c:\temp\aaa." + documento.extensaoArquivo);



            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void cmbDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            bClienteLocacao _cliente = new bClienteLocacao();
            mDocumento documento = new mDocumento();

            btnAbrir.Enabled = false;


            if (rbRG.Checked)
            {
                documento = _cliente.BuscarDocumento(idCLienteLocacao, "RG");

                if (documento.documentos == null)
                {
                    btnAbrir.Enabled = false;
                }
                else
                {
                    btnAbrir.Enabled = true;
                }

            }

            else if (rbContrato.Checked)
            {
                documento = _cliente.BuscarDocumento(idCLienteLocacao, "CONTRATO");

                if (documento.documentos == null)
                {
                    btnAbrir.Enabled = false;
                }
                else
                {
                    btnAbrir.Enabled = true;
                }

            }
            else if (rbComprovante.Checked)
            {
                documento = _cliente.BuscarDocumento(idCLienteLocacao, "ENDERECO");

                if (documento.documentos == null)
                {
                    btnAbrir.Enabled = false;
                }
                else
                {
                    btnAbrir.Enabled = true;
                }

            }

        }

        private void rbRG_CheckedChanged(object sender, EventArgs e)
        {

            BuscarContrato("RG");

        }

        private void BuscarContrato(string strDocumento)
        {

            bClienteLocacao _cliente = new bClienteLocacao();
            mDocumento documento = new mDocumento();
            try
            {
                if (idCLienteLocacao == 0)
                {
                    return;
                }

                btnSalvar.Enabled = true;



                documento = _cliente.BuscarDocumento(idCLienteLocacao, strDocumento);

                if (documento.documentos == null)
                {
                    btnAbrir.Enabled = false;
                }
                else
                {
                    btnAbrir.Enabled = true;
                }



            }
            catch (Exception)
            {

                throw;
            }

        }
        private void rbContrato_CheckedChanged(object sender, EventArgs e)
        {
            BuscarContrato("CONTRATO");


        }

        private void rbComprovante_CheckedChanged(object sender, EventArgs e)
        {
            BuscarContrato("COMPROVANTE");
        }
    }
}
