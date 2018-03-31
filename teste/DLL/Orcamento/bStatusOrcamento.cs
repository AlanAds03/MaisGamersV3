using MaisGamers.DAL.Orcamento;
using MaisGamers.Model.Orcamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Orcamento
{
    public class bStatusOrcamento
    {

        public List<mStatusOrcamento> CarregaStatusOrcamento()
        {
            dStatusOrcamento dStatus = new dStatusOrcamento();
            return dStatus.CarregaStatusOrcamento();
        }

    }
}
