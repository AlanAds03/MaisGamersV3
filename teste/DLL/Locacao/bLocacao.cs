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

        public List<mLocacaoJogos> ObterJogos(int idLocacao)
        {
            dLocacao _dlocacao = new dLocacao();

            return _dlocacao.ObterJogos(idLocacao);
        }


        public mLocacao Obter(int idLocacao)
        {
            try
            {
                dLocacao _dLocacao = new dLocacao();

                return _dLocacao.Obter(idLocacao);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AtualizarDataPrevistaLocacao(int idLocaaco, DateTime dataPrevisao,double valorPagoLocacao)
        {
            try
            {
                dLocacao _dLocacao = new dLocacao();
                return _dLocacao.AtualizarDataPrevistaLocacao(idLocaaco, dataPrevisao, valorPagoLocacao);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool FinalizarLocacao(int idLocaaco, DateTime dataEntrega, double ValorPago)
        {
            try
            {
                dLocacao _dLocacao = new dLocacao();
                return _dLocacao.FinalizarLocacao(idLocaaco, dataEntrega, ValorPago);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool AtualizarValorPa(int idLocaaco, int Status)
        {
            try
            {
                dLocacao _dLocacao = new dLocacao();
                return _dLocacao.AtualizarStatus(idLocaaco, Status);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AtualizarStatus(int idLocaaco, int Status)
        {
            try
            {
                dLocacao _dLocacao = new dLocacao();
                return _dLocacao.AtualizarStatus(idLocaaco, Status);
            }
            catch (Exception)
            {

                throw;
            }
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



        public decimal PrevisaoPreco(int idLocacao,DateTime dataLocacao, DateTime dataEntrega, bool utilizaPromocao)
        {
            //Data Atual 11/02/2017 
            //entregar dia 13/02/2017 

            //Pegar quantos dias irá alugar .
            
            decimal PrecoTotal = 0;
            int dia = 0;
            

            //Desconsiderar Domingo
            while (dataLocacao < dataEntrega)
            {
                dataLocacao = dataLocacao.AddDays(1);

                if (dataLocacao.DayOfWeek != DayOfWeek.Sunday)
                {
                    dia += 1;
                }
            }

            dLocacao _dlocacao = new dLocacao();
            foreach (var xxx in _dlocacao.PesquisaLocacaoID(idLocacao))
            {

                if (xxx.NomeTipoJogo == "Digital")
                {
                    PrecoTotal += Convert.ToDecimal(xxx.PrecoDia1) * dia;
                }
                else
                {
                    if (dia == 0 ||  dia == 1)
                    {
                        PrecoTotal += Convert.ToDecimal(xxx.PrecoDia1);
                    }
                    else if (dia == 2)
                    {
                        PrecoTotal += Convert.ToDecimal(xxx.PrecoDia2);
                    }
                    else if (dia == 3)
                    {
                        PrecoTotal += Convert.ToDecimal(xxx.PrecoDia3);
                    }
                    else
                    {
                        PrecoTotal += (Convert.ToDecimal(xxx.PrecoDia3) + Convert.ToDecimal(xxx.PrecoDia1));
                    }
                }
            }
            return PrecoTotal;

        }





    }
}
