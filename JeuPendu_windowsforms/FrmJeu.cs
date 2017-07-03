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
using Utilitaires;



namespace JeuPendu_windowsforms
{
    public partial class FrmJeu : Form
    {

        public FrmJeu()
        {
            InitializeComponent();
        }



        #region Manche

        Manche manche = new Manche();
        Score score = new Score();
        Pioche pioche = new Pioche();

        // a remplacer par l'appel de la méthode d'extraction créée par Fazia.

        enum EtatManche
        {
            DebutManche = 0,
            FinManche = 1
        }

        void GestionnaireManche(EtatManche etatManche)
        {
            //j'efface les erreurs précédente


            switch (etatManche)
            {
                case EtatManche.DebutManche:
                    manche.NbErreurs = 0;
                    manche.NumManche++;
                    txtb_numManche.Text = (manche.NumManche).ToString();
                    manche.InitialiserMotEnCours();

                    txtb_MotenCours.Text = Manche.ChartoString(manche.MotEnCours);
                    txtB_nbEssaisRestants.Text = manche.CalculEssaisRestants().ToString();
                    btn_Start.Enabled = true;

                    break;

                case EtatManche.FinManche:
                    timer1.Enabled = false;
                    if (!manche.IsPartieOver())
                    {
                        GestionnaireManche(EtatManche.DebutManche);
                    }
                    break;

            }


        }


        #region Evenements
        private void button20_Click(object sender, EventArgs e)
        {
            ep_jeu.SetError(txtb_MotenCours, string.Empty);
            btn_Start.Enabled = false;
            char lettre = Convert.ToChar((sender as Button).Text);
            if (manche.IsLettreDansMot(lettre))
            {
                txtb_MotenCours.Text = manche.DecouverteLettre(lettre);
                if (manche.IsMancheWin() & !manche.IsPartieOver())
                {
                    timer1.Stop();
                    manche.CalculScoreManche(manche.Temps, manche.NbErreurs);
                    MessageBox.Show(string.Format("Félicitations, vous avez remporté cette manche ! \n Score manche n°{0}: {1}points", manche.NumManche, manche.ScoreManche.ToString()), "Resultat", MessageBoxButtons.OK);
                    GestionnaireManche(EtatManche.FinManche);
                }
                else if (manche.IsMancheWin() & manche.IsPartieOver())
                    GestionnairePartie(EtatPartie.FinWin);
            }
            else
            {
                manche.NbErreurs++;

                if (manche.NbErreurs == manche.NbErreursMaxOk)
                {
                    GestionnairePartie(EtatPartie.FinPerdue);
                }
                else
                {
                    ep_jeu.SetError(txtb_MotenCours, string.Format("La lettre {0} ne fait pas partie du mot", (sender as Button).Text));
                    txtB_nbEssaisRestants.Text = manche.CalculEssaisRestants().ToString();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Start_Click(object sender, EventArgs e)
        {
            pn_clavier.Visible = true;
            // Déclenchement du chronomètre
            manche.DateDebut1 = DateTime.Now;
            manche.DateFin1 = manche.DateDebut1;
            timer1.Enabled = true;
            timer1.Start();
            // Initialisation du nombre d'erreur Max. A voir si on met ailleurs.
            manche.NbErreursMaxOk = 9;

            GestionnairePartie(EtatPartie.Debut);
            manche.MotATrouver = pioche.ExtraireMot();
            GestionnaireManche(EtatManche.DebutManche);
          


        }



        /// <summary>
        /// Evénement qui gère le fonctionnement et l'affichage du chronomètre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            manche.DateFin1 = manche.DateFin1.AddSeconds(1);
            manche.Temps = manche.CalculTemps(manche.DateDebut1, manche.DateFin1, manche.Temps);
            txtB_temps.Text = manche.Temps.ToString();
        }

        private void FrmJeu_Load(object sender, EventArgs e)
        {

            GestionnairePartie(EtatPartie.Debut);
            pioche.Load(MonApplication.DispositifSauvegarde, Properties.Settings.Default.CheminDico);
            ChargerListe();

        }
       public void ChargerListe()
        {
            foreach (var item in pioche)
            {
                listBox1.Items.Add(item);

            }
        }



        #endregion
        #endregion


        #region Partie

        enum EtatPartie
        {
            Debut = 0,
            FinWin = 1,
            FinPerdue = 2
        }
        void GestionnairePartie(EtatPartie etatPartie)
        {
            //j'efface les erreurs précédente
            ep_jeu.SetError(txtb_MotenCours, string.Empty);

            switch (etatPartie)
            {
                case EtatPartie.Debut:

                    manche.NumManche = 0;
                    manche.NbMancheMax = 2; //a remplacer par le nb défini par une propriété de la classe Option modifiable dans le FrmOption

                    break;

                case EtatPartie.FinWin:


                    btn_Start.Enabled = false;
                    if (score.scoreValide(manche.ScoresCumulés))
                    {
                        MessageBox.Show(string.Format("Félicitations, vous avez remporté la partie ! \n Nombre de manche :{0} \n Score : {1}points", manche.NumManche, manche.MoyenneScores.ToString()), "Resultat", MessageBoxButtons.OK);
                    }
                    Close();
                    break;

                case EtatPartie.FinPerdue:
                    timer1.Stop();
                    pn_clavier.Enabled = false;
                    manche.CalculScoreManche(manche.Temps, manche.NbErreurs);
                    manche.CalculScorePartie(manche.ScoresCumulés, manche.NbMancheMax);
                    MessageBox.Show(string.Format("Désolée, vous avez été pendu. Vous avez perdu la partie.\n Vous avez fait {0} manches sur les {1} de prévus avec un score de {3}", manche.NumManche, manche.NbMancheMax, manche.ScoresCumulés), "Perdu", MessageBoxButtons.OK);
                    Close();
                    break;
            }
        }
        #endregion



    }
}




