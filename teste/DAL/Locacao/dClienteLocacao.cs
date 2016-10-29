using Frameworks.Componentes;
using MaisGamers.Model;
using MaisGamers.Model.Locacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MaisGamersV2.DAL.Locacao
{
    public class dClienteLocacao
    {

        public bool InserirCliente(mClienteLocacao _clienteLocacao)
        {
            var db = new Contexto();

            try
            {

                _clienteLocacao.Estado = db.Estado.First(X => X.cEstado == _clienteLocacao.cEstado);
                _clienteLocacao.Cidade = db.Cidade.First(X => X.cCidade == _clienteLocacao.cCidade);

                db.ClienteLocacao.Add(_clienteLocacao);
                db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
            



        }

        public string PesquisaCliente(mClienteLocacao _clienteLocacao)
        {
            var db = new Contexto();

            try
            {

                var cli = (from a in db.ClienteLocacao
                           where
                            a.Nome.Contains(_clienteLocacao.Nome) &&
                            ((_clienteLocacao.RG ?? a.RG) == a.RG) select a);

                var columns = cli.Select(x => new { x.Nome, x.Numero}).ToList();

                JavaScriptSerializer serializer = new JavaScriptSerializer();

                var json = serializer.Serialize(columns);

                //ar columns = thisProject.Select(x => new { x.ProjectContactFirstName, x.ProjectContactLastName }).ToList();
                //r columns = thisProject.Select(x => new { x.ProjectContactFirstName, x.ProjectContactLastName }).ToList();



                return json;

            }
            catch (Exception ex)
            {
                return null;
            }




        }

    }
}
