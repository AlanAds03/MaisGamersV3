using MaisGamers.Model;
using MaisGamers.Model.Orcamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL.Orcamento
{
    public class dOrcamento
    {
        public bool Inserir(mOrcamento orcamento)
        {
            var db = new Contexto();

            try
            {

                orcamento.StatusOrcamento = db.StatusOrcamento.Find(orcamento.IdStatusOrcamento);
                db.Orcamento.Add(orcamento);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw;
            }

        }



        public void MapObject(ref mOrcamento source, ref mOrcamento destination)
        {

            try
            {
                Type sourceType = source.GetType();
                Type destinationTipe = destination.GetType();

                var sourceProperties = sourceType.GetProperties();
                var destinationProperties = destinationTipe.GetProperties();

                var commonProperties = from sp in sourceProperties
                                       join dp in destinationProperties on new { sp.Name, sp.PropertyType } equals
                                                                           new { dp.Name, dp.PropertyType }
                                       select new { sp, dp };
                foreach (var match in commonProperties)
                {
                    if (match.sp.GetValue(source, null) != null)
                    {
                        match.dp.SetValue(destination, match.sp.GetValue(source, null), null);
                    }

                }
            }
            catch (Exception ex)
            {
                return;

            }

        }

    }
}
