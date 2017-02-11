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



        public decimal PrevisaoPreco(int idLocacao, DateTime dataEntrega, bool utilizaPromocao)
        {


            //Data Atual 11/02/2017 
            //entregar dia 13/02/2017 

            //Pegar quantos dias irá alugar .

            DateTime dataPrevista = System.DateTime.Now;
            int dia = 0;
            decimal total;

            //Desconsiderar Domingo
            while (dataPrevista < dataEntrega)
            {
                dataPrevista = dataPrevista.AddDays(1);

                if (dataPrevista.DayOfWeek != DayOfWeek.Sunday)
                {
                    dia += 1;
                }


            }




            dLocacao _dlocacao = new dLocacao();


            return _dlocacao.PesquisaLocacaoID(idLocacao);

        }





    }
}
