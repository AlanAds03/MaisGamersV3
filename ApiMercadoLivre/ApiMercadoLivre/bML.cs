using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MercadoLibre.SDK;
using System.Windows.Forms;

namespace ApiMercadoLivre
{
   
    public class bML
    {

        public long AppID { get; set; }
        public string chave { get; set; }

        public WebBrowser Navegador { get; set; }
        public bML(long _appID, string _chave, ref WebBrowser _nav)
        {
            AppID = _appID;
            chave = _chave;
            Navegador = _nav;
        }


        public void Consulta()
        {

            Meli m = new Meli(AppID, chave);

            

            Navegador.Navigate(m.GetAuthUrl(Meli.AuthUrls.MLB, "https://www.google.com.br"));

            while (Navegador.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }

            Navegador.Document.GetElementById("user_id").InnerText = "alissonmaisgamers@gmail.com";
            Navegador.Document.GetElementById("password").InnerText = "qweasd2016";
            Navegador.Document.GetElementById("signInButton").InvokeMember("click");

            while (Navegador.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }



        }

    }
}
