using MaisGamers.DAL;
using MaisGamers.Model;
using MaisGamers.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL
{
    public class bConsole : IDisposable
    {
        public List<mConsole> CarregaConsole()
        {
            dConsole _dConsole = new dConsole();
            return _dConsole.CarregaConsole();
        }

        public void Dispose()
        {
            //this.Dispose();
        }
    }
}
