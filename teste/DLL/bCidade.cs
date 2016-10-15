using MaisGamers.DAL;
using MaisGamers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL
{
    public class bCidade
    {
        public List<mCidade> CarregaCidade(int _cEstado)
        {
            dCidade _dCidade = new dCidade();
            return _dCidade.CarregaCidade(_cEstado);
        }
    }
}
