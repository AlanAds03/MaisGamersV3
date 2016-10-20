using Frameworks.Componentes;
using MaisGamers.Model;
using MaisGamers.Model.Locacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        public List<mClienteLocacao> PesquisaCliente(mClienteLocacao _clienteLocacao)
        {
            var db = new Contexto();

            try
            {

                var cli = (from a in db.ClienteLocacao where a.Nome.Contains(_clienteLocacao.Nome) && (_clienteLocacao.RG ?? a.RG) ==  a.RG select a);

                return cli.ToList();

            }
            catch (Exception ex)
            {
                return null;
            }




        }

    }
}
