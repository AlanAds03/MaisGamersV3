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
                _fotosOrcamento.IDOrcamento = db.Orcamento.Find(_fotosOrcamento.IDOrcamento.IDOrcamento);
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

        internal List<byte[]> BuscarFotos(int idFotoOrcamento)
        {
            
                var db = new Contexto();
                try
                {
                var a = from x in db.FotosOrcamento
                        where x.IDOrcamento.IDOrcamento == idFotoOrcamento
                        select x.Foto;

                return a.ToList<byte[]>();

                }
                catch (Exception ex)
                {
                    return null;
                }

            
        }
    }
}
