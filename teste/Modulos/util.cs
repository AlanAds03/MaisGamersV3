using Frameworks.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaisGamers.Modulos
{

    public class EnderecoCEP
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string unidade { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }

    }
    public class util
    {

        public enum ModoTela
        {
            CONSULTA = 1,
            ALTERACAO = 2,
            NOVO = 3 
            

        }

        public static void CentralizaTab(System.Windows.Forms.TabControl tab)
        {

            int width = 0;
            int height = 0;
            try
            {

                width = Screen.PrimaryScreen.Bounds.Width;
                height = Screen.PrimaryScreen.Bounds.Height;

                tab.Left = width / 2 - tab.Width / 2;
                tab.Height = height - 400;

            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public static void CentralizaGrupo(System.Windows.Forms.GroupBox group)
        {

            int width = 0;
            int height = 0;
            try
            {

                width = Screen.PrimaryScreen.Bounds.Width;
                height = Screen.PrimaryScreen.Bounds.Height;

                group.Left = width / 2 - group.Width / 2;
                group.Top = height - 300;
            }
            catch (Exception ex)
            {

                throw;
            }



        }

        public static bool isDate(string valor)
        {
            DateTime data = new DateTime();
            return DateTime.TryParse(valor,out data);
        }

        public static DialogResult Mensagem(string mensagem)
        {
            CMsgBox cmsg = new CMsgBox(mensagem);
            cmsg.ShowDialog();

            return cmsg.result;
        }


        public static  EnderecoCEP RetornoCEP(string cep)
        {
            WebClient web = new WebClient();

            web.Encoding = Encoding.UTF8;
            string retorno;
            List<string> listretorno = new List<string>();
            EnderecoCEP _endereco = new EnderecoCEP();

            web.Headers.Add(HttpRequestHeader.ContentType, "application/json");

            retorno = web.DownloadString("https://viacep.com.br/ws/" + cep + "/json/");

            _endereco = Newtonsoft.Json.JsonConvert.DeserializeObject<EnderecoCEP>(retorno);



            return _endereco;
        }


    }
}
