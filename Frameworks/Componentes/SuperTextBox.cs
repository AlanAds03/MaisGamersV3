using Frameworks.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frameworks.Componentes
{
    public class SuperTextBox : System.Windows.Forms.TextBox
    {
        ErrorProvider error = new ErrorProvider();
        public enum eTipoTexto
        {

            NENHUM = 1,
            NUMERO = 2, 
            ALPHANUMERICO = 3
            
        }
        public bool CampoObrigatorio { get; set; }
        public string DescricaoObrigatorio { get; set; }

        public eTipoTexto? TipoTexto   { get; set; }
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

        protected override void OnLayout(LayoutEventArgs levent)
        {
            //if(TipoTexto == eTipoTexto.NUMERO)
            //{
            //    this.Text = "0";
            //}
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            var x = e.KeyChar.ToString();

            if (x == "\b")
            {
                e.Handled = false;
                return;
            }
            if (this.TipoTexto == eTipoTexto.NUMERO)
            {
                Regex regex = new Regex("^[0-9,.]*$");

                if (regex.IsMatch(x))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            
            
            base.OnKeyPress(e);
        }


        protected override void OnLeave(EventArgs e)
        {

            
            //if (CampoObrigatorio == false)
            //{
            //    return;
            //}

            //if (string.IsNullOrEmpty(this.Text))
            //{
            //    provider.SetError(this, "Informar o nome");
            //        provider.Dispose();
            //}
            //else
            //{
            //    provider.SetError(this, string.Empty);
            //    provider.Dispose();

            //}

            base.OnLeave(e);



        }

        protected override void OnValidating(CancelEventArgs e)
        {
            if (CampoObrigatorio == false)
            {
                base.OnValidating(e);
            }
            else
            {
                if (string.IsNullOrEmpty(this.Text))
                {
                    if (TipoTexto == eTipoTexto.NUMERO)
                    {
                        if (!UtilFramework.IsNumeric(this.Text))
                        {

                            error.SetError(this, "Informar um número");
                            e.Cancel = true;
                        }
                        else
                        {
                            error.SetError(this, null);
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(DescricaoObrigatorio))
                        {
                            error.SetError(this, "Campo obrigatorio");
                        }
                        else
                        {
                            error.SetError(this, DescricaoObrigatorio);
                        }

                        e.Cancel = true;
                    }
                   
                    
                    //e.Cancel = true;
                    //base.OnValidating(e);
                }
                else
                {
                    error.SetError(this, null);
                    e.Cancel = false;
                    
                }
            }

            base.OnValidating(e);

        }




    }
}
