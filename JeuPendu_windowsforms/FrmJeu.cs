using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLJeuPendu;


namespace JeuPendu_windowsforms
{
    public partial class FrmJeu : Form
    {

        public FrmJeu()
        {
            InitializeComponent();
        }
        Manche manche = new Manche() { MotATrouver = "ANNACONDA" };

        #region Manche

        #region Gestionnaire Etat Manche

        enum EtatManche
        {
            Debut = 0,
            Fin = 1
        }

        void GestionnaireManche(EtatManche etatManche)
        {
            //j'efface les erreurs précédente
            ep_jeu.SetError(txtb_MotenCours, string.Empty);

            switch (etatManche)
            {
                case EtatManche.Debut:
                    manche.NbErreurs = 0;
                    manche.NbManche1++;
                    txtb_numManche.Text = (++manche.NumManche).ToString();
                    txtb_MotenCours.Text = Manche.ChartoString(manche.MotEnCours);
                    txtB_nbEssaisRestants.Text = manche.CalculEssaisRestants().ToString();
                    btn_Start.Enabled = false;

                    break;

                case EtatManche.Fin:
                    timer1.Stop();
                    timer1.Enabled = false;
                    if (manche.IsMancheWin())
                    {
                        btn_Start.Enabled = true;

                        MessageBox.Show(string.Format("Félicitations, vous avez remporté cette manch ! \n Score :{0}", manche.ScoreManche.ToString()),"Resultat", MessageBoxButtons.OK);
                    }
                    break;
            }
            //else
            //   dialogue modal informe le joueur qu'il a partie.

           // break;

        }


        #endregion
        #region Evenements
        private void button20_Click(object sender, EventArgs e)
        {

            char lettre = Convert.ToChar((sender as Button).Text);
            if (manche.IsLettreDansMot(lettre))
            {
                txtb_MotenCours.Text = manche.DecouverteLettre(lettre);
                if (manche.IsMancheWin())
                {
                    GestionnaireManche(EtatManche.Fin);
                }
            }
            else
            {
                manche.NbErreurs++;
                txtB_nbEssaisRestants.Text = manche.CalculEssaisRestants().ToString();
                if (manche.NbErreurs == manche.NbErreursMaxOk)
                { pn_clavier.Enabled = false; }

            }
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            pn_clavier.Visible = true;
            manche.DateDebut1 = DateTime.Now;
            manche.DateFin1 = manche.DateDebut1;
            timer1.Enabled = true;
            timer1.Start();
            manche.NbErreursMaxOk = 9;

            GestionnaireManche(EtatManche.Debut);


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            manche.DateFin1 = manche.DateFin1.AddSeconds(1);
            txtB_temps.Text = manche.CalculTemps(manche.DateDebut1, manche.DateFin1, manche.Temps).ToString();
        }

        private void FrmJeu_Load(object sender, EventArgs e)
        {
            GestionnairePartie(EtatPartie.Debut);

        }


        #endregion

        #endregion

        #region Partie
        enum EtatPartie
        {
            Debut = 0,
            Fin = 1
        }
        #endregion
        void GestionnairePartie(EtatPartie etatPartie)
        {
            //j'efface les erreurs précédente
            ep_jeu.SetError(txtb_MotenCours, string.Empty);

            switch (etatPartie)
            {
                case EtatPartie.Debut:

                    manche.NumManche = 0;
                    manche.NbManche1 = 0;
                    break;

                case EtatPartie.Fin:

                    if (manche.IsPartieOver())
                    {
                        btn_Start.Enabled = false;

                        //dialogue modal informe du score de la manche

                    }
                    //else
                    //   dialogue modal informe le joueur qu'il a partie.

                    break;




            }
        }


    }
}



