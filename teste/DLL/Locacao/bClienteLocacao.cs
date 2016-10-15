using MaisGamers.Model.Locacao;
using MaisGamersV2.DAL.Locacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Locacao
{
    public class bClienteLocacao
    {
        public Boolean IncluirCliente(mClienteLocacao cliente)
        {

            try
            {
                dClienteLocacao _dCliente = new dClienteLocacao();


                return _dCliente.InserirCliente(cliente);
                
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
