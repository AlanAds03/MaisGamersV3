using MaisGamers.DAL.Locacao;
using MaisGamers.DLL.Locacao;
using MaisGamers.Model;
using MaisGamers.Model.Locacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DAL.Locacao
{
    public class dStatusLocacao
    {

        public List<mStatusLocacao> CarregaStatusLocacao()
        {

            var db = new Contexto();
            try
            {
                return db.StatusLocacao.ToList();

            }
            catch (Exception ex)
            {

                return null;
            }

        }

    }
}
