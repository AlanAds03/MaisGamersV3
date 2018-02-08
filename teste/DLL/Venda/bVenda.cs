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

        public bool ExcluirProdutoVenda(int idVendaProd)
        {
            dVenda _dVenda = new dVenda();

            return _dVenda.ExcluirProdutoVenda(idVendaProd);

        }

        public int RetornoCodigoProduto(int idVendaProd)
        {
            dVenda _dVenda = new dVenda();

            return _dVenda.RetornarCodigoProduto(idVendaProd);

        }


        public bool FinalizarVenda(mVenda _venda)
        {
            dVenda _dVenda = new dVenda();

            return _dVenda.FinalizarVenda(_venda);
        }
        public int InserirVendaProduto(int idvenda, int idproduto)
        {
            dVenda _dVenda = new dVenda();

            return _dVenda.InserirVendaProduto(idvenda, idproduto);

        }

        public List<dynamic> CarregaGridVendas(int idVenda)
        {
            dVenda _dVenda = new dVenda();

            return _dVenda.CarregaGridVendas(idVenda);

        }

        public double TotalVenda(int idVenda)
        {
            dVenda _dVenda = new dVenda();

            return _dVenda.TotalVenda(idVenda);

        }

    }
}
