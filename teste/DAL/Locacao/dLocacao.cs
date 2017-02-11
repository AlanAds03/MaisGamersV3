using MaisGamers.Model;
using MaisGamers.Model.Locacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MaisGamers.DAL.Locacao
{
    public class dLocacao
    {

        public int InserirLocacao(mLocacao _mLocacao)
        {


            var db = new Contexto();

            try
            {

                _mLocacao.StatusLocacao = db.StatusLocacao.Find(1);
                _mLocacao.IDClienteLocacao = db.ClienteLocacao.Find(_mLocacao.idClienteLocacao);

                _mLocacao.DataLocacao = DateTime.Now;
                _mLocacao.DataLocacaoEntrega = DateTime.Now;
                
                if (_mLocacao.IDLocacao != 0)
                {
                    mLocacao locacaoBanco = db.Locacao.Find(_mLocacao.IDClienteLocacao.idClienteLocacao);
                    MapObject(ref _mLocacao, ref locacaoBanco);
                    db.Entry(locacaoBanco).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    db.Locacao.Add(_mLocacao);
                    db.SaveChanges();
                }




                return _mLocacao.IDLocacao;
            }
            catch (Exception ex)
            {

                return -1;
            }

        }


        public List<dynamic> PesquisaLocacao(string NomeCliente , int Status)
        {

            var db = new Contexto();

            try
            {


                var a = from   z in db.Locacao
                        join w in db.ClienteLocacao on z.IDClienteLocacao.idClienteLocacao equals w.idClienteLocacao
                        join y in db.StatusLocacao on z.StatusLocacao.IDStatus equals y.IDStatus
                        where   w.Nome.Contains((string.IsNullOrEmpty(NomeCliente)? w.Nome : NomeCliente))
                        where z.StatusLocacao.IDStatus == (Status != 0 ? Status : z.StatusLocacao.IDStatus)
                        select new { ColunasGrid = "IDLocacao;Nome[300|Cliente];DataLocacao[150|Data Locação];Status[150|Status]", z.IDLocacao, w.Nome, z.DataLocacao,y.Status };



                return a.ToList<dynamic>();

            }
            catch (Exception ex)
            {

                return null;
            }


        }

        

        public List<dynamic> PesquisaLocacaoID(int idLocacao)
        {

            var db = new Contexto();

            try
            {


                var a = from x in db.LocacaoJogos
                        join z in db.Locacao on x.IDLocacao.IDLocacao equals z.IDLocacao
                        join y in db.Jogo on x.IDJogo.IDJogo equals y.IDJogo
                        join w in db.PrecoLocacao on y.IDConsole equals w.IDConsole
                        where z.IDLocacao == idLocacao
                        select new  { ColunasGrid = "NomeJogo[200|Jogo];NomeConsole[150|Console];DataLocacao[150|Data Locação];PrecoDia1[100|1 Dia];;PrecoDia2[100|2 Dia];;PrecoDia3[100|3 Dia];", y.NomeJogo , y.IDConsole.NomeConsole, z.DataLocacao, w.PrecoDia1, w.PrecoDia2 , w.PrecoDia3 };



                return a.ToList<dynamic>();

            }
            catch (Exception ex)
            {

                return null;
            }


        }

        public void MapObject(ref mLocacao source, ref mLocacao destination)
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
