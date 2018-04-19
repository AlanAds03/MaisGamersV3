using MaisGamers.DLL.Orcamento;
using MaisGamers.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmVisualizaFoto : Form
    {
        public int id;
        public frmVisualizaFoto()
        {
            InitializeComponent();
           
        }


        private void CarregarFotos(int id)
        {

            List<Byte[]> lista = new List<byte[]>();

            try
            {

                bFotosOrcamento _fotos = new bFotosOrcamento();

                lista  = _fotos.BuscarFotos(id);

                if (lista.Count == 0)
                {
                    return;
                }

                foreach (byte[] _byte in lista)
                {
                    PictureBox picture1 = new PictureBox();
                    Random rando = new Random(999999999);
                    pnlFotos.AutoScrollPosition = new Point(0, 0);

                    picture1.Height = 680;
                    picture1.Width = 300;
                    picture1.SizeMode = PictureBoxSizeMode.StretchImage;

                    MemoryStream ms = new MemoryStream(_byte, 0, _byte.Length);
                    ms.Write(_byte, 0, _byte.Length);
                   
                    picture1.Image = Image.FromStream(ms, true);//Exception occurs here
                    picture1.Name = rando.Next().ToString();
                    picture1.Location = new Point(posicao, 0);
                    picture1.Click += Picture1_Click;

                    posicao += 300;

                    pnlFotos.Controls.Add(picture1);
                }

            }
            catch (Exception)
            {

                throw;
            }
            

        }

        private void Picture1_Click(object sender, EventArgs e)
        {
            Random ran = new Random(99999999);
            string nomeArquivo = "";
            try
            {

                nomeArquivo = ran.Next().ToString() + ".jpeg";

                ((PictureBox)sender).Image.Save(@"C:\Temp\" + nomeArquivo, ImageFormat.Jpeg);
                Process.Start(@"C:\Temp\" + nomeArquivo);

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private int m_Width = 800;
        private int m_Height = 800;
        private int posicao = 0;
        public List<Byte[]> fotos = new List<byte[]>();


        // Altura e largura da imagem gerada pela WebCam

        //Handle da janela de controle da webcam.
        private int mCapHwnd;

        //Flag para verificar se webcam foi parada.
        private bool bStopped = true;


        //Abaixo temos todas as chamadas das APIs do Sistema Operacional Windows
        //Essas chamadas fazem a interface do nosso controle com a WebCam e e com o SO.
        #region API Declarations

        //Esta chamada é uma das mais importantes e é vital para o funcionamento do SO.
        [DllImport("user32", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        //Esta API cria a instancia da webcam para que possamos acessa-la.
        [DllImport("avicap32.dll", EntryPoint = "capCreateCaptureWindowA")]
        public static extern int capCreateCaptureWindowA(string lpszWindowName, int dwStyle, int X, int Y, int nWidth, int nHeight, int hwndParent, int nID);

        //Esta API abre a área de transferência para que possamos buscar os dados da webcam.
        [DllImport("user32", EntryPoint = "OpenClipboard")]
        public static extern int OpenClipboard(int hWnd);

        //Esta API limpa a área de transferência.
        [DllImport("user32", EntryPoint = "EmptyClipboard")]
        public static extern int EmptyClipboard();

        //Esta API fecha a área de transferência após utilização.
        [DllImport("user32", EntryPoint = "CloseClipboard")]
        public static extern int CloseClipboard();

        //Esta API recupera os dados da área de transferência para utilização.
        [DllImport("user32.dll")]
        extern static IntPtr GetClipboardData(uint uFormat);

        #endregion

        #region API Constants

        public const int WM_USER = 1024;

        public const int WM_CAP_CONNECT = 1034;
        public const int WM_CAP_DISCONNECT = 1035;
        public const int WM_CAP_GET_FRAME = 1084;
        public const int WM_CAP_COPY = 1054;

        public const int WM_CAP_START = WM_USER;

        public const int WM_CAP_DLG_VIDEOFORMAT = WM_CAP_START + 41;
        public const int WM_CAP_DLG_VIDEOSOURCE = WM_CAP_START + 42;
        public const int WM_CAP_DLG_VIDEODISPLAY = WM_CAP_START + 43;
        public const int WM_CAP_GET_VIDEOFORMAT = WM_CAP_START + 44;
        public const int WM_CAP_SET_VIDEOFORMAT = WM_CAP_START + 45;
        public const int WM_CAP_DLG_VIDEOCOMPRESSION = WM_CAP_START + 46;
        public const int WM_CAP_SET_PREVIEW = WM_CAP_START + 50;

        #endregion



        

        //private void ImageSize()
        //{
        //    m_Width = pictureBox1.Size.Width;
        //    m_Height = pictureBox1.Size.Height;
        //}

        /// <summary>
        /// 
        /// </summary>
        public void Stop()
        {
            try
            {
                // stop the timer
                bStopped = true;
                this.timer1.Stop();

                // Liberamos recurso ao sistema operacional.
                Application.DoEvents();

                //Envia mensagem ao SO para desconectar a Webcam.
                SendMessage(mCapHwnd, WM_CAP_DISCONNECT, 0, 0);

                //Fecha a área de transferência.
                CloseClipboard();
            }

            catch (Exception excep)
            { // Não dispara nenhum erro.
            }

        }


       
       

        private void frmFoto_Load(object sender, EventArgs e)
        {
            pnlFotos.Width = Screen.PrimaryScreen.Bounds.Width - 100;
            pnlFotos.HorizontalScroll.Enabled = true;
            pnlFotos.AutoSize = false;

            CarregarFotos(id);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            foreach (Control xx in pnlFotos.Controls)
            {

                if (((PictureBox)xx).Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        ((PictureBox)xx).Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        fotos.Add(ms.ToArray());
                    }
                
                
                }
                
            }

            this.Close();
        }
    }
}
