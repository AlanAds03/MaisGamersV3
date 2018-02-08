using MaisGamers.DAL;
using MaisGamers.Model.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Venda
{
    public class bTipoPagamento
    {
        public List<mTipoPagamento> CarregaComboTipoPagamento()
        {
            dTipoPagamento _tipo = new dTipoPagamento();

            return _tipo.CarregaTipoPagamento();
        }
    }
}
