using MaisGamers.Model;
using MaisGamers.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL
{
    public class dConsole
    {

        public List<mConsole> CarregaConsole()
        {

            mConsole _estado = new mConsole();
            List<mConsole> mCidade = new List<mConsole>();
            try
            {
                using (var db = new Contexto())
                {

                    var a =  (from p in db.Console select p).ToList();
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
