using MaisGamers.DAL.Cadastro;
using MaisGamers.Model;
using MaisGamers.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL
{
    public class dTipoCliente
    {

        public List<mTipoCliente> CarregaTipoCliente()
        {

            mTipoCliente _mTipoCliente = new mTipoCliente();
            List<mTipoCliente> mTipoCliente = new List<mTipoCliente>();
            try
            {
                using (var db = new Contexto())
                {

                    var a = (from p in db.TipoCliente select p).ToList();
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
