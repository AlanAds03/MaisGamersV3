using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace Frameworks.Componentes
{
    public class SuperLV : ListView
    {
        private int Chave { get; set; }

        public void CarregaListaView<T>(List<T> _list)
        {

            Int32 iCont = 0;

            foreach (var x in _list)
            {
                Type tipo = x.GetType();
                PropertyInfo[] props = tipo.GetProperties();
                foreach (var pro in props)
                {
                    this.Columns.Add(pro.Name);
                }

            }

            ListViewItem item = new ListViewItem();


            foreach (var x in _list)
            {
                Type tipo = x.GetType();
                PropertyInfo[] props = tipo.GetProperties();

                foreach (var pro in props)
                {
                    var valor = pro.GetValue(x, null);



                    if (pro.Name.Contains("id"))
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

            }


            this.Items.Add(item);

            this.CheckBoxes = true;
            this.View = View.Details;




        }


        public void CarregaListaView<T>(string json)
        {

            this.Items.Clear();

            //List<Object> _list = new List<Object>();
            List<T> _list = new List<T>();
            var serializer = new JavaScriptSerializer();
            _list = serializer.Deserialize<List<T>>(json);

            Int32 iCont = 0;

            for (int i = 0; i < 1; i++)
            {
                Type tipo =  _list[i].GetType();
                PropertyInfo[] props = tipo.GetProperties();
                foreach (var pro in props)
                {
                    var valor = pro.GetValue(_list[i], null);
                    if (valor != null)
                    {
                        this.Columns.Add(pro.Name);
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

                    if (pro.Name.Substring(0,2)== "id")
                    {
                        this.Chave = Convert.ToInt32(valor);
                    }

                    //var atri = pro.GetCustomAttribute(true);


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



        public int ObterChave()
        {
            for(var i = 0; i<= this.Items.Count - 1; i++)
            {
                if(this.Items[i].Checked == true)
                {
                    return Convert.ToInt32(this.Items[i].Text);
                }
            }

            return 0;
            
        }
    }
}
