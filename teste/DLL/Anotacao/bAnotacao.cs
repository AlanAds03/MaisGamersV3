using MaisGamers.DAL.Anotacao;
using MaisGamers.Model.Anotacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Anotacao
{
    public class bAnotacao
    {
        public bool Inserir(mAnotacao _anotacao)
        {
            dAnotacao _dAnotacao = new dAnotacao();
            return _dAnotacao.Inserir(_anotacao);

        }

        public List<dynamic> ObterGrid(string descricao)
        {
            dAnotacao _dAnotacao = new dAnotacao();
            return _dAnotacao.ObterGrid(descricao);
        }
    }
}
