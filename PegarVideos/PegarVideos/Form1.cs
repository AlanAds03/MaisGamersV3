using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegarVideos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtArquivo.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string linha = "";
            List<string> links = new List<string>();


            try
            {
                if (string.IsNullOrEmpty(txtArquivo.Text))
                {
                    return;
                }


                StreamReader reader = new StreamReader(txtArquivo.Text);

                while (reader.Peek() >= 0)
                {
                    linha = reader.ReadLine();

                    if (linha.Contains("/watch?"))
                    {
                        string index = "";
                        int intindex = 0;
                        index =  linha.Substring(linha.IndexOf("index", 0), linha.IndexOf("&amp;", linha.IndexOf("index", 0)) - linha.IndexOf("index", 0));

                        //intindex = index.Substring(index.IndexOf("=", 0), linha.IndexOf("index", 0) - linha.Length);





                        links.Add(linha.Substring(linha.IndexOf("watch?"), linha.IndexOf("&amp;", linha.IndexOf("watch?")) - linha.IndexOf("watch?")) + "&amp;list=PLmH_OP35i-xy11lO6Af95YtBTPqz3QNXV");

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
