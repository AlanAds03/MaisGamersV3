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

namespace MaisGamersV2.DAL.Locacao
{
    public class dClienteLocacao :  IDisposable
    {
     

        public bool InserirCliente(mClienteLocacao _clienteLocacao)
        {
            var db = new Contexto();
            
            try
            {

                _clienteLocacao.Estado = db.Estado.First(X => X.cEstado == _clienteLocacao.cEstado);
                _clienteLocacao.Cidade = db.Cidade.First(X => X.cCidade == _clienteLocacao.cCidade);
                _clienteLocacao.TipoCliente = db.TipoCliente.First(x => x.IDTipoCliente == _clienteLocacao.IDTipoCliente);
                if(_clienteLocacao.idClienteLocacao != 0)
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

        public bool ExcluirCliente(int idClienteLocacao)
        {
            try
            {
                using(var db = new Contexto())
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
        public string PesquisaCliente(mClienteLocacao _clienteLocacao, string order)
        {
            var db = new Contexto();

            try
            {

                var cli = (from a in db.ClienteLocacao
                           where
                            a.Nome.Contains(_clienteLocacao.Nome) &&
                            ((_clienteLocacao.RG ?? a.RG) == a.RG) &&
                            //((_clienteLocacao.CPF ?? a.CPF) == a.CPF) &&
                            (_clienteLocacao.idClienteLocacao == 0 ? a.idClienteLocacao == a.idClienteLocacao : a.idClienteLocacao == _clienteLocacao.idClienteLocacao)
                    
                    

                           select new {a.idClienteLocacao, a.Nome, a.DataNascimento});

                //'var columns = cli.Select(x => new {x.idClienteLocacao, x.Nome, x.Numero,x.JsonGRID = "").ToList();
                    var columns = cli.Select(x => new {x.idClienteLocacao,  x.Nome, x.DataNascimento }).ToList();


                JavaScriptSerializer serializer = new JavaScriptSerializer();

                var json = serializer.Serialize(columns);

                return json;

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
                    match.dp.SetValue(destination, match.sp.GetValue(source, null), null);
                }
            }
            catch (Exception ex)
            {
                return;

            }

        }
    }
}
