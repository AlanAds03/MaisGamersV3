using MaisGamers.DAL;
using MaisGamers.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Cadastro
{
    public class bProduto : IDisposable
    {
        public void Dispose()
        {
            
        }


        public bool  InserirProduto(mProduto produto)
        {
            try
            {
                dProduto _dProduto = new dProduto();

                return _dProduto.IncluirProduto(produto);

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
                dProduto _dProduto = new dProduto();

                return _dProduto.BaixarEstoqueProduto(idProduto);

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool ExisteEstoque(int idProduto)
        {
            try
            {
                dProduto _dProduto = new dProduto();

                return _dProduto.ExisteEstoque(idProduto);

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
                dProduto _dProduto = new dProduto();

                return _dProduto.ExcluirProduto(idProduto);

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public mProduto PesquisarProdutoID(int idProduto)
        {
            try
            {
                dProduto _dProduto = new dProduto();

                return _dProduto.PesquisarProdutoID(idProduto);

            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public List<mProduto> PesquisaProduto(mProduto produto, string order)
        {
            try
            {
                dProduto d = new dProduto();


                return d.PesquisaProduto(produto, order);


            }
            catch (Exception)
            {

                throw;
            }


        }



    }
}
