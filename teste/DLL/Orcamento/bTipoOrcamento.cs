using MaisGamers.DAL;
using MaisGamers.Model;
using MaisGamers.Model.Orcamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL
{
    public class bTipoOrcamento
    {
        public List<mTipoOrcamento> CarregaTipoOrcamento()
        {
            dTIpoOrcamento _tipo = new dTIpoOrcamento();
            return _tipo.CarregaTipoOrcamento();
        }

       
    }
}
