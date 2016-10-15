using MaisGamers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL
{
    public class dEstado
    {
        
        public List<mEstado> CarregaEstado()
        {

            var db = new Contexto();
            try
            {
                return db.Estado.ToList();

            }
            catch (Exception ex)
            {

                return null;
            }

        }
    }
}
