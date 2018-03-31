using MaisGamers.Model;
using MaisGamers.Model.Orcamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL.Orcamento
{
    public class dStatusOrcamento
    {
        public List<mStatusOrcamento> CarregaStatusOrcamento()
        {
            var db = new Contexto();
            try
            {
                return db.StatusOrcamento.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
