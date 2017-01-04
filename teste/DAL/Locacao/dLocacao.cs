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


        public List<dynamic> PesquisaLocacao(int idLocacao)
        {

            var db = new Contexto();

            try
            {


                var a = from x in db.LocacaoJogos
                        join z in db.Locacao on x.IDLocacao.IDLocacao equals z.IDLocacao
                        join y in db.Jogo on x.IDJogo.IDJogo equals y.IDJogo
                        where z.IDLocacao == idLocacao
                        select new  { ColunasGrid = "NomeJogo[200|Jogo];NomeConsole[150|Console];DataLocacao[150|Data Locação]", y.NomeJogo , y.IDConsole.NomeConsole, z.DataLocacao};



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
