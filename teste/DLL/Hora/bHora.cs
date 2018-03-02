using MaisGamers.DAL.Hora;
using MaisGamers.Model.Hora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Hora
{
    public class bHora
    {

        public List<mHora> CarregarHora(int idConsole)
        {

            try
            {
                dHora _dHora = new dHora();


                return _dHora.CarregarHora(idConsole);

            }
            catch (Exception ex)
            {
                return null;
            }

        }
        

    }
}
