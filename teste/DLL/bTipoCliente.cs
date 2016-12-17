using MaisGamers.DAL;
using MaisGamers.DAL.Cadastro;
using MaisGamers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisGamers.DLL
{
    public class bTipoCliente
    {
        public List<mTipoCliente> CarregaTipoCliente()
        {
            dTipoCliente _dtipo = new dTipoCliente();
            return _dtipo.CarregaTipoCliente();
        }

        public decimal ConsultaUF(string uf)
        {

            dEstado _dEstado = new dEstado();
            try
            {

                return _dEstado.ConsultaUF(uf);
            }
            catch (Exception ex)
            {

                return -1;
            }
        }
    }
}
