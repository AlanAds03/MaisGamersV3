using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Awesomium;
using Awesomium.Core;
using Awesomium.Core.Data;
using MercadoLibre.SDK;

namespace ApiMercadoLivre
{
    public partial class Form1 : Form
    {

        bool carregou = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void ThreadBrowserOK()
        {

            while (carregou == false)
            {
                Application.DoEvents();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webControl1.Width = 1080;
            webControl1.Height = 700;

            Thread ThreadBro = new Thread(new ThreadStart(ThreadBrowserOK));

            Meli m = new Meli(6147823448647088, "5W8zJzU8KzmBUGNzuxnmk45BevoTpnHx");

            webControl1.Source = new Uri(m.GetAuthUrl(Meli.AuthUrls.MLB, "https://www.google.com.br"));

            webControl1.DocumentReady += _documentReady;

           

            // while (true)
            //{
            //    Application.DoEvents();
            //}


            //Navegador.Navigate(m.GetAuthUrl(Meli.AuthUrls.MLB, "https://www.google.com.br"));

            //while (Navegador.ReadyState != WebBrowserReadyState.Complete)
            //{
            //    Application.DoEvents();
            //}

            //Navegador.Document.GetElementById("user_id").InnerText = "alissonmaisgamers@gmail.com";
            //Navegador.Document.GetElementById("password").InnerText = "qweasd2016";
            //Navegador.Document.GetElementById("signInButton").InvokeMember("click");

            //while (Navegador.ReadyState != WebBrowserReadyState.Complete)
            //{
            //    Application.DoEvents();
            //}




            /*bML b = new bML(6147823448647088, "5W8zJzU8KzmBUGNzuxnmk45BevoTpnHx", ref webBrowser1);

        b.Consulta();*/
        }

        private void _documentReady(object sender, DocumentReadyEventArgs e)
        {

            try
            {
                dynamic document = (Awesomium.Core.JSObject)webControl1.ExecuteJavascriptWithResult("document");

                JSObject a = document.getElementByID("user_id").value = "44";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
          
            

        }

        private void LoadingFrameComplete(object sender, FrameEventArgs e)
        {

            while (true)
            {
                if (webControl1 == null || !webControl1.IsLive ||
                     webControl1.ParentView != null ||  e.IsMainFrame)
                {
                    MessageBox.Show("true");
                    carregou = true;
                    return;
                }

                Application.DoEvents();


            }
        }
    }
}
