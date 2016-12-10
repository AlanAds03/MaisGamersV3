using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.Model.Cadastro
{
    public class mJogo
    {
        public int IDJogo { get; set; }
        public int NomeJogo { get; set; }
        public mConsole IDConsole { get; set; }
        public mTipoJogo IDTipoJogo { get; set; }
        public int MyProperty { get; set; }

    }
}
