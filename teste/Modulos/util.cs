using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaisGamers.Modulos
{
    public class util
    {

        public static void CentralizaGrupo(System.Windows.Forms.GroupBox group)
        {

            int width = 0;
            int height = 0;
            try
            {

                width = Screen.PrimaryScreen.Bounds.Width;
                height = Screen.PrimaryScreen.Bounds.Height;

                group.Left = width / 2 - group.Width / 2;


            }
            catch (Exception ex)
            {

                throw;
            }



        }
    }
}
