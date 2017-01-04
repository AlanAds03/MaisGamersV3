using MaisGamers.DAL.Locacao;
using MaisGamers.Model.Locacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Locacao
{
    public class bLocacao
    {

        public int InserirLocacao(mLocacao _mlocacao)
        {
            dLocacao _dlocacao = new dLocacao();

            return _dlocacao.InserirLocacao(_mlocacao);

        }

        public List<dynamic> PesquisaLocacao(int idLocacao)
        {

            dLocacao _dlocacao = new dLocacao();

            return _dlocacao.PesquisaLocacao(idLocacao);

        }
    }
}
