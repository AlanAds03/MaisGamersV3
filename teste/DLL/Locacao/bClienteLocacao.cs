using MaisGamers.Model.Locacao;
using MaisGamersV2.DAL.Locacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frameworks;
using Frameworks.Componentes;

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

        public mClienteLocacao ObterCliente(int idCLienteLocacao)
        {
            dClienteLocacao _dCliente = new dClienteLocacao();
            return _dCliente.ObterCliente(idCLienteLocacao);

        }
        public  string PesquisaCliente (mClienteLocacao cliente, string order)
        {
            try
            {
                dClienteLocacao _dCliente = new dClienteLocacao();
                return _dCliente.PesquisaCliente(cliente,order);

            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
