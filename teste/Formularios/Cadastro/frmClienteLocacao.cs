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

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmClienteLocacao : Form
    {
        public frmClienteLocacao()
        {
            InitializeComponent();
        }

        private void frmClienteLocacao_Load(object sender, EventArgs e)
        {
           util.CentralizaGrupo(grpPesquisa);
            util.CentralizaGrupo(grpBotoes);
            

        }
    }
}
