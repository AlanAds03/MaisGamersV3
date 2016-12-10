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

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmCadJogo : Form
    {
        public util.ModoTela modo_tela;

        public frmCadJogo()
        {
            InitializeComponent();
        }

        private void frmCadJogo_Load(object sender, EventArgs e)
        {
            util.CentralizaGrupo(grpBotoes);
            util.CentralizaTab(tabControl1);

            CarregaComboConsole(cmbConsolePesquisa);
            CarregaComboConsole(cmbConsole);
        }

        private void CarregaComboConsole(SuperComboBox combo)
        {
            try
            {
                using (var bConsole = new bConsole())
                {
                    List<mConsole> console = new List<mConsole>();

                    console = bConsole.CarregaConsole();
                    combo.CarregaCombo(console, "idConsole", "NomeConsole", Frameworks.Componentes.SuperComboBox.PrimeiraLinha.Selecione);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            modo_tela = util.ModoTela.NOVO;
            atualizaTela();
        }


        private void atualizaTela()
        {
            if (modo_tela == util.ModoTela.CONSULTA)
            {
                tabControl1.SelectTab("tpPesquisa");
                btnFechar.Text = "Fechar";
            }
            else if (modo_tela == util.ModoTela.NOVO)
            {
                LimpaCampos();
                tabControl1.SelectTab("tpCadastro");
                btnFechar.Text = "Voltar";

            }
        }

        private void LimpaCampos()
        {
            txtNome.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            cmbConsole.SelectedValue = "";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (modo_tela == util.ModoTela.CONSULTA)
            {
                this.Close();
                this.Dispose();
            }
            else
            {
                modo_tela = util.ModoTela.CONSULTA;
                atualizaTela();
            }
        }
    }
}
