using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.Componentes
{
    public class SuperComboBox : System.Windows.Forms.ComboBox
    {
        public class rValor
        {
            public int cId { get; set; }
            public string rTexto { get; set; }
        }

        public enum PrimeiraLinha
        {
            Todos = 0,
            Selecione = 1,
            Nenhum = 2
        }

        public void CarregaCombo<T>(List<T> objetos, string id, string value, PrimeiraLinha _primeira)
        {


            int iContador = 0;

            try
            {

                DataTable table = new DataTable();

                table.Columns.Add(id);
                table.Columns.Add(value);





                foreach (var item in objetos)
                {


                    if (iContador == 0)
                    {


                        if (_primeira == PrimeiraLinha.Todos)
                        {
                            table.Rows.Add("0", "Todos");

                        }
                        else if (_primeira == PrimeiraLinha.Selecione)
                        {

                            table.Rows.Add("0", "Selecione");
                        }
                    }

                    iContador += 1;

                    if (iContador != 0)
                    {
                        table.Rows.Add(item.GetType().GetProperty(id).GetValue(item), item.GetType().GetProperty(value).GetValue(item));
                    }

                }


                this.DataSource = table;
                this.ValueMember = id;
                this.DisplayMember = value;


            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
