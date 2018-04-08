using MaisGamers.Model;
using MaisGamers.Model.Orcamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL.Orcamento
{
    public class dFotosOrcamento
    {

        public bool InserirFoto(mFotosOrcamento _fotosOrcamento)
        {
            var db = new Contexto();
            try
            {
                db.FotosOrcamento.Add(_fotosOrcamento);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }
    }
}
