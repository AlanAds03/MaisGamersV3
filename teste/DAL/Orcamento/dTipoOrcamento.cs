using MaisGamers.Model;
using MaisGamers.Model.Orcamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL
{
    public class dTIpoOrcamento
    {
        
        public List<mTipoOrcamento> CarregaTipoOrcamento()
        {

            var db = new Contexto();
            try
            {
                return db.TipoOrcamento.ToList();

            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public mTipoOrcamento ConsultaTipoOrcamento(int  __idTipoOrcamento)
        {
            try
            {
                var db = new Contexto();

                return db.TipoOrcamento.Find(__idTipoOrcamento);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
