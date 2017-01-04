using MaisGamers.Model;
using MaisGamers.Model.Locacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL.Locacao
{
    public class dLocacaoJogo
    {

        public bool InserirLocacaoJogo(mLocacaoJogos _mLocacaoJogos)
        {


            var db = new Contexto();

            try
            {

                _mLocacaoJogos.IDLocacao = db.Locacao.Find(_mLocacaoJogos.idLocacao);
                _mLocacaoJogos.IDJogo = db.Jogo.Find(_mLocacaoJogos.idJogo);

                db.LocacaoJogos.Add(_mLocacaoJogos);
                db.SaveChanges();





                return true;
            }
            catch (Exception ex)
            {

                return false;
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
