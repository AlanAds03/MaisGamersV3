using MaisGamers.DAL.Orcamento;
using MaisGamers.Model.Orcamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Orcamento
{
    public class bOrcamento
    {
        public bool Inserir(mOrcamento orcamento)
        {

            try
            {
                dOrcamento _d = new dOrcamento();

                return _d.Inserir(orcamento);

            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }
    }

}
