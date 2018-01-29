using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frameworks.Componentes
{
    public class SuperTextBox : System.Windows.Forms.TextBox
    {
        public enum eTipoTexto
        {

            NENHUM = 1,
            NUMERO = 2, 
            ALPHANUMERICO = 3
            
        }
        public bool CampoObrigatorio { get; set; }
        private ErrorProvider provider = new ErrorProvider();
        


        private void InitializeComponent()
        {
           
            // 
            // SuperTextBox
            // 
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            this.ResumeLayout(false);
            this.SuspendLayout();

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
