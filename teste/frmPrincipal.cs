using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlMenuCadastro.Visible = false;
            pnlMenuLocacao.Visible = false;
            CentralizaMenus();
        }

        private void CentralizaMenus()
        {
            pnlMenuCadastro.Top = 24;
            pnlMenuLocacao.Top = 24;
            pnlMenuCadastro.Width = menuStrip1.Width;
            pnlMenuLocacao.Width = menuStrip1.Width;

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMenuCadastro.Visible = true;
            pnlMenuLocacao.Visible = false;
        }

        private void locacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMenuCadastro.Visible = false;
            pnlMenuLocacao.Visible = true;
        }

        private void pnlMenuCadastro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cliquei");
        }

        private void pnlMenuLocacao_Paint(object sender, PaintEventArgs e)
        {

        }

      

      
        private void pnlIcone1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            this.Cursor = Cursors.Hand;
        }

        private void pnlIcone1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;
            this.Cursor = Cursors.Default;
        }
        

        


    }
}
