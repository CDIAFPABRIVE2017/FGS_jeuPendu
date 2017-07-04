using System;
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
            MonApplication.ScoresJeu.Load(MonApplication.DispositifSauvegarde, Properties.Settings.Default.PathData);
            MonApplication.Pioche.Load(MonApplication.DispositifSauvegarde, Properties.Settings.Default.PathData);
            InterfaceMere fenetreMere = new InterfaceMere();
            if (MonApplication.Pioche.Count<5)
            {
                DialogResult res = MessageBox.Show("Pas suffisamment de mots", "Insufficance de mots", MessageBoxButtons.OKCancel);
                switch (res)
                {
                    
                    case DialogResult.OK:
                        FrmPioche fPioche = new FrmPioche();
                        fPioche.MdiParent = fenetreMere;
                        fPioche.Show();
                        break;
                    case DialogResult.Cancel:
                        Application.Exit();
                        break;
                   
                    default:
                        break;
                }
            }
          //  MonApplication.Pioche.Load(MonApplication.DispositifSauvegarde, Properties.Settings.Default.CheminDico);
            Application.Run(fenetreMere);
        }
    }
}
