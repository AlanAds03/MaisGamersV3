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
            catch (Exception ex)
            {

                return false;
            }

        }

        public mClienteLocacao BuscarClienteLocacao(int idLocacao)
        {
            try
            {

                dClienteLocacao dLocacao = new dClienteLocacao();

                return dLocacao.BuscarClienteLocacao(idLocacao);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Boolean IncluirFoto(int idClienteLocacao , bool locatario, byte[] fotoLocatario)
        {

            try
            {
                dClienteLocacao _dCliente = new dClienteLocacao();


                return _dCliente.InserirFoto(idClienteLocacao, locatario,fotoLocatario);

            }
            catch (Exception ex)
            {

                return false;
            }

        }


        public mClienteLocacao ObterCliente(int idCLienteLocacao)
        {
            dClienteLocacao _dCliente = new dClienteLocacao();
            return _dCliente.ObterCliente(idCLienteLocacao);

        }
        public  List<mClienteLocacao> PesquisaCliente (mClienteLocacao cliente, string order)
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

        public bool ExcluirCliente(int idClienteLocacao)
        {
            try
            {
                using (var d = new dClienteLocacao())
                {
                    return d.ExcluirCliente(idClienteLocacao);
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        internal mClienteLocacao PesquisaClienteID(int idClienteLocacao)
        {
            try
            {
                using( var d = new dClienteLocacao())
                {
                    return d.PesquisaClienteID(idClienteLocacao);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SalvarDocumento(int idClienteLocacao, byte[] byte_documento,String documento)
        {

            try
            {
                using(var d = new dClienteLocacao())
                {
                    d.SalvarDocumento(idClienteLocacao, byte_documento, documento);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public byte[] BuscarDocumento(int idClienteLocacao, String documento)
        {

            try
            {
                using (var d = new dClienteLocacao())
                {
                    return d.BuscarDocumento(idClienteLocacao, documento);
                }


            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

    }
}
