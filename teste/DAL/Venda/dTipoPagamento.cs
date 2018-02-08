using MaisGamers.Model;
using MaisGamers.Model.Cadastro;
using MaisGamers.Model.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL
{
    public class dTipoPagamento
    {

        public List<mTipoPagamento> CarregaTipoPagamento()
        {

            
            try
            {
                using (var db = new Contexto())
                {

                    var a =  (from p in db.TipoPagamento select p).ToList();
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
