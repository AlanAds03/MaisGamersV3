using MaisGamers.DAL.Venda;
using MaisGamers.Model.Cadastro;
using MaisGamers.Model.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Venda
{
    public class bVenda
    {
        public int InserirVenda(mVenda venda)
        {
            dVenda _dVenda = new dVenda();

            return _dVenda.InserirVenda(venda);

        }

        //public bool ExcluirProdutoVenda(int idVenda, int idProduto)
        //{
        //    dVenda _dVenda = new dVenda();

        //    return _dVenda.ExcluirProdutoVenda(idVenda,idProduto);

        //}


        public int InserirVendaProduto(int idvenda, int idproduto)
        {
            dVenda _dVenda = new dVenda();

            return _dVenda.InserirVendaProduto(idvenda, idproduto);

        }

        //public List<dynamic> CarregaGridVendas(int idVenda)
        //{
        //    dVenda _dVenda = new dVenda();

        //    return _dVenda.CarregaGridVendas(idVenda);

        //}

        //public double TotalVenda(int idVenda)
        //{
        //    dVenda _dVenda = new dVenda();

        //    return _dVenda.TotalVenda(idVenda);

        //}

    }
}
