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
            MonApplication.Pioche.Load(MonApplication.DispositifSauvegarde, Properties.Settings.Default.PathData);
            InterfaceMere fenetreMere = new InterfaceMere();
            if (MonApplication.Pioche.Count < 5)
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
            MonApplication.ScoresJeu.Load(MonApplication.DispositifSauvegarde, Properties.Settings.Default.PathData);
            if (MonApplication.ScoresJeu.Count == 0)
            {
                DialogResult resu = MessageBox.Show("Il n'y a pas de joueur dans la liste", "Liste vide", MessageBoxButtons.OKCancel);
                switch (resu)
                {

                    case DialogResult.OK:
                        FrmJeu fJeu = new FrmJeu();
                        fJeu.MdiParent = fenetreMere;
                        fJeu.Show();
                        break;
                    case DialogResult.Cancel:
                        Application.Exit();
                        break;
                    default:
                        break;
                }
            }

            Application.Run(fenetreMere);
        }
    }
}
