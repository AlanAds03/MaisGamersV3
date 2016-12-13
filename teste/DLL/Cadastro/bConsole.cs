using MaisGamers.DAL;
using MaisGamers.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Cadastro
{
    public class bConsole
    {
        public List<mConsole> CarregaConsole()
        {

            try
            {
                dConsole _dConsole = new dConsole();

                return _dConsole.CarregaConsole();

            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
