﻿using MaisGamers.Formularios;
using MaisGamers.Formularios.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaisGamers
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmPrincipal());
            Application.Run(new frmPrincipal());
            //Application.Run(new frmFoto());
        }
    }
}
