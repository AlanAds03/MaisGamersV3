using MaisGamers.Model;
using MaisGamers.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL
{
    public class dTipoJogo
    {

        public List<mTipoJogo> CarregaTipoJogo()
        {
            mTipoJogo _mTipoJogo = new mTipoJogo();
            
            try
            {
                using (var db = new Contexto())
                {
                    var a =  (from p in db.TipoJogo select p).ToList();
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
