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

        public void CarregaCombo(List<object> objetos,string id, string value, PrimeiraLinha _primeira )
        {


            int iContador = 0;

            try
            {

                DataTable table = new DataTable();

                table.Columns.Add("cCidade");
                table.Columns.Add("rCidade");





                foreach (var item in objetos)
                {
                    if (_primeira != PrimeiraLinha.Nenhum)
                    {
                        if (iContador == 0)
                        {
                            table.Rows.Add("0", "Selecione");
                        }
                    }

                    //table.Rows.Add(objetos.);


                    iContador += 1;
                }

                this.DataSource = table;
                this.ValueMember = "cCidade";
                this.DisplayMember = "rCidade";


            }
            catch (Exception)
            {

                throw;
            }
        

    }
}
}
