using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frameworks.Modulos
{
    public class mImpressao
    {
        public FontStyle EstiloFonte { get; set; }
        public Font Fonte { get; set; }
        public string linha { get; set; }
        public Point posicao { get; set; }

        public Brush brush { get; set; }

    }

    public class ImpressaoTermica
    {
        List<mImpressao> linhas = new List<mImpressao>();

        public ImpressaoTermica(List<mImpressao> _linhas)
        {
            linhas = _linhas;
        }
    public  bool Imprimir()
    {

            try
            {
                PrintDialog dialog = new PrintDialog();
                PrintDocument printDoc = new PrintDocument();

                printDoc.PrintPage += PrintDoc_PrintPage;
                printDoc.DocumentName = "Print";
                printDoc.PrinterSettings.PrinterName = "POS-58";
                dialog.Document = printDoc;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
       

            return true;
    }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int tamanho = 10;
            Font f = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            Font f8 = new System.Drawing.Font("Arial", 8, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            PointF p = new PointF(10, tamanho);

            tamanho += 15;



            string linha = "";
            string linha2 = "";
            foreach (mImpressao imp in linhas)
            {
                if (imp.linha.Length > 25)
                {
                    linha = imp.linha.Substring(0, 25);
                    linha2 = imp.linha.Substring(25, imp.linha.Length - 25);
                    e.Graphics.DrawString(linha, imp.Fonte, imp.brush, new Point(imp.posicao.X, tamanho));
                    tamanho += 25;
                    e.Graphics.DrawString(linha2, imp.Fonte, imp.brush, new Point(imp.posicao.X, tamanho));
                }
                else
                {
                    e.Graphics.DrawString(imp.linha, imp.Fonte, imp.brush, new Point(imp.posicao.X, tamanho));
                }
                
                tamanho += 15;
            }
            
            //e.Graphics.DrawString("Cliente: Alan Aragão Lima", f8, b, new PointF(0, tamanho));
            
            //e.Graphics.DrawString("Telefone:11-952418716", f8, b, new PointF(0, tamanho));
            //tamanho += 15;
            //e.Graphics.DrawString("Produto:PS4 Slim", f8, b, new PointF(0, tamanho));
            //tamanho += 15;
            //e.Graphics.DrawString("Defeito:Não dá imagem", f8, b, new PointF(0, tamanho));

        }
    }
}


