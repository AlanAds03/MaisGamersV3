using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frameworks.Componentes
{
    public class SuperTextBox : System.Windows.Forms.TextBox
    {
        public bool CampoObrigatorio { get; set; }
        private ErrorProvider provider = new ErrorProvider();

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SuperTextBox
            // 
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeLayout(false);



        }

        protected override void OnLeave(EventArgs e)
        {

            
            if (CampoObrigatorio == false)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.Text))
            {
                provider.SetError(this, "Informar o nome");
            }
            else
            {
                provider.SetError(this, string.Empty);
                provider.Dispose();

            }




        }
    }
}
