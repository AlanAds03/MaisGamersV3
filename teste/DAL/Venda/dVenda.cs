using MaisGamers.Model;
using MaisGamers.Model.Cadastro;
using MaisGamers.Model.Vendas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL.Venda
{
    public class dVenda
    {

        public double TotalVenda(int idVenda)
        {

            var db = new Contexto();
            double total = 0;

            try
            {
                //List<dynamic> asdasd = db.Vendas.Include(x => x.Produto).Where(x => x.IDVenda == idVenda).Select(x=> x.Produto);

                List<mProduto> query = (from p in db.Produtos
                                        from v in p.Venda.Where(x => x.IDVenda == idVenda)
                                        select p).ToList();


                foreach (mProduto prod in query)
                {
                    total += prod.Unitario;

                }

                return total;

            }
            catch (Exception)
            {
                return 0;
                throw;
            }


        }
        public List<dynamic> CarregaGridVendas(int idVenda)
        {
            var db = new Contexto();
            
            try
            {
                //List<dynamic> asdasd = db.Vendas.Include(x => x.Produto).Where(x => x.IDVenda == idVenda).Select(x=> x.Produto);

                var query = (from p in db.Produtos
                             from v in p.Venda.Where(x=> x.IDVenda == idVenda)
                             select new { ColunasGrid = "Produto[400|Produto];Preço", p.Produto, Preço = p.Unitario }).ToList();


                return query.ToList<dynamic>();

            }
            catch (Exception)
            {
                return null;
                throw;
            }

            
        }
        public int InserirVenda(mVenda venda)
        {

            var db = new Contexto();

            try
            {
                if (venda.IDVenda == 0)
                {
                    db.Vendas.Add(venda);
                    db.SaveChanges();
                }
                else
                {

                    mVenda _venda = db.Vendas.Find(venda.IDVenda);

                    MapObject(ref venda, ref _venda);
                    db.Entry(_venda).State = EntityState.Modified;
                    db.SaveChanges();

                }

                return venda.IDVenda;

            }
            catch (Exception ex)
            {

                return -1;
            }

        }

        public int InserirVendaProduto(mVenda venda,mProduto produto)
        {

            var db = new Contexto();
            mVenda mvendasNovas = new mVenda();

            try
            {
                mvendasNovas = db.Vendas.Find(venda.IDVenda);
                mvendasNovas.Produto.Add(db.Produtos.Find(produto.IDProduto));
               db.SaveChanges();
                

                return mvendasNovas.IDVenda;

            }
            catch (Exception ex)
            {

                return -1;
            }

        }


        public void MapObject(ref mVenda source, ref mVenda destination)
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
