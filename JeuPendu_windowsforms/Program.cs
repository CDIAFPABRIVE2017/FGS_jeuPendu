﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuPendu_windowsforms
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
       //     MonApplication.ScoresJeu.Load(MonApplication.DispositifSauvegarde, Properties.Settings.Default.PathData);
            Application.Run(new InterfaceMere());
        }
    }
}
