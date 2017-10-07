using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaisGamers.Formularios
{
    public partial class frmNewPrincipal : Form
    {
        const int valorFInal = 193;
        const int valorInicial = 41;
        public frmNewPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (pnlMenu.Width == valorInicial)
            {


                for (int x = 0; x < valorFInal ; x++)
                {
                    pnlMenu.Width = valorInicial + x;
                    Thread.Sleep(2);
                }

            }
            else
            {
                for (int x = 0; x < 153; x++)
                {
                    pnlMenu.Width = valorFInal - x;
                    Thread.Sleep(2);
                }
            }

            
            
        }
    }
}
