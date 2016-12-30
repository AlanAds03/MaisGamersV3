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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeLayout(false);

        }
    }
}
