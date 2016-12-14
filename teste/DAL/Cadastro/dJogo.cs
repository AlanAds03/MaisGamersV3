using MaisGamers.Model;
using MaisGamers.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL
{
    public class dJogo : IDisposable
    {

        public List<mJogo> ConsultaJogos(mJogo Jogo)
        {

            mJogo _jogo = new mJogo();
            try
            {
                using (var db = new Contexto())
                {
                    var a = (from p in db.Jogo where p.Jogo == Jogo.Jogo && p.Console == Jogo.Console select p).ToList();
                    return a;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public void Dispose()
        {
            this.Dispose();
        }

        public bool IncluirJogo(mJogo Jogo)
        {
            try
            {
                using (var db = new Contexto())
                {
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
                    if (jogo.idJogo != 0)
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

    }
}
