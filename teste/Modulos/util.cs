using Frameworks.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Frameworks.Classes.CMsgBox;

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
    public static class Util
    {
        public static bool bLogaErro = true;


        public static void LogaErro(string mensagem)
        {
            string caminho = string.Empty;
            string nomeArquivo = string.Empty;
            StreamWriter arquivo = null;
            try
            {
                if (bLogaErro)
                {
                    caminho = Path.Combine(Environment.GetEnvironmentVariable("TEMP"), "MAISGAMERS_LOG");

                    nomeArquivo = @"\Log" + System.DateTime.Now.ToString("yyyyMMdd") + ".txt";


                    if (!Directory.Exists(caminho))
                    {
                        Directory.CreateDirectory(caminho);
                    }

                    arquivo = new StreamWriter(caminho + nomeArquivo, true);
                    arquivo.WriteLine(System.DateTime.Now.ToString("HH:mm:ss") + "-" + mensagem);
                    arquivo.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void  TratarErro(Exception ex)
        {
            string caminho = string.Empty;
            string nomeArquivo = string.Empty;
            StreamWriter arquivo = null;
            try
            {
                if (bLogaErro)
                {
                    caminho = Path.Combine(Environment.GetEnvironmentVariable("TEMP"), "MAISGAMERS_LOG");

                    nomeArquivo = @"\LogException" + System.DateTime.Now.ToString("yyyyMMdd") + ".txt";


                    if (!Directory.Exists(caminho))
                    {
                        Directory.CreateDirectory(caminho);
                    }

                    arquivo = new StreamWriter(caminho + nomeArquivo,true);
                    arquivo.WriteLine(System.DateTime.Now.ToString("hh:mm:ss") + "-" + ex.Message.ToString());
                    arquivo.Close();

                    Mensagem(null, ex.Message.ToString(), TipoBotoes.OK, TipoErro.Erro);

                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public enum TipoPagamento
        {
            DINHEIRO = 1,
            DEBITO = 2,
            CARTAO = 3,
            PARCELADO = 4
        }
        public enum ModoTela
        {
            CONSULTA = 1,
            ALTERACAO = 2,
            NOVO = 3


        }

        public static void CentralizaTab(System.Windows.Forms.TabControl tab, bool ignorarBotoes = true)
        {

            int width = 0;
            int height = 0;
            try
            {

                width = Screen.PrimaryScreen.Bounds.Width;
                height = Screen.PrimaryScreen.Bounds.Height;

                tab.Left = (width / 2 - tab.Width / 2) - 30;


                if (ignorarBotoes)
                {
                    if (height < 800)
                    {
                        tab.Height = height - 280;
                    }
                    else
                    {
                        tab.Height = height - 400;
                    }
                }
                else
                {
                    if (height < 800)
                    {
                        tab.Height = height - 200;
                    }
                    else
                    {
                        tab.Height = height - 320;
                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public static void CentralizaGrupo(System.Windows.Forms.GroupBox group, bool mudarPeloTamnho = true)
        {

            int width = 0;
            int height = 0;
            try
            {

                width = Screen.PrimaryScreen.Bounds.Width;
                height = Screen.PrimaryScreen.Bounds.Height;

                group.Left = width / 2 - group.Width / 2;

                if (mudarPeloTamnho == true)
                {


                    if (height < 800)
                    {
                        group.Top = height - 220;
                    }
                    else
                    {
                        group.Top = height - 300;
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }



        }

        public static bool isDate(string valor)
        {
            DateTime data = new DateTime();
            return DateTime.TryParse(valor, out data);
        }

        public static DialogResult Mensagem(Form form, string mensagem, TipoBotoes botoes, TipoErro tipoErro)
        {
            if (form != null)
            {
                form.Enabled = false;
            }

            CMsgBox cmsg = new CMsgBox(mensagem, botoes, tipoErro);
            cmsg.ShowDialog();

            if (form != null)
            {
                form.Enabled = true;
            }

            return cmsg.result;
        }



        public static bool IsNumeric(this string s)
        {
            float output;
            return float.TryParse(s, out output);
        }


        public static DateTime MinHoraData(DateTime dataAtual)
        {
            DateTime dataRetorno = new DateTime();
            try
            {
                return dataRetorno = new DateTime(dataAtual.Year, dataAtual.Month, dataAtual.Day);
            }
            catch (Exception)
            {

                return dataRetorno;
            }
        }
        public static EnderecoCEP RetornoCEP(string cep)
        {
            WebClient web = new WebClient();
            EnderecoCEP _endereco = new EnderecoCEP();

            try
            {

                if (string.IsNullOrEmpty(cep))
                {
                    return null;
                }

                web.Encoding = Encoding.UTF8;
                string retorno;
                List<string> listretorno = new List<string>();


                web.Headers.Add(HttpRequestHeader.ContentType, "application/json");

                retorno = web.DownloadString("https://viacep.com.br/ws/" + cep + "/json/");

                _endereco = Newtonsoft.Json.JsonConvert.DeserializeObject<EnderecoCEP>(retorno);


                return _endereco;
            }

            catch (Exception ex)
            {
                Mensagem(null, "CEP inválido ou não encontrado", TipoBotoes.OK, TipoErro.Erro);
                return null;


            }
        }

        public static void Imprimir(string arquivo)
        {
            try
            {

                ProcessStartInfo info = new ProcessStartInfo();
                info.Verb = "print";
                info.FileName = arquivo;
                info.Arguments = "\\Fiscal4\\";

                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;

                Process p = new Process();
                p.StartInfo = info;
                p.Start();

                p.WaitForInputIdle();
                System.Threading.Thread.Sleep(3000);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
