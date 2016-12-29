using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Frameworks.Componentes
{
    public class SuperTextBox : System.Windows.Forms.TextBox
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SuperTextBox
            // 
            this.FontHeight = 30;
            this.ResumeLayout(false);

        }
    }
}
