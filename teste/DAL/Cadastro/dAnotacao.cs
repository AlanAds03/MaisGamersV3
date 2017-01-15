using MaisGamers.Model;
using MaisGamers.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL.Cadastro
{
    public class dAnotacao
    {

        


        public bool InserirAnotacao(mAnotacao _mAnotacao)
        {

            var db = new Contexto();


            try
            {

                db.Anotacao.Add(_mAnotacao);
                db.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
