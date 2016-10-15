using MaisGamers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL
{
    public class dCidade
    {

        public List<mCidade> CarregaCidade(int _cEstado)
        {

            
            mEstado _estado = new mEstado();
            List<mCidade> mCidade = new List<Model.mCidade>();

            try
            {

                using (var db = new Contexto())
                {

                    var a =  (from p in db.Cidade where p.cEstado.cEstado == _cEstado select p).ToList();

                    return a;

                }


            }
            catch (Exception ex)
            {

                return null;
            }

        }
    }
}
