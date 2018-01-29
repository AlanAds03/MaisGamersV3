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

        public int InserirVendaProduto(mVenda venda,mProduto produto)
        {
            dVenda _dVenda = new dVenda();

            return _dVenda.InserirVendaProduto(venda, produto);

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
