using MaisGamers.Model;
using MaisGamers.Model.Cadastro;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Data.Entity;

namespace MaisGamers.DAL
{
    public class dJogo
    {

        public List<mJogo> ConsultaJogos(mJogo _jogo)
        {


            try
            {
                using (var db = new Contexto())
                {
                    var a = (from p in db.Jogo
                             where p.NomeJogo == _jogo.NomeJogo && p.IDConsole == _jogo.IDConsole select p ).ToList();

                    a.Select(x => x.ColunasGrid = "NomeConsole;IDJogo");

                    return a;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }


        public bool IncluirJogo(mJogo Jogo)
        {
            try
            {
                using (var db = new Contexto())
                {

                    var TipoJogo = db.TipoJogo.Find(Jogo.cIDTipoJogo);
                    var Console = db.Console.Find(Jogo.cIdConsole);

                    Jogo.IDTipoJogo = TipoJogo;
                    Jogo.IDConsole = Console;
                    db.Jogo.Add(Jogo);
                    db.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool InserirJogo(mJogo jogo)
        {
            try
            {
                using (var db = new Contexto())
                {
                    if (jogo.IDJogo != 0)
                    {
                        db.Jogo.Attach(jogo);
                        db.Entry(jogo).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Jogo.Add(jogo);
                        db.SaveChanges();
                    }

                    db.SaveChanges();

                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public List<mJogo> PesquisaJogo(mJogo jogo, string order)
        {
            var db = new Contexto();
            mConsole _Console = new mConsole();

            try
            {

                if (jogo.cIdConsole != 0)
                {
                    _Console = db.Console.Find(jogo.cIdConsole);
                }

                //List<mJogo> listJogo = (from a in db.Jogo.Include("IDConsole").Include("IDTipoJogo")
                //                        //join b in db.Console on a.IDConsole.idConsole equals b.idConsole
                //                        //where (a.NomeJogo.Contains((string.IsNullOrEmpty(jogo.NomeJogo) ? a.NomeJogo : jogo.NomeJogo))) //&& 
                //                               //b.idConsole == 1)

                //                        select a).ToList();



                //List<mJogo> listJogo = (from a in db.Jogo
                //                       join b in db.TipoJogo on a.IDTipoJogo equals b
                //                       join c in db.Console on a.IDConsole equals c
                //                       select a).ToList();

                List<mJogo> listJogo = db.Jogo
                          .Include(x => x.IDTipoJogo)
                          .Include(y => y.IDConsole)
                          .Where(z=> z.NomeJogo.Contains((string.IsNullOrEmpty(jogo.NomeJogo) ? z.NomeJogo : jogo.NomeJogo)))
                          .Where(z => z.IDConsole.idConsole == (jogo.cIdConsole == 0 ? z.IDConsole.idConsole : jogo.cIdConsole))
                          .ToList();


                List<mJogo> nova = new List<mJogo>();

                 nova = listJogo.Select(x => { x.ColunasGrid = "IDJogo;NomeJogo;NomeConsolexx;PrecoVenda;rTipoJogo;"; x.NomeConsolexx = x.IDConsole.NomeConsole;x.rTipoJogo = x.IDTipoJogo.NomeTipoJogo; return x; }).ToList();


                return nova.ToList();


            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}
