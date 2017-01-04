using MaisGamers.DAL.Locacao;
using MaisGamers.Model.Locacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Locacao
{
    public class bLocacaoJogo
    {

        public bool InserirLocacaoJogo(mLocacaoJogos _mlocacao)
        {
            dLocacaoJogo _dlocacao = new dLocacaoJogo();

            return _dlocacao.InserirLocacaoJogo(_mlocacao);

        }
    }
}
