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

            List<T> _list = new List<T>();

            var serializer = new JavaScriptSerializer ();
            _list = serializer.Deserialize<List<T>>(json);



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
    }
}
