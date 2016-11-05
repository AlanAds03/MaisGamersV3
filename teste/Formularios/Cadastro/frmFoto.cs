using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaisGamers.Formularios.Cadastro
{
    public partial class frmFoto : Form
    {
        public frmFoto()
        {
            InitializeComponent();
            Start();
        }

        private int m_Width = 500;
        private int m_Height = 500;


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



        public void Start()
        {
            try
            {
                //Ajusta o tamanho da imagem.
                ImageSize();

                // Por segurança, chamamos o método stop so para garantirmos que não estamos rodando o código.
                this.Stop();

                // Criamos a janela de captura usando a API "capCreateCaptureWindowA"
                mCapHwnd = capCreateCaptureWindowA("WebCap", 0, 0, 0, m_Width, m_Height, this.Handle.ToInt32(), 0);

                // Liberamos recurso ao sistema operacional.
                Application.DoEvents();

                //Enviamos a mensagem através do SO para conectar com o driver da WebCam.
                SendMessage(mCapHwnd, WM_CAP_CONNECT, 0, 0);
                SendMessage(mCapHwnd, WM_CAP_CONNECT, 0, 0);
                SendMessage(mCapHwnd, WM_CAP_CONNECT, 0, 0);

                // Ajustamos o intervalo de captura da webcam.
                // Podemos aqui criar uma propriedade do componente para 
                // alterarmos o tempo. Lembrando que quanto maior o tempo 
                // maior o atraso entre o capturado e o exibido.
                this.timer1.Interval = 1;
                this.timer1.Tick += timer1_Tick;
                bStopped = false;
                this.timer1.Start();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Ocorreu um erro na exibição da WebCam. Verifique se está tudo conectado.\r\n\n" + excep.Message);
                this.Stop();
            }
        }

        private void ImageSize()
        {
            m_Width = pictureBox1.Size.Width;
            m_Height = pictureBox1.Size.Height;
        }

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


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // Pausa o temporizador
                this.timer1.Stop();

                //Ajusta o tamanho da imagem.
                //ImageSize();

                // Envia ao SO a mensagem para capturar o próximo frame.
                SendMessage(mCapHwnd, WM_CAP_GET_FRAME, 0, 0);

                // copia o frame capturado para a área de transferência.
                SendMessage(mCapHwnd, WM_CAP_COPY, 0, 0);

                /*//Abre a área de transferência.
                OpenClipboard(mCapHwnd);

                //Busca os dados da área de transferÊncia, colocando os dados em 
                //uma estrutura de ponteiro.
                IntPtr img = GetClipboardData(2);

                //Fecha a área de transferÊncia.
                CloseClipboard();

                //Criamos aqui um objeto do tipo Bitmap.
                System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(m_Width, m_Height);

                //Criamos um objeto gráfico para manipular nossa imagem.
                System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bmp);

                //Ajustamos algumas propriedades do nosso objeto gráfico.
                //No caso abaixo, estou tentanto otimizar ao máximo a velocidade.
                //Mas também a possível ajustar para a qualidade da imagem.
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;

                //Pegamos a imagem que está na estrutura do ponteiro que buscamos da 
                //área de transferÊncia e carregamos dentro do nosso bitmap.
                g.DrawImage(Image.FromHbitmap(img), 0, 0, m_Width, m_Height);*/

                // Captura o objeto do clipboard.
                IDataObject tempObj = Clipboard.GetDataObject();

                // Converte o objeto para Bitmap.
                Image tempImg = (System.Drawing.Bitmap)tempObj.GetData(System.Windows.Forms.DataFormats.Bitmap);

                //Exibimos o frame da Webcam no controle que adicionamos no formulário
                //o frame foi salvo na variável do tipo Bitmap
                //e será exibido no controle System.Windows.Forms.PictureBox abaixo.
                pictureBox1.Image = tempImg;

                //fazemos um refresh na imagem.
                pictureBox1.Refresh();

                // Liberamos recurso ao sistema operacional.
                Application.DoEvents();

                if (!bStopped)
                    this.timer1.Start();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Ocorreu um erro na exibição da WebCam. Verifique se está tudo conectado.\r\n\n" + excep);
                this.Stop(); // stop the process
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image image = pictureBox1.Image;

            image.Save(@"C:\Users\Supremo MaisGamers\Documents\Fax\aa.jpg");
            Stop();
            this.Close();
        }
    }
}
