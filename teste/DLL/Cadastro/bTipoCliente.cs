using MaisGamers.DAL;
using MaisGamers.DAL.Cadastro;
using MaisGamers.Model.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL.Cadastro
{
    public class bTipoCLiente
    {
        public List<mTipoCliente> CarregaTipoCliente()
        {

            try
            {
                dTipoCliente _dTipoCliente = new dTipoCliente();

                return _dTipoCliente.CarregaTipoCliente();

            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
