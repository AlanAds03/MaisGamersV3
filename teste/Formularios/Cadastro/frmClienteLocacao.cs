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
using static MaisGamers.Modulos.util;

namespace MaisGamers.Formularios.Cadastro
{

    
    public partial class frmClienteLocacao : Form
    {

        public ModoTela modo_tela;



        public frmClienteLocacao()
        {
            InitializeComponent();
        }

        private void frmClienteLocacao_Load(object sender, EventArgs e)
        {
           util.CentralizaGrupo(grpPesquisa);
            util.CentralizaGrupo(grpBotoes);
            util.CentralizaGrupo(grpGrid);
            util.CentralizaGrupo(grpCadastra);
            util.CentralizaTab(tbControl);

            modo_tela = ModoTela.CONSULTA;

            atualizaTela();

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

            }
            else if (modo_tela == ModoTela.NOVO)
            {
                tbControl.SelectTab("tpDetalhe");
                btnFechar.Text = "Voltar";
                btnSalvar.Enabled = true;
                btnNovo.Enabled = false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            if(modo_tela == ModoTela.CONSULTA)
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
    }
}
