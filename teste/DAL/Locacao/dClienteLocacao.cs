using Frameworks.Componentes;
using MaisGamers.Model;
using MaisGamers.Model.Locacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Data.Entity;
using MaisGamers.DAL;
using MaisGamers.Model.Documento;

namespace MaisGamersV2.DAL.Locacao
{
    public class dClienteLocacao : IDisposable
    {

        public bool InserirFoto(int idClienteLocacao, bool locatario, byte[] fotoLocatario)
        {

            var db = new Contexto();

            try
            {


                mClienteLocacao cliente = db.ClienteLocacao.Find(idClienteLocacao);

                if (locatario)
                {
                    cliente.FotoLocatario = fotoLocatario;
                }
                else
                {
                    cliente.FotoAutorizado = fotoLocatario;
                }

                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();





                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public bool InserirCliente(mClienteLocacao _clienteLocacao)
        {
            var db = new Contexto();

            try
            {

                _clienteLocacao.Estado = db.Estado.First(X => X.cEstado == _clienteLocacao.cEstado);
                _clienteLocacao.Cidade = db.Cidade.First(X => X.cCidade == _clienteLocacao.cCidade);
                _clienteLocacao.TipoCliente = db.TipoCliente.First(x => x.IDTipoCliente == _clienteLocacao.IDTipoCliente);
                if (_clienteLocacao.idClienteLocacao != 0)
                {
                    mClienteLocacao cliente = db.ClienteLocacao.Find(_clienteLocacao.idClienteLocacao);



                    MapObject(ref _clienteLocacao, ref cliente);
                    db.Entry(cliente).State = EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    db.ClienteLocacao.Add(_clienteLocacao);
                    db.SaveChanges();
                }




                return true;
            }
            catch (Exception ex)
            {

                return false;
            }




        }

        internal mClienteLocacao ObterCliente(int idCLienteLocacao)
        {
            var db = new Contexto();

            try
            {

                return db.ClienteLocacao
                    .Include(x => x.Estado)
                    .Include(y => y.Cidade)
                    .Include(z => z.TipoCliente)
                    .Where(x => x.idClienteLocacao == idCLienteLocacao).FirstOrDefault();

            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public mClienteLocacao BuscarClienteLocacao(int idLocacao)
        {

            var db = new Contexto();

            mClienteLocacao cliente = new mClienteLocacao();
            try
            {
                cliente = (from locacao in db.Locacao
                           join _cli in db.ClienteLocacao on locacao.IDClienteLocacao.idClienteLocacao equals _cli.idClienteLocacao
                           where (locacao.IDLocacao == idLocacao)
                           select locacao.IDClienteLocacao).FirstOrDefault();

                return cliente;


            }
            catch (Exception)
            {
                return cliente;
                throw;
            }
        }
        internal bool SalvarDocumento(int idClienteLocacao, byte[] byte_documento, string documento, string extensaoArquivo)
        {

            var db = new Contexto();

            try
            {



                mClienteLocacao cliente = db.ClienteLocacao.Find(idClienteLocacao);

                if (documento == "RG")
                {
                    cliente.AnexoRG = byte_documento;
                    cliente.extensaoAnexoRG = extensaoArquivo;
                }
                else if (documento == "CONTRATO")
                {
                    cliente.DocumentoAssinado = byte_documento;
                    cliente.extensaoDocumentoAssinado = extensaoArquivo;
                }
                else
                {
                    cliente.AnexoComprovanteEndereco = byte_documento;
                    cliente.extensaoComprovanteEndereco = extensaoArquivo;
                }


                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                return true;
                
            }
        }

        internal mDocumento BuscarDocumento(int idClienteLocacao, string documento)
        {

            var db = new Contexto();

            mDocumento _documento = new mDocumento();

            mClienteLocacao cliente = db.ClienteLocacao.Find(idClienteLocacao);

            if (documento == "RG")
            {
                _documento.documentos = cliente.AnexoRG;
                _documento.extensaoArquivo = cliente.extensaoAnexoRG;
            }
            else if (documento == "CONTRATO")
            {
                _documento.documentos = cliente.DocumentoAssinado;
                _documento.extensaoArquivo = cliente.extensaoDocumentoAssinado;
            }
            else
            {
                _documento.documentos = cliente.AnexoComprovanteEndereco;
                _documento.extensaoArquivo = cliente.extensaoComprovanteEndereco;

            }


            return _documento;

        }

        internal mClienteLocacao PesquisaClienteID(int idClienteLocacao)
        {
            var db = new Contexto();

            try
            {

                return db.ClienteLocacao.Find(idClienteLocacao);
            }
            catch (Exception ex)
            {

                return null;
            }
        }


        public bool ExcluirCliente(int idClienteLocacao)
        {
            try
            {
                using (var db = new Contexto())
                {
                    var cli = db.ClienteLocacao.Where(x => x.idClienteLocacao == idClienteLocacao).FirstOrDefault();
                    db.Entry(cli).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public List<mClienteLocacao> PesquisaCliente(mClienteLocacao _clienteLocacao, string order)
        {
            var db = new Contexto();

            try
            {



                List<mClienteLocacao> listCliente = db.ClienteLocacao
                     .Include(x => x.TipoCliente)
                     .Where(z => z.Nome.Contains((string.IsNullOrEmpty(_clienteLocacao.Nome) ? z.Nome : _clienteLocacao.Nome)))
                     //.Where(z => z.IDConsole.idConsole == (jogo.cIdConsole == 0 ? z.IDConsole.idConsole : jogo.cIdConsole))
                     .ToList();


                List<mClienteLocacao> nova = new List<mClienteLocacao>();

                nova = listCliente.Select(x => { x.ColunasGrid = "idClienteLocacao;Nome;RG;CPF;strTipoCliente;"; x.strTipoCliente = ((x.TipoCliente == null ? "" : x.TipoCliente.TipoCliente)); return x; }).ToList();


                return nova.ToList();



                //var cli = (from a in db.ClienteLocacao
                //           where
                //            a.Nome.Contains(_clienteLocacao.Nome) &&
                //            ((_clienteLocacao.RG ?? a.RG) == a.RG) &&
                //            //((_clienteLocacao.CPF ?? a.CPF) == a.CPF) &&
                //            (_clienteLocacao.idClienteLocacao == 0 ? a.idClienteLocacao == a.idClienteLocacao : a.idClienteLocacao == _clienteLocacao.idClienteLocacao)



                //           select new {a.idClienteLocacao, a.Nome, a.DataNascimento});


                //    var columns = cli.Select(x => new {x.idClienteLocacao,  x.Nome, x.DataNascimento }).ToList();


                //JavaScriptSerializer serializer = new JavaScriptSerializer();

                //var json = serializer.Serialize(columns);

                //return json;

            }
            catch (Exception ex)
            {
                return null;
            }




        }

        public void Dispose()
        {

        }

        public void MapObject(ref mClienteLocacao source, ref mClienteLocacao destination)
        {

            try
            {
                Type sourceType = source.GetType();
                Type destinationTipe = destination.GetType();

                var sourceProperties = sourceType.GetProperties();
                var destinationProperties = destinationTipe.GetProperties();

                var commonProperties = from sp in sourceProperties
                                       join dp in destinationProperties on new { sp.Name, sp.PropertyType } equals
                                                                           new { dp.Name, dp.PropertyType }
                                       select new { sp, dp };
                foreach (var match in commonProperties)
                {
                    if (match.sp.GetValue(source, null) != null)
                    {
                        match.dp.SetValue(destination, match.sp.GetValue(source, null), null);
                    }

                }
            }
            catch (Exception ex)
            {
                return;

            }

        }
    }
}
