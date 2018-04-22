using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Frameworks.Componentes
{
    public class SuperLV : ListView
    {
        public bool lstViewSort = false;

        private int Chave { get; set; }
        private string  ChaveComposta { get; set; }

        public void CarregaListaView<T>(List<T> _list)
        {

            Int32 iCont = 0;
            this.Items.Clear();
            this.Columns.Clear();
            string colunasArray = "";
            Char delimit = ';';
            string colunaRenomeada = "";
            int tamanhoColuna = 0;

            //this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            foreach (var x in _list)
            {
                Type tipo = x.GetType();
                PropertyInfo[] props = tipo.GetProperties();

                foreach (var pro in props)
                {
                    if (pro.Name.ToUpper() == "COLUNASGRID")
                    {
                        colunasArray = pro.GetValue(x, null).ToString();

                        string[] colunas = pro.GetValue(x, null).ToString().Split(delimit);

                        foreach (string colu in colunas)
                        {

                            if (string.IsNullOrEmpty(colu))
                            {
                                continue;
                            }
                            Type tipoaa = x.GetType();
                            PropertyInfo[] propsaa = tipo.GetProperties();



                            if (colu.Contains("|"))
                            {
                                string novaPro = colu.Substring(colu.IndexOf("[") + 1, colu.IndexOf("]") - colu.IndexOf("[") - 1);

                                string[] nw = novaPro.Split('|');

                                tamanhoColuna = Convert.ToInt32(nw[0]);
                                colunaRenomeada = Convert.ToString(nw[1]);


                            }

                            else
                            {
                                foreach (PropertyInfo info in propsaa.Where(u => u.Name == colu))
                                {

                                    if (info.Name == colu)
                                    {
                                        foreach (CustomAttributeData data in info.CustomAttributes)
                                        {
                                            if (data.AttributeType.Name == "DisplayAttribute")
                                            {
                                                foreach (CustomAttributeNamedArgument argumentos in data.NamedArguments)
                                                {
                                                    if (argumentos.MemberName == "ShortName")
                                                    {
                                                        tamanhoColuna = Convert.ToInt32(argumentos.TypedValue.Value.ToString());
                                                    }
                                                    if (argumentos.MemberName == "Description")
                                                    {
                                                        colunaRenomeada = argumentos.TypedValue.Value.ToString();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if(colu.Length >= 2)
                            {
                                if(colu.Substring(0,2).ToUpper().Contains("ID"))
                                {
                                    this.Columns.Add("").Width = 22;

                                    tamanhoColuna = 0;
                                    colunaRenomeada = string.Empty;
                                    continue;
                                }
                            }
                            
                           
                                if (string.IsNullOrEmpty(colunaRenomeada))
                                {
                                    this.Columns.Add(colu);
                                }
                                else
                                {
                                    if (tamanhoColuna != 0)
                                    {
                                        this.Columns.Add(colunaRenomeada).Width = tamanhoColuna;
                                    }
                                    else
                                    {
                                        this.Columns.Add(colunaRenomeada);
                                    }
                                }
                            

                            tamanhoColuna = 0;
                            colunaRenomeada = string.Empty;



                        }
                    }
                }
                break;
            }

            foreach (var x in _list)
            {
                Type tipo = x.GetType();
                string[] colunasx = colunasArray.Split(delimit);
                PropertyInfo[] props = tipo.GetProperties();

                iCont = 0;

                ListViewItem item = new ListViewItem();

                foreach (string col in colunasx)
                {
                    if (string.IsNullOrEmpty(col))
                    {
                        continue;
                    }


                    string nova = "";


                    if (col.Contains("["))
                    {
                        nova = col.Substring(0, col.IndexOf("["));
                    }
                    else
                    {
                        nova = col;
                    }
                    PropertyInfo a = props.Where(y => y.Name.ToUpper().ToString() == nova.ToUpper().ToString()).First();

                    var valor = a.GetValue(x, null);

                    if (a.Name.ToUpper().Contains("ID") && valor.ToString().Contains("|"))
                    {
                        this.ChaveComposta = valor.ToString();
                    }
                    else if(a.Name.ToUpper().Contains("ID"))
                    {
                        this.Chave = Convert.ToInt32(valor);
                    }



                    if (iCont == 0)
                    {
                        if (valor != null)
                        {
                            item.Text = valor.ToString();
                        }
                    }
                    else
                    {
                        if (valor != null)
                        {
                            item.SubItems.Add(valor.ToString());
                        }
                    }

                    iCont += 1;
                }

                this.Items.Add(item);
                
            }

            this.CheckBoxes = true;
            this.View = View.Details;

        }


        public void CarregaListaView<T>(string json)
        {

            this.Items.Clear();
            this.Columns.Clear();
            //List<Object> _list = new List<Object>();
            List<T> _list = new List<T>();
            var serializer = new JavaScriptSerializer();
            _list = serializer.Deserialize<List<T>>(json);


            // dynamic data = serializer.Deserialize(json, typeof(object));

            //Dictionary<string,string> data = serializer.Deserialize<Dictionary<string,string>> (json);

            //foreach (var i in data)
            //{
            //    //string column = i["NomeJogo"].to;
            //    //string value = i[]
            //}


            Int32 iCont = 0;

            if (_list.Count == 0)
            {
                return;
            }

            for (int i = 0; i < 1; i++)
            {
                Type tipo = _list[i].GetType();
                PropertyInfo[] props = tipo.GetProperties();
                foreach (var pro in props)
                {
                    var valor = pro.GetValue(_list[i], null);
                    if (valor != null)
                    {
                        if (valor.ToString() != "0")
                        {
                            if (pro.Name.Substring(0, 2) == "id")
                            {
                                this.Columns.Add("");
                            }
                            else
                            {
                                this.Columns.Add(pro.Name);
                            }
                        }

                    }

                }

            }

            foreach (var x in _list)
            {
                Type tipo = x.GetType();
                PropertyInfo[] props = tipo.GetProperties();

                ListViewItem item = new ListViewItem();
                iCont = 0;

                foreach (var pro in props)
                {
                    bool blnChave = false;

                    var valor = pro.GetValue(x, null);

                    if (pro.Name.Substring(0, 2) == "id")
                    {
                        this.Chave = Convert.ToInt32(valor);
                        this.Columns[0].Width = 10;
                    }

                    //var atri = pro.GetCustomAttribute(true);

                    if (pro.PropertyType.FullName == "System.DataTime")
                    {
                        valor = Convert.ToDateTime(valor).ToShortDateString();
                    }

                    if (iCont == 0)
                    {
                        if (valor != null)
                        {
                            item.Text = valor.ToString();
                        }

                    }
                    else
                    {
                        if (valor != null)
                        {
                            item.SubItems.Add(valor.ToString());
                        }
                    }

                    iCont += 1;

                }

                this.Items.Add(item);
            }




            this.CheckBoxes = true;
            this.View = View.Details;

            this.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);





        }



        public object ObterChave()
        {
            for (var i = 0; i <= this.Items.Count - 1; i++)
            {
                if (this.Items[i].Checked == true)
                {
                    return this.Items[i].Text;
                }
            }

            return 0;

        }

        public object ObterChaves(string limitador)
        {
            string listas = "";

            try
            {
                for (var i = 0; i <= this.Items.Count - 1; i++)
                {
                    if (this.Items[i].Checked == true)
                    {
                        listas += this.Items[i].Text + limitador;
                    }
                }

                return listas;


            }
            catch (Exception)
            {
                return null;
                
            }
           

        }

        public object ObterTodosRegistros(string limitador)
        {
            string listas = "";

            try
            {
                for (var i = 0; i <= this.Items.Count - 1; i++)
                {
                   
                        listas += this.Items[i].Text + limitador;
                    
                }

                return listas;


            }
            catch (Exception)
            {
                return null;

            }


        }

        protected override void OnColumnClick(ColumnClickEventArgs e)
        {
            if  (lstViewSort == false)
            {
                this.ListViewItemSorter = new ListViewItemComparer(e.Column,SortOrder.Ascending);
                lstViewSort = true;
            }
            else
            {
                this.ListViewItemSorter = new ListViewItemComparer(e.Column, SortOrder.Descending);
                lstViewSort = false;
            }
           
            this.Sort();
        }
        
    }


    class ListViewItemComparer : IComparer
    {
        public SortOrder Order = SortOrder.Ascending;
        public int Column;

        public ListViewItemComparer()
        {
            Column = 0;
        }
        public ListViewItemComparer(int column , SortOrder order)
        {
            Column = column;
            Order = order;
        }
        public int Compare(object x, object y)
        {
            int returnVal = String.Compare(((ListViewItem)x).SubItems[Column].Text,
            ((ListViewItem)y).SubItems[Column].Text);

            if (Order == SortOrder.Descending)
                return -returnVal;
            else
                return returnVal;
        }
    }

}
