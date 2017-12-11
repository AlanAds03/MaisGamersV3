using MaisGamers.DAL;
using MaisGamers.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Cadastro.Cadastro
{
    public class bJogo : IDisposable
    {
        public void Dispose()
        {
            
        }

        public bool InserirJogo(mJogo jogo)
        {
            try
            {
                dJogo d = new dJogo();

                return d.IncluirJogo(jogo);

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ExcluirJogo(int idJogo)
        {
            try
            {
                dJogo d = new dJogo();

                return d.ExcluirJogo(idJogo);

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<mJogo> PesquisaJogo(mJogo jogo, string order)
        {
            try
            {
                dJogo d = new dJogo();
               

                return d.PesquisaJogo(jogo, order);
                

            }
            catch (Exception)
            {

                throw;
            }


        }

        internal mJogo PesquisaJogoID(int IDJogo)
        {
            try
            {

                dJogo _Jogo = new dJogo();

                return _Jogo.PesquisaJogoID(IDJogo);


            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
