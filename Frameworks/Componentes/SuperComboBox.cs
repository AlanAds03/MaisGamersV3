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
        public bool CampoObrigatorio { get; set; }
        public class rValor
        {
            public int cId { get; set; }
            public string rTexto { get; set; }
        }

        public bool Carregado { get; set; }

        public enum PrimeiraLinha
        {
            Todos = 0,
            Selecione = 1,
            Nenhum = 2
        }

        public void CarregaCombo<T>(List<T> objetos, string id, string value, PrimeiraLinha _primeira)
        {

            Carregado = false; 

            int iContador = 0;

            try
            {

                DataTable table = new DataTable();

                table.Columns.Add(id);
                table.Columns.Add(value);

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

                foreach (var item in objetos)
                {


                    iContador += 1;

                    if (iContador != 0)
                    {
                        table.Rows.Add(item.GetType().GetProperty(id).GetValue(item), item.GetType().GetProperty(value).GetValue(item));
                    }

                }


                this.DataSource = table;
                this.ValueMember = id;
                this.DisplayMember = value;

                Carregado = true;

                if(Items.Count > 0)
                {
                    this.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public void CarregaCombo(Dictionary<String,String> objetos, string id, string value, PrimeiraLinha _primeira)
        {

            Carregado = false;

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
                        table.Rows.Add(item.Key, item.Value);
                    }

                }


                this.DataSource = table;
                this.ValueMember = id;
                this.DisplayMember = value;



                Carregado = true;
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        public void ResetarValores()
        {
            if (this.Items.Count > 0)
            {
                this.SelectedIndex = 0;
            }
            
        }
        public string ObterValor()
        {
            string a = "";

            try
            {
               
                a = this.SelectedValue.ToString();

                return a;

            }
            catch (Exception)
            {

                return "";
            }
           
        }

    }
}
