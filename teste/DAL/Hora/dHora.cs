using MaisGamers.Model;
using MaisGamers.Model.Hora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL.Hora
{
    public class dHora
    {

        public List<mHora> CarregarHora(int idConsole)
        {

            using (var db = new Contexto())
            {

                var lista = (from p in db.Hora where p.Console.IDConsole == idConsole select p).ToList();

                return lista.ToList();

            }

        }
    }
}
