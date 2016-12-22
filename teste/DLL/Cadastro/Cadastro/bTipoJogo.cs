using MaisGamers.DAL;
using MaisGamers.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Cadastro
{
    public class bTipoJogo
    {
        public List<mTipoJogo> CarregaTipoJogo()
        {

            try
            {
                dTipoJogo _dTipoJogo = new dTipoJogo();

                return _dTipoJogo.CarregaTipoJogo();

            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
