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

        public decimal ConsultaUF(string _uf)
        {
            try
            {
                var db = new Contexto();

                int cEstado = db.Estado.Where(x => x.UF == _uf).Select(x => x.cEstado).FirstOrDefault();


                return cEstado;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
