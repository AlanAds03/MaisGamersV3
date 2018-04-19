using MaisGamers.DAL.Orcamento;
using MaisGamers.Model.Orcamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Orcamento
{
    public class bFotosOrcamento
    {
        public bool InserirFoto(mFotosOrcamento _fotosOrcamento)
        {
            dFotosOrcamento _dFotos = new dFotosOrcamento();

            return _dFotos.InserirFoto(_fotosOrcamento);

        }

        public List<Byte[]> BuscarFotos(int idFotoOrcamento)
        {
            dFotosOrcamento _dFotos = new dFotosOrcamento();

            return _dFotos.BuscarFotos(idFotoOrcamento);
        }
    }
}
