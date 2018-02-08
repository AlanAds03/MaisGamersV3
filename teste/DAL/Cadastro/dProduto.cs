using MaisGamers.Model;
using MaisGamers.Model.Cadastro;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Data.Entity;

namespace MaisGamers.DAL
{
    public class dProduto
    {

        public List<mProduto> ConsultarProdutos(mProduto _produto)
        {


            try
            {
                using (var db = new Contexto())
                {
                    var a = (from p in db.Produtos
                             where p.Produto == _produto.Produto
                             select p).ToList();

                    a.Select(x => x.ColunasGrid = "Produto;Quantidade;Unitario ");

                    return a;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public bool ExisteEstoque(int idProduto)
        {
            try
            {
                using (var db = new Contexto())
                {
                    mProduto _prod = db.Produtos.Find(idProduto);

                    if (_prod == null)
                    {
                        return false;
                    }

                    if (_prod.Quantidade <= 0)
                    {
                        return false;
                    }

                    return true;

                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool BaixarEstoqueProduto(int idProduto)
        {
            try
            {
                using (var db = new Contexto())
                {

                    mProduto pro = db.Produtos.Find(idProduto);

                    pro.Quantidade = pro.Quantidade - 1;
                    db.Entry(pro).State = EntityState.Modified;
                    db.SaveChanges();


                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool IncluirProduto(mProduto produto)
        {
            try
            {
                using (var db = new Contexto())
                {

                    if (produto.IDProduto != 0)
                    {
                        mProduto ProdutoDB = db.Produtos.Find(produto.IDProduto);
                        MapObject(ref produto, ref ProdutoDB);
                        db.Entry(ProdutoDB).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Produtos.Add(produto);
                        db.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ExcluirProduto(int idProduto)
        {
            try
            {
                using (var db = new Contexto())
                {
                    var produto = db.Produtos.Find(idProduto);

                    if (produto.IDProduto != 0)
                    {
                        db.Entry(produto).State = EntityState.Deleted;
                        db.SaveChanges();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        internal mProduto PesquisarProdutoID(int idProduto)
        {

            using (var db = new Contexto())
            {
                return db.Produtos
                    .Where(y => y.IDProduto == idProduto).FirstOrDefault();
            }
        }




        public List<mProduto> PesquisaProduto(mProduto produto, string order)
        {
            var db = new Contexto();


            try
            {

                List<mProduto> listProdutos = db.Produtos
                          .Where(z => z.Produto.Contains((string.IsNullOrEmpty(produto.Produto) ? z.Produto : produto.Produto)))

                          .ToList();


                List<mProduto> nova = new List<mProduto>();

                nova = listProdutos.Select(x => { x.ColunasGrid = "IDProduto;Produto[300|Produto];Quantidade[100|Quantidade];Unitario[200|Preço];"; return x; }).ToList();


                return nova.ToList();


            }
            catch (Exception ex)
            {
                return null;
            }

        }


        public void MapObject(ref mProduto source, ref mProduto destination)
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
                    match.dp.SetValue(destination, match.sp.GetValue(source, null), null);
                }
            }
            catch (Exception ex)
            {
                return;

            }

        }

    }
}
