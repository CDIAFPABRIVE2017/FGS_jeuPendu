using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            InterfaceMere oMain = new InterfaceMere();
            MonApplication.Pioche.Load(MonApplication.DispositifSauvegarde,Properties.Settings.Default.PathData);
            
            if (MonApplication.Pioche.Count < 5)
            {
                DialogResult res = MessageBox.Show("Pas assez de mots.Ajoutez des mots", "Mots", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

                switch (res)
                {
                    
                    case DialogResult.OK:
                        FrmPioche oPioche = new FrmPioche();
                        oPioche.MdiParent = oMain;
                        oPioche.Show();
                        break;
                    case DialogResult.Cancel:
                        Application.Exit();
                        break;
                    
                }
            }

            Application.Run(oMain);
        }
    }
}
