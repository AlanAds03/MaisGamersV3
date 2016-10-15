using MaisGamers.DAL;
using MaisGamers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL
{
    public class bEstado
    {
        public List<mEstado> CarregaEstado()
        {
            dEstado _dEstado = new dEstado();
            return _dEstado.CarregaEstado();
        }
    }
}
