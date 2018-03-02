using MaisGamers.Model;
using MaisGamers.Model.Anotacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL.Anotacao
{
    public class dAnotacao
    {

        public List<dynamic> ObterGrid(string descricao)
        {

            var db = new Contexto();
            try
            {

                var anotacao = db.Anotacao.Where(x => x.Descricao.Contains(descricao)).ToList();


                return anotacao.ToList<dynamic>();
                
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public bool Inserir(mAnotacao _anotacao)
        {

            var db = new Contexto();
            try
            {
                if (_anotacao.IDAnotacao == 0)
                {
                    db.Anotacao.Add(_anotacao);
                    db.SaveChanges();
                }
                else
                {
                    db.Entry(_anotacao).State = System.Data.Entity.EntityState.Modified;
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
