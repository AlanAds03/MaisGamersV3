using MaisGamers.DAL.Locacao;
using MaisGamers.DLL.Locacao;
using MaisGamers.Model.Locacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Locacao
{
    public class bStatusClienteLocacao
    {

        public List<mStatusCliente> CarregaStatusClienteLocacao()
        {
            dStatusClienteLocacao _dStatus = new dStatusClienteLocacao();
            return _dStatus.CarregaStatusClienteLocacao();
        }

    }
}
