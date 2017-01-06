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

        public List<dynamic> PesquisaLocacaoID(int idLocacao)
        {

            dLocacao _dlocacao = new dLocacao();

            return _dlocacao.PesquisaLocacaoID(idLocacao);

        }


        public List<dynamic> PesquisaLocacao(string NomeCliente, int Status)
        {

            dLocacao _dlocacao = new dLocacao();

            return _dlocacao.PesquisaLocacao(NomeCliente, Status);

        }


    }
}
