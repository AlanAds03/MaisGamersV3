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

        public mLocacao Obter(int idLocacao)
        {
            var db = new Contexto();
            try
            {

                return db.Locacao.Include(x=> x.StatusLocacao).Include(x=> x.IDClienteLocacao).Where(x=> x.IDLocacao == idLocacao).FirstOrDefault();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public int InserirLocacao(mLocacao _mLocacao)
        {


            var db = new Contexto();

            try
            {

                _mLocacao.StatusLocacao = db.StatusLocacao.Find(1);
                _mLocacao.IDClienteLocacao = db.ClienteLocacao.Find(_mLocacao.idClienteLocacao);

                _mLocacao.DataLocacao = DateTime.Now;
                //_mLocacao.DataLocacaoEntrega = DateTime.Now;
                _mLocacao.DataPrevisaoEntrega = DateTime.Now;

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

        internal bool AtualizarStatus(int idLocaaco, int Status)
        {
            var db = new Contexto();
            mLocacao _locacao = new mLocacao();
            try
            {
                _locacao = db.Locacao.Find(idLocaaco);
                _locacao.StatusLocacao = db.StatusLocacao.Find(Status);

                db.Entry(_locacao).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        internal bool AtualizarDataPrevistaLocacao(int idLocaaco, DateTime dataPrevisao, double valorPagoLocacao)
        {
            var db = new Contexto();
            mLocacao _locacao = new mLocacao();
            try
            {
                _locacao = db.Locacao.Find(idLocaaco);

                _locacao.DataPrevisaoEntrega = dataPrevisao;
                _locacao.ValorPagoInicial = valorPagoLocacao;
                _locacao.StatusLocacao = db.StatusLocacao.Find(2);

               
                db.Entry(_locacao).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }



        internal bool FinalizarLocacao(int idLocaaco, DateTime dataEntrega, double valorPago)
        {
            var db = new Contexto();
            mLocacao _locacao = new mLocacao();
            try
            {
                _locacao = db.Locacao.Find(idLocaaco);

                _locacao.DataLocacaoEntrega = dataEntrega;
                _locacao.ValorPagoFinal = valorPago;
                _locacao.StatusLocacao = db.StatusLocacao.Find(3);


                db.Entry(_locacao).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
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

        public List<mLocacaoJogos> ObterJogos(int idLocacao)
        {

            List<mLocacaoJogos> lista = new List<mLocacaoJogos>();
            var db = new Contexto();
            try
            {
                lista = db.LocacaoJogos.Include(x => x.IDLocacao).Include(x=> x.IDJogo).Where(x => x.IDLocacao.IDLocacao == idLocacao).ToList();
                return lista;
            }
            catch (Exception)
            {

                return lista;
            }
        }

        public List<dynamic> BuscarPrecosJogos(int idLocacao)
        {
            var db = new Contexto();
            try
            {
                var a = from x in db.LocacaoJogos
                        join z in db.Locacao on x.IDLocacao.IDLocacao equals z.IDLocacao
                        join y in db.Jogo on x.IDJogo.IDJogo equals y.IDJogo
                        join w in db.PrecoLocacao on y.IDConsole equals w.IDConsole where (w.IDTipoJogo.IDTipoJogo == y.IDTipoJogo.IDTipoJogo)
                        join m in db.TipoJogo on y.IDTipoJogo.IDTipoJogo equals m.IDTipoJogo
                        where z.IDLocacao == idLocacao
                        select new { ColunasGrid = "PrecoDia1[100|1 Dia];PrecoDia2[100|2 Dia];PrecoDia3[100|3 Dia];NomeTipoJogo[100|Tipo]", w.PrecoDia1, w.PrecoDia2, w.PrecoDia3, m.NomeTipoJogo };

                return a.ToList<dynamic>();
            }
            catch (Exception)
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
                        //join w in db.PrecoLocacao on y.IDTipoJogo equals w.IDTipoJogo where(w.IDTipoJogo.IDTipoJogo == y.IDTipoJogo.IDTipoJogo)
                        join m in db.TipoJogo on y.IDTipoJogo.IDTipoJogo equals m.IDTipoJogo
                        where z.IDLocacao == idLocacao
                        select new  { ColunasGrid = "IDLocacaoJogo;NomeJogo[200|Jogo];NomeConsole[150|Console];DataLocacao[150|Data Locação];NomeTipoJogo[100|Tipo]", x.IDLocacaoJogo,y.NomeJogo , y.IDConsole.NomeConsole, z.DataLocacao, m.NomeTipoJogo };



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

