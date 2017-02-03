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
using MaisGamers.DLL.Cadastro;
using MaisGamers.DLL.Cadastro.Cadastro;
using static MaisGamers.Modulos.util;
using MaisGamers.DLL.Locacao;
using MaisGamers.Model.Locacao;

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmDocumentos : Form
    {
        public util.ModoTela modo_tela = ModoTela.CONSULTA;
        public int idClienteLocacao;
        public int idLocacao;

        public frmDocumentos()
        {
            InitializeComponent();
        }

      

       

        




        private void atualizaTela()
        {
            if (modo_tela == util.ModoTela.CONSULTA)
            {
                tabControl1.SelectTab("tpPesquisa");
                btnFechar.Text = "Fechar";

                


            }
           
        }

        private void LimpaCampos()
        {
            
            
        }

        
    }
}
