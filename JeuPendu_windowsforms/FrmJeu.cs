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
                    manche.NumManche++;
                    txtb_MotenCours.Text = manche.MotEnCours.ToString();
                    btn_Start.Enabled = true;

                    break;

                case EtatManche.Fin:
                    if (manche.IsMancheWin())
                    {
                        btn_Start.Enabled = false;

                        
                    }
                    else
                        MessageBox.Show("La Manche est perdue :'(", "Fin de Manche", MessageBoxButtons.OK);
                    break;

            }
        }
        #endregion
        #region Evenements
        private void button20_Click(object sender, EventArgs e)
        {
            GestionnaireManche(EtatManche.Debut);
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
                if(manche.NbErreurs==manche.NbErreursMaxOk)
                { pn_clavier.Enabled = true; }

            }
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            pn_clavier.Visible = true;
            manche.DateDebut1 = DateTime.Now;
            manche.NbErreursMaxOk = 9;
            txtB_nbEssaisRestants.Text = manche.CalculEssaisRestants().ToString();



            //timer1.Enabled = true;
            //timer1.Start();


        }
        
        #endregion
    }
    #endregion

    #region Partie
    enum EtatPartie
    {
        Debut = 0,
        Fin = 1
    }
    #endregion



    #region Evenements



    #endregion








    //private void timer1_Tick(object sender, EventArgs e)
    //{
    //    DateTime s_myCounter = new DateTime();
    //    s_myCounter.ToShortTimeString()=
    //    txtB_temps =manche.DateDebut1



}


