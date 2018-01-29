using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frameworks.Componentes
{
    public partial class SuperPictureBox : PictureBox
    {

        public string Mensagem { get; set; }

        public  bool CampoObrigatorio { get; set; }


        public SuperPictureBox()
        {
            InitializeComponent();

            
        }

        public SuperPictureBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void SuperPictureBox_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;

            this.BackColor = System.Drawing.Color.White;

            if(Mensagem != "")
            {
                ToolTip tooltip = new ToolTip();


                tooltip.SetToolTip(this, Mensagem);
            }
            

        }

        private void SuperPictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;

            this.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
