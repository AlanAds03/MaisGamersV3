using MaisGamers.Model;
using MaisGamers.Model.Cadastro;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

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
                    var a = (from p in db.Jogo where p.NomeJogo == _jogo.NomeJogo && p.IDConsole == _jogo.IDConsole select p).ToList();
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

                var listJogo = db.Jogo.Where(x => x.NomeJogo.Contains(jogo.NomeJogo));
 

                return listJogo.ToList();


            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}
