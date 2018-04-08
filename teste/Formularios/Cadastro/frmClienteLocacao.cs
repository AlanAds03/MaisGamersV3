using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaisGamers.Modulos;
using static MaisGamers.Modulos.Util;
using MaisGamersV2.DAL.Locacao;
using MaisGamers.Model.Locacao;
using MaisGamers.Model;
using Frameworks.Componentes;
using MaisGamers.DLL;
using MaisGamers.DLL.Locacao;
using System.Web.Script.Serialization;
using MaisGamers.Formularios;
using System.Runtime.InteropServices;
using Frameworks.Classes;
using System.Net;
using MaisGamers.DAL.Cadastro;
using System.IO;
using System.Diagnostics;
//using mshtml;
using MaisGamers.Formularios.Cadastro.Popup;
using System.Reflection;
using Microsoft.Office.Interop.Word;
//using MaisGamers.Formularios.Impressao;
//using MaisGamers.Formularios.Locacao;

namespace MaisGamers.Formularios.Cadastro
{


    public partial class frmClienteLocacao : Form
    {

        public ModoTela modo_tela;
        public bool habilitaTabPage = false;
        public int idClienteLocacao;


        public frmClienteLocacao()
        {
            InitializeComponent();
        }

        private void frmClienteLocacao_Load(object sender, EventArgs e)
        {

            Util.CentralizaGrupo(grpBotoes);
            Util.CentralizaTab(tbControl);

            CarregaComboEstado(cmbEstado);
            CarregaComboCidade(cmbCidade, Convert.ToInt16(cmbEstado.SelectedValue));

            CarregaComboTipoCliente(cmbTipoCliente);
            CarregaComboSexo(cmbSexo);
            CarregaComboStatusCliente(cmbStatus);

            modo_tela = ModoTela.CONSULTA;
            atualizaTela();

            //tbControl.TabPages[1].

            //tbControl.ac
        }


        private void CarregaComboSexo(SuperComboBox cmbSexo)
        {


            List<mSexo> listSexo = new List<mSexo>();
            try
            {

                listSexo.Add(new mSexo() { cSexo = 1, rSexo = "Masculino" });
                listSexo.Add(new mSexo() { cSexo = 2, rSexo = "Feminino" });


                cmbSexo.CarregaCombo(listSexo, "cSexo", "rSexo", SuperComboBox.PrimeiraLinha.Selecione);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void CarregaComboEstado(SuperComboBox cmbEstado)
        {

            List<mEstado> list = new List<mEstado>();

            try
            {
                bEstado _estado = new bEstado();

                list = _estado.CarregaEstado();


                cmbEstado.CarregaCombo(list, "cEstado", "rEstado", SuperComboBox.PrimeiraLinha.Selecione);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void CarregaComboStatusCliente(SuperComboBox combo)
        {

            List<mStatusCliente> list = new List<mStatusCliente>();

            try
            {
                bStatusClienteLocacao statuscliente = new bStatusClienteLocacao();

                list = statuscliente.CarregaStatusClienteLocacao();


                combo.CarregaCombo(list, "ID_StatusCliente", "DescricaoStatusCliente", SuperComboBox.PrimeiraLinha.Nenhum);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }




        private void CarregaComboCidade(SuperComboBox comboCidade, int cEstado)
        {
            List<mCidade> list = new List<mCidade>();

            try
            {
                bCidade _cidade = new bCidade();
                System.Data.DataTable table = new System.Data.DataTable();

                table.Columns.Add("cCidade");
                table.Columns.Add("rCidade");


                list = _cidade.CarregaCidade(cEstado);

                //if (list != null)
                //{
                comboCidade.CarregaCombo(list, "cCidade", "rCidade", SuperComboBox.PrimeiraLinha.Selecione);
                //}



            }
            catch (Exception ex)
            {

                throw;
            }
        }


        private void CarregaComboTipoCliente(SuperComboBox comboCidade)
        {
            List<mTipoCliente> list = new List<mTipoCliente>();

            try
            {
                bTipoCliente _tipo = new bTipoCliente();



                list = _tipo.CarregaTipoCliente();

                if (list != null)
                {
                    comboCidade.CarregaCombo(list, "IDTipoCliente", "TipoCliente", SuperComboBox.PrimeiraLinha.Selecione);
                }



            }
            catch (Exception ex)
            {

                throw;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void PesquisaGrid(int codigo,
                                  string nome,
                                  string cpf,
                                  string rg,
                                  string autorizado)
        {


            bClienteLocacao _bCli = new bClienteLocacao();
            mClienteLocacao cli = new mClienteLocacao();
            List<mClienteLocacao> locacao = new List<mClienteLocacao>();
            string json;

            try
            {
                cli.idClienteLocacao = codigo;

                if (!string.IsNullOrEmpty(rg))
                {
                    cli.RG = rg;
                }

                if (!string.IsNullOrEmpty(cpf))
                {
                    cli.CPF = cpf;
                }


                cli.Nome = nome;
                cli.NomeFilho = autorizado;
                locacao = _bCli.PesquisaCliente(cli, "Nome");

                lvPesquisa.CarregaListaView<mClienteLocacao>(locacao);




                //json = _bCli.PesquisaCliente(cli, "Nome");

                //if (!string.IsNullOrEmpty(json))
                //{
                //    lvPesquisa.CarregaListaView<mClienteLocacao>(json);
                //}


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }




        }

        private void button4_Click(object sender, EventArgs e)
        {

            modo_tela = ModoTela.NOVO;
            atualizaTela();
        }

        private void atualizaTela()
        {

            if (modo_tela == ModoTela.CONSULTA)
            {
                tbControl.SelectTab("tpPesquisa");
                btnFechar.Text = "Fechar";
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                habilitaTabPage = false;


                int codigo = 0;

                if (!string.IsNullOrEmpty(txtPesquisaCodigo.Text))
                {
                    codigo = Convert.ToInt32(txtPesquisaCodigo.Text);
                }

                PesquisaGrid(codigo, txtPesquisaNome.Text, txtPesquisarg.Text, txtPesquisaCPF.Text,txtFIltroAutorizado.Text);



            }
            else if (modo_tela == ModoTela.NOVO)
            {
                habilitaTabPage = true;
                tbControl.SelectTab("tpDetalhe");
                btnFechar.Text = "Voltar";
                btnSalvar.Enabled = true;
                btnNovo.Enabled = false;
                idClienteLocacao = 0;
                LimpaCampos();


            }

            else if (modo_tela == ModoTela.ALTERACAO)
            {
                habilitaTabPage = true;
                tbControl.Enabled = true;
                tbControl.SelectTab("tpDetalhe");

                btnFechar.Text = "Voltar";
                btnSalvar.Enabled = true;
                btnNovo.Enabled = false;
                bClienteLocacao _bCli = new bClienteLocacao();
                mClienteLocacao cliente = new mClienteLocacao();
                cliente = _bCli.ObterCliente(idClienteLocacao);

                if (cliente == null)
                {
                    return;
                }


                txtCodigo.Text = idClienteLocacao.ToString();
                txtNome.Text = cliente.Nome;
                txtNomeMae.Text = cliente.NomeMae;
                txtCpf.Text = cliente.CPF;
                txtRG.Text = cliente.RG;
                txtDataNascimento.Text = Convert.ToString(cliente.DataNascimento);
                txtRua.Text = cliente.Rua;
                txtNumero.Text = cliente.Numero;
                txtCEP.Text = cliente.CEP;
                txtBairro.Text = cliente.Bairro;
                txtTelefone.Text = cliente.Telefone;
                txtNomePai.Text = cliente.NomePai;
                txtEmail.Text = cliente.Email;
                txtDataExpedicao.Text = Convert.ToString(cliente.DataExpedicao);

                txtAutoriza.Text = cliente.NomeFilho;
                txtCpfFilho.Text = cliente.CPFFilho;
                txtRGFilho.Text = cliente.RGFilho;

                cmbEstado.SelectedValue = cliente.Estado.cEstado;

                if (cliente.StatusCliente != null)
                {
                    cmbStatus.SelectedValue = cliente.StatusCliente.ID_StatusCliente;
                }
                
                txtTelefone.Text = cliente.Telefone;
                txtTelefone2.Text = cliente.Telefone2;

                cmbSexo.SelectedValue = cliente.cSexo;
                if (cliente.TipoCliente != null)
                {
                    cmbTipoCliente.SelectedValue = cliente.TipoCliente.IDTipoCliente;
                }
                else
                {
                    cmbTipoCliente.SelectedValue = "";
                }


                if (cliente.FotoLocatario != null)
                {
                    pictureLocatario.Image = Image.FromStream(new MemoryStream(cliente.FotoLocatario));
                    pictureLocatario.SizeMode = PictureBoxSizeMode.StretchImage;
                }



                if (cliente.FotoAutorizado != null)
                {
                    pictureAutorizado.Image = Image.FromStream(new MemoryStream(cliente.FotoAutorizado));
                    pictureAutorizado.SizeMode = PictureBoxSizeMode.StretchImage;
                }



                int codigo = 0;

                Int32.TryParse(cmbEstado.SelectedValue.ToString(), out codigo);
                if (codigo != 0)
                {
                    CarregaComboCidade(cmbCidade, codigo);
                }

                cmbCidade.SelectedValue = cliente.Cidade.cCidade;




            }

        }

        private void LimpaCampos()
        {
            idClienteLocacao = 0;
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtNomeMae.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtDataNascimento.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtBairro.Text = string.Empty;
            cmbEstado.ResetarValores();
            cmbCidade.ResetarValores();
            txtAutoriza.Text = string.Empty;
            txtCpfFilho.Text = string.Empty;
            txtRGFilho.Text = string.Empty;
            cmbTipoCliente.ResetarValores();
            txtTelefone.Text = string.Empty;
            txtTelefone2.Text = string.Empty;
            txtDataExpedicao.Text = string.Empty;
            txtNomePai.Text = string.Empty;
            cmbSexo.ResetarValores();
            txtEmail.Text = string.Empty;

            pictureLocatario.Image = null;
            pictureAutorizado.Image = null;








        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            if (modo_tela == ModoTela.CONSULTA)
            {
                this.Close();
                this.Dispose();
            }
            else
            {
                modo_tela = ModoTela.CONSULTA;
                atualizaTela();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            mClienteLocacao _mClilocacao = new mClienteLocacao();
            bClienteLocacao _cliente = new bClienteLocacao();

            _mClilocacao.StatusCliente = new mStatusCliente();


            if (ValidarCampos() == false)
            {
                return;
            }
            if (idClienteLocacao != 0)
            {
                _mClilocacao.idClienteLocacao = idClienteLocacao;
                
            }

            _mClilocacao.StatusCliente.ID_StatusCliente = Convert.ToInt32(cmbStatus.ObterValor());


            _mClilocacao.Nome = txtNome.Text;
            _mClilocacao.NomeMae = txtNomeMae.Text;
            _mClilocacao.NomePai = txtNomePai.Text;
            if (isDate(txtDataExpedicao.Text))
            {
                _mClilocacao.DataExpedicao = Convert.ToDateTime(txtDataExpedicao.Text);
            }
            else
            {
                _mClilocacao.DataExpedicao = null;
            }

            _mClilocacao.CPF = txtCpf.Text;
            _mClilocacao.RG = txtRG.Text;
            if (Util.isDate(txtDataNascimento.Text))
            {
                _mClilocacao.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);

            }
            else
            {
                MessageBox.Show("Informar a data de nascimento");
                txtDataNascimento.Text = string.Empty;
                return;
            }



            _mClilocacao.Rua = txtRua.Text;
            _mClilocacao.Numero = txtNumero.Text;
            _mClilocacao.CEP = txtCEP.Text;
            _mClilocacao.Bairro = txtBairro.Text;
            _mClilocacao.cEstado = Convert.ToInt16(cmbEstado.SelectedValue);
            _mClilocacao.cCidade = Convert.ToInt16(cmbCidade.SelectedValue);
            _mClilocacao.Telefone = txtTelefone.Text;
            _mClilocacao.Telefone2 = txtTelefone2.Text;
            _mClilocacao.IDTipoCliente = Convert.ToInt32(cmbTipoCliente.SelectedValue);
            _mClilocacao.NomeFilho = txtAutoriza.Text;
            _mClilocacao.Email = txtEmail.Text;
            _mClilocacao.RGFilho = txtRGFilho.Text.Replace(".", "").Replace("-", "").Replace(",", "");
            _mClilocacao.CPFFilho = txtCpfFilho.Text.Replace(".", "").Replace("-", "").Replace(",", "");
            _mClilocacao.cSexo = Convert.ToInt32(cmbSexo.SelectedValue);
            _mClilocacao.DataCadastrado = DateTime.Now;

            if (_cliente.IncluirCliente(_mClilocacao) == true)
            {
                if (idClienteLocacao == 0)
                {
                    Mensagem(this, "Registro incluído com sucesso", CMsgBox.TipoBotoes.OK, CMsgBox.TipoErro.Ok);

                }
                else
                {
                    Mensagem(this, "Registro alterado com sucesso", CMsgBox.TipoBotoes.OK, CMsgBox.TipoErro.Ok);
                }

                modo_tela = ModoTela.CONSULTA;
                atualizaTela();


            }
            else
            {
                Mensagem(this, "Erro ao incluir o registro", CMsgBox.TipoBotoes.OK, CMsgBox.TipoErro.Erro);

            }


        }
        private Boolean ValidarCampos()
        {
            bool retorno = true;


            if (string.IsNullOrEmpty(txtNome.Text))
            {
                errorProvider1.SetError(txtNome, "Informar o nome do cliente");
                retorno = false;
            }
            else
            {
                errorProvider1.SetError(txtNome, "");
            }

            if (string.IsNullOrEmpty(txtNomeMae.Text))
            {
                errorProvider1.SetError(txtNomeMae, "Informar o nome da mãe");
                retorno = false;
            }
            else
            {
                errorProvider1.SetError(txtNomeMae, "");
            }


            if (string.IsNullOrEmpty(txtRG.Text))
            {
                errorProvider1.SetError(txtRG, "Informar o rg do cliente");
                retorno = false;
            }
            else
            {
                errorProvider1.SetError(txtRG, "");
            }

            if (cmbEstado.ObterValor() == "0")
            {
                errorProvider1.SetError(cmbEstado, "Selecionar o estado");
                retorno = false;
            }
            else
            {
                errorProvider1.SetError(cmbEstado, "");
            }

            if (cmbCidade.ObterValor() == "0")
            {
                errorProvider1.SetError(cmbCidade, "Selecionar a cidade");
                retorno = false;
            }
            else
            {
                errorProvider1.SetError(cmbCidade, "");
            }


            if (cmbTipoCliente.ObterValor() == "0")
            {
                errorProvider1.SetError(cmbTipoCliente, "Informar o tipo de cliente");
                retorno = false;
            }
            else
            {
                errorProvider1.SetError(cmbTipoCliente, "");
            }
            if (string.IsNullOrEmpty(txtDataNascimento.Text) || (!isDate(txtDataNascimento.Text)))
            {
                errorProvider1.SetError(txtDataNascimento, "Data de Nascimento em branco ou inválida");
                retorno = false;
            }
            else
            {
                errorProvider1.SetError(txtDataNascimento, "");

                //validar já se é maior de idade

                DateTime dataNasci = new DateTime();

                dataNasci = Convert.ToDateTime(txtDataNascimento.Text);

                if (dataNasci.AddYears(18) > DateTime.Now)
                {
                    MessageBox.Show("Cliente não é maior de idade");
                    retorno = false;
                }
            }

            if (string.IsNullOrEmpty(txtCpf.Text.Replace(".", "").Replace("-", "").Replace(",", "").Trim()))
            {
                errorProvider1.SetError(txtCpf, "Informar o cpf do cliente");
                retorno = false;
            }
            else
            {
                errorProvider1.SetError(txtCpf, "");
            }


            return retorno;

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigo = 0;

            Int32.TryParse(Convert.ToString(cmbEstado.SelectedValue), out codigo);
            if (codigo != 0)
            {
                CarregaComboCidade(cmbCidade, codigo);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            modo_tela = ModoTela.ALTERACAO;
            atualizaTela();
        }

        private void lvPesquisa_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

            LimpaCampos();

            if (e.Item.Checked == true)
            {
                idClienteLocacao = Convert.ToInt32(lvPesquisa.ObterChave());

            }

            btnExcluir.Enabled = e.Item.Checked;
            btnLocacao.Enabled = e.Item.Checked;


        }


        private void lvPesquisa_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //for (var i = 0; i <= lvPesquisa.Items.Count - 1; i++)
            //{
            //    if (lvPesquisa.Items[i].Checked == true)
            //    {
            //        if (i == e.Index)
            //        {
            //            continue;
            //        }
            //        lvPesquisa.Items[i].Checked = false;
            //    }

            //}




        }

        private void grpCadastra_Enter(object sender, EventArgs e)
        {

        }

        private void grpBotoes_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            int idLocacao = 0;
            try
            {
                bLocacao _bLocacao = new bLocacao();
                mLocacao _mLocacao = new mLocacao();


                _mLocacao.idClienteLocacao = idClienteLocacao;
                _mLocacao.idStatusLocacao = 1;
                _mLocacao.DataLocacao = DateTime.Now;
                idLocacao = _bLocacao.InserirLocacao(_mLocacao);

                frmLocacao _locacao = new frmLocacao();
                _locacao.MdiParent = this.MdiParent;
                _locacao.modo_tela = ModoTela.ALTERACAO;
                _locacao.idClienteLocacao = idClienteLocacao;
                _locacao.idLocacao = idLocacao;
                _locacao.Show();




            }
            catch (Exception)
            {

                throw;
            }




            //frmLocacaoJogo _locacao = new frmLocacaoJogo();
            //_locacao.MdiParent = this.MdiParent;
            //_locacao.Show();
            //MostraFormulario(frmCliente);

        }

        private void btnTirarFoto_click(object sender, EventArgs e)
        {

            bClienteLocacao _bcliente = new bClienteLocacao();
            Byte[] foto;

            try
            {


                if (rbWebCAM.Checked)
                {
                    frmFoto _foto = new frmFoto();
                    _foto.ShowDialog();

                    if (_foto.fotos == null)
                    {
                        return;
                    }
                    if (rbLocatario.Checked)


                    {
                        pictureLocatario.Image = Image.FromStream(new MemoryStream(_foto.fotos[0]));
                        pictureLocatario.SizeMode = PictureBoxSizeMode.StretchImage;

                        _bcliente.IncluirFoto(idClienteLocacao, rbLocatario.Checked, _foto.fotos[0]);
                        
                    }
                    else
                    {
                        if (_foto.fotos[0] == null)
                        {
                            return;
                        }

                        pictureAutorizado.Image = Image.FromStream(new MemoryStream(_foto.fotos[0]));
                        pictureAutorizado.SizeMode = PictureBoxSizeMode.StretchImage;

                        _bcliente.IncluirFoto(idClienteLocacao, rbLocatario.Checked, _foto.fotos[0]);
                        

                    }
                }
                else
                {


                    OpenFileDialog fileDialog = new OpenFileDialog();

                    fileDialog.ShowDialog();

                    if (!string.IsNullOrEmpty(fileDialog.FileName))
                    {


                        

                        if (rbLocatario.Checked)
                        {
                            pictureLocatario.Image = Image.FromFile(fileDialog.FileName);
                            pictureLocatario.SizeMode = PictureBoxSizeMode.StretchImage;

                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureLocatario.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                foto = ms.ToArray();
                            }


                            _bcliente.IncluirFoto(idClienteLocacao, rbLocatario.Checked, foto);

                        }
                        else
                        {
                            pictureAutorizado.Image = Image.FromFile(fileDialog.FileName);
                            pictureAutorizado.SizeMode = PictureBoxSizeMode.StretchImage;

                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureAutorizado.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                foto = ms.ToArray();
                            }


                            _bcliente.IncluirFoto(idClienteLocacao, rbLocatario.Checked, foto);

                        }


                    }
                }

            }
            catch (Exception)
            {

                throw;
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }


        private void tbControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (habilitaTabPage == false)
            {
                e.Cancel = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {


            if (Mensagem(this, "Deseja realmente excluir este registro?", CMsgBox.TipoBotoes.SimNao, CMsgBox.TipoErro.Informacao) == DialogResult.Yes)
            {
                bClienteLocacao _cli = new bClienteLocacao();
                _cli.ExcluirCliente(idClienteLocacao);

            }
            int codigo = 0;

            if (!string.IsNullOrEmpty(txtPesquisaCodigo.Text))
            {
                codigo = Convert.ToInt32(txtPesquisaCodigo.Text);
            }

            PesquisaGrid(codigo, txtPesquisaNome.Text, txtPesquisarg.Text, txtPesquisaCPF.Text,txtFIltroAutorizado.Text);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int codigo = 0;

            if (!string.IsNullOrEmpty(txtPesquisaCodigo.Text))
            {
                codigo = Convert.ToInt32(txtPesquisaCodigo.Text);
            }

            PesquisaGrid(codigo,
                         txtPesquisaNome.Text,
                         txtPesquisaCPF.Text,
                         txtPesquisarg.Text.Trim(),
                         txtFIltroAutorizado.Text.Trim());

        }



        private void LimpaCamposFiltro()
        {
            txtPesquisaCodigo.Text = "";
            txtPesquisaNome.Text = "";
            txtPesquisaCPF.Text = "";
            txtPesquisarg.Text = "";
            lvPesquisa.Clear();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            if (chkBusca.Checked)
            {
                EnderecoCEP _endereco = new EnderecoCEP();
                _endereco = Util.RetornoCEP(txtCEP.Text);

                if (_endereco != null)
                {
                    txtRua.Text = _endereco.logradouro;
                    txtBairro.Text = _endereco.bairro;

                    bEstado _estado = new bEstado();

                    _estado.ConsultaUF(_endereco.uf);
                    cmbEstado.SelectedValue = _estado.ConsultaUF(_endereco.uf);

                    CarregaComboCidade(cmbCidade, Convert.ToInt32(cmbEstado.SelectedValue));

                }
            }

        }

        private void pictureLocatario_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (pictureLocatario.Image == null)
            {
                return;
            }

            if (me.Button == MouseButtons.Right)
            {
                SaveFileDialog _save = new SaveFileDialog();

                _save.ShowDialog();

                Image image = pictureLocatario.Image;

                if (File.Exists(_save.FileName + ".png"))
                {
                    File.Delete(_save.FileName + ".png");
                }


                image.Save(_save.FileName + ".png");

                if (Mensagem(this, "Imagem gerada com sucesso, deseja abrir a imagem ?", CMsgBox.TipoBotoes.SimNao, CMsgBox.TipoErro.Informacao) == DialogResult.Yes)
                {
                    Process.Start(_save.FileName + ".png");
                }
            }

        }

        private void pictureAutorizado_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (pictureAutorizado.Image == null)
            {
                return;
            }

            if (me.Button == MouseButtons.Right)
            {
                SaveFileDialog _save = new SaveFileDialog();

                _save.ShowDialog();

                Image image = pictureAutorizado.Image;

                if (File.Exists(_save.FileName + ".png"))
                {
                    File.Delete(_save.FileName + ".png");
                }

                image.Save(_save.FileName + ".png");

                if (Mensagem(this, "Imagem gerada com sucesso, deseja abrir a imagem ?", CMsgBox.TipoBotoes.SimNao, CMsgBox.TipoErro.Informacao) == DialogResult.Yes)
                {
                    Process.Start(_save.FileName + ".png");
                }


            }

        }

        private void btnConsultaAntecedentes_Click(object sender, EventArgs e)
        {

            try
            {

                //Stopwatch relogio = new Stopwatch();

                //SHDocVw.InternetExplorer IE = new SHDocVw.InternetExplorer();

                //IE.Visible = true;
                //IE.Navigate2("http://www2.ssp.sp.gov.br/atestado/novo/Atestado02.cfm");

                //while (IE.ReadyState != SHDocVw.tagREADYSTATE.READYSTATE_COMPLETE)
                //{
                //    System.Windows.Forms.Application.DoEvents();
                //}

                //var documento = IE.Document;

                //var aa = ((IHTMLDocument3)documento);

                //aa.getElementsByName("Nome").item(0).setAttribute("value", txtNome.Text);
                //if (cmbSexo.SelectedValue.ToString() == "1")
                //{
                //    aa.getElementsByName("Sexo").item(0).setAttribute("value", "M");
                //}
                //else
                //{
                //    aa.getElementsByName("Sexo").item(0).setAttribute("value", "F");
                //}

                //aa.getElementsByName("Numero").item(0).setAttribute("value", txtRG.Text.Substring(0, txtRG.Text.Length - 1));
                //aa.getElementsByName("digito").item(0).setAttribute("value", txtRG.Text.Substring(txtRG.Text.Length - 1, 1));


                //aa.getElementsByName("txtDIAE").item(0).setAttribute("value", Convert.ToDateTime(txtDataExpedicao.Text).ToString("dd"));
                //aa.getElementsByName("txtMESE").item(0).setAttribute("value", Convert.ToDateTime(txtDataExpedicao.Text).ToString("MM"));
                //aa.getElementsByName("txtANOE").item(0).setAttribute("value", Convert.ToDateTime(txtDataExpedicao.Text).ToString("yyyy"));


                //aa.getElementsByName("txtDIA").item(0).setAttribute("value", Convert.ToDateTime(txtDataNascimento.Text).ToString("dd"));
                //aa.getElementsByName("txtMES").item(0).setAttribute("value", Convert.ToDateTime(txtDataNascimento.Text).ToString("MM"));
                //aa.getElementsByName("txtANO").item(0).setAttribute("value", Convert.ToDateTime(txtDataNascimento.Text).ToString("yyyy"));
                //aa.getElementsByName("NomeMae").item(0).setAttribute("value", txtNomeMae.Text);
                //aa.getElementsByName("NomePai").item(0).setAttribute("value", txtNomePai.Text);
                //aa.getElementById("pesquisa").click();


                ////while (IE.ReadyState != SHDocVw.tagREADYSTATE.READYSTATE_COMPLETE)
                ////{
                ////    Application.DoEvents();
                ////}

                //relogio.Start();
                //while (relogio.ElapsedMilliseconds < 5000)
                //{
                //    System.Windows.Forms.Application.DoEvents();
                //}

                //relogio.Stop();

                //IE.ExecWB(SHDocVw.OLECMDID.OLECMDID_PRINT, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER, 2);



            }
            catch (Exception)
            {

                throw;
            }





        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void imgLimpar_Click(object sender, EventArgs e)
        {
            LimpaCamposFiltro();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmDocumentos documentos = new frmDocumentos();

            documentos.idCLienteLocacao = idClienteLocacao;

            documentos.ShowDialog();
        }

        private void btnImprimirContrato_CLick(object sender, EventArgs e)
        {

            try
            {
                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();

                if (File.Exists("C:\\temp\\contrato2.docx"))
                {
                    File.Delete("C:\\temp\\contrato2.docx");
                }

                if (File.Exists("C:\\temp\\contratofinal2.docx"))
                {
                    File.Delete("C:\\temp\\contratofinal2.docx");
                }


                File.Copy(AppDomain.CurrentDomain.BaseDirectory + "Documentos\\CONTRATO.docx", "C:\\temp\\contrato2.docx");


                Document doc = app.Documents.Open("C:\\temp\\contrato2.docx");

                doc.Content.Find.Execute(FindText: "{NOMEDOCLIENTELOCACAO}", ReplaceWith: txtNome.Text);
                doc.SaveAs2("C:\\temp\\contratofinal2.docx");

                doc.Close();

                Process.Start("C:\\temp\\contratofinal2.docx");
            }
            catch (Exception)
            {

                throw;
            }

        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    frmImpressao frm = new frmImpressao();

        //    frm.ShowDialog();

        //}
    }
}

