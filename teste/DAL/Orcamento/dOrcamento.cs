using MaisGamers.Model;
using MaisGamers.Model.Orcamento;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL.Orcamento
{
    public class dOrcamento
    {

        public mOrcamento Obter(int idOrcamento)
        {

            var db = new Contexto();

            try
            {
                return db.Orcamento.Include("StatusOrcamento").Where(x => x.IDOrcamento == idOrcamento).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<dynamic> PesquisarOrcamento(string cliente,string produto, int idStatus)
        {

            var db = new Contexto();

            try
            {
                var orcamento = from o in db.Orcamento 
                                join s in db.StatusOrcamento on o.StatusOrcamento.IDStatusOrcamento equals s.IDStatusOrcamento
                                where o.NomeCliente.Contains(string.IsNullOrEmpty(cliente) ? o.NomeCliente : cliente)
                                orderby o.Data_Entrada descending
                                select new { ColunasGrid = "IDOrcamento;NomeCliente[300|Cliente];Produto[200|Produto];StatusOrcamento[300|Status];Data_Entrada[200|Data Entrada]", o.IDOrcamento, o.NomeCliente,o.Produto, s.StatusOrcamento,o.Data_Entrada} ;
                

                return orcamento.ToList<dynamic>();


            }
            catch (Exception)
            {
                return null;
                
            }
        }
        public bool Inserir(mOrcamento orcamento)
        {
            var db = new Contexto();

            try
            {

                if(orcamento.IDOrcamento == 0)
                {
                    orcamento.StatusOrcamento = db.StatusOrcamento.Find(orcamento.IdStatusOrcamento);
                    db.Orcamento.Add(orcamento);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    mOrcamento orc = db.Orcamento.Find(orcamento.IDOrcamento);
                    orcamento.StatusOrcamento = db.StatusOrcamento.Find(orcamento.IdStatusOrcamento);

                    MapObject(ref orcamento, ref orc);
                    db.Entry(orc).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
               
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
