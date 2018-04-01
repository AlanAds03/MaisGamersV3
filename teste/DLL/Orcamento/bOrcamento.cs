using MaisGamers.DAL.Orcamento;
using MaisGamers.Model.Orcamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Orcamento
{
    public class bOrcamento
    {

        public mOrcamento Obter(int idOrcamento)
        {

            try
            {

                dOrcamento _d = new dOrcamento();

                return _d.Obter(idOrcamento);

            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<dynamic> PesquisarOrcamento(string cliente ,string produto, int idStatus)
        {
            try
            {
                dOrcamento _d = new dOrcamento();

                return _d.PesquisarOrcamento(cliente, produto, idStatus);

            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool Inserir(mOrcamento orcamento)
        {

            try
            {
                dOrcamento _d = new dOrcamento();

                return _d.Inserir(orcamento);

            }
            catch (Exception ex)
            {
                return false;
                throw;
            }
        }
    }

}
