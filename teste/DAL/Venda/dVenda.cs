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

        //public bool ExcluirProdutoVenda(int idVEnda, int idProduto)
        //{
        //    var db = new Contexto();
        //    try
        //    {
        //        mVenda _venda = db.Vendas.Where(y => y.IDVenda == idVEnda).FirstOrDefault();
        //        mProduto _prod = db.Produtos.Where(x => x.IDProduto == idProduto).FirstOrDefault();

        //        _venda.Produto.Remove(_prod);
        //        db.Entry(_venda).State = EntityState.Modified;
        //        db.SaveChanges();

        //        return true;

        //    }
        //    catch (Exception)
        //    {
        //        return false;

        //        throw;
        //    }

        //}

        public Int32 RetornarCodigoProduto(int idVEndaProduto)
        {
            var db = new Contexto();
            try
            {
                var xx = (from v in db.VendaProduto
                          where v.IDVendaProduto == idVEndaProduto
                          select (decimal)v.Produto.IDProduto
                          ).Single();

                return Convert.ToInt32(xx);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool ExcluirProdutoVenda(int idVEndaProduto)
        {
            var db = new Contexto();
            try
            {
                mVendaProduto _vendaProduto = db.VendaProduto.Find(idVEndaProduto);

                db.Entry(_vendaProduto).State = EntityState.Deleted;
                db.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                return false;

                throw;
            }

        }

        public double TotalVenda(int idVenda)
        {

            var db = new Contexto();


            try
            {
                //List<dynamic> asdasd = db.Vendas.Include(x => x.Produto).Where(x => x.IDVenda == idVenda).Select(x=> x.Produto);

                var xx = (from v in db.Vendas
                          join vendaprod in db.VendaProduto on v.IDVenda equals vendaprod.Venda.IDVenda
                          join d in db.Produtos on vendaprod.Produto.IDProduto equals d.IDProduto
                          where vendaprod.Venda.IDVenda == idVenda
                          group vendaprod by new { vendaprod.Produto.IDProduto, vendaprod.Venda.IDVenda } into g
                          select new
                          {
                              Total = g.Sum(x => x.Produto.Unitario)
                          });

                if (xx.Count() == 0)
                {
                    return 0;
                }


                double total = xx.Sum(p => p.Total);
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

                db.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

                var xx = (from v in db.Vendas
                          join vendaprod in db.VendaProduto on v.IDVenda equals vendaprod.Venda.IDVenda
                          join d in db.Produtos on vendaprod.Produto.IDProduto equals d.IDProduto
                          where vendaprod.Venda.IDVenda == idVenda
                          select new
                          {
                              IDVenda = vendaprod.IDVendaProduto,
                              Produto = d.Produto,
                              Valor = d.Unitario,
                              v.rCliente,
                              colunasGrid = "IDVenda;Produto[300|Produto];Valor[200|Valor]"
                              //group new { d, vendaprod } by new {d.Produto,d.Unitario} into g
                              //select new {
                              //    IDVenda = g.Key.IDVendaProduto,
                              //    Descricao = g.Key.Produto,
                              //    Total = g.Sum(x=> x.d.Unitario)

                          }).ToList();




                //var query = (from p in db.Produtos
                //             from v in p.Venda.Where(x => x.IDVenda == idVenda)
                //             select new { ColunasGrid = "IDProduto;Produto[400|Produto];Preço", IDProduto = p.IDProduto, p.Produto, Preço = p.Unitario }).ToList();


                return xx.ToList<dynamic>();


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

       
        public int InserirVendaProduto(int idVenda, int idProduto)
        {

            var db = new Contexto();
            mVenda _vendas = new mVenda();
            mProduto _produtos = new mProduto();
            mVendaProduto _vendaProduto = new mVendaProduto();


            try
            {
                _vendas = db.Vendas.Find(idVenda);
                _produtos = db.Produtos.Find(idProduto);

                _vendaProduto.Produto = _produtos;
                _vendaProduto.Venda = _vendas;

                db.VendaProduto.Add(_vendaProduto);
                db.SaveChanges();


                return _vendaProduto.IDVendaProduto;

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

        public bool FinalizarVenda(mVenda venda)
        {

            var db = new Contexto();

            try
            {

                mVenda _venda = db.Vendas.Find(venda.IDVenda);

                MapObject(ref venda, ref _venda);
                db.Entry(_venda).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

            
        }

    }
}
