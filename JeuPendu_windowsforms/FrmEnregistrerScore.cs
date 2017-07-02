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
    public partial class FrmEnregistrerScore : Form

    {
        Manche manche = MonApplication.Manche;
        Scores scores = MonApplication.ScoresJeu;
        public FrmEnregistrerScore()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pn_enregistrer.Visible = true;
            txtb_score.Text = manche.MoyenneScores.ToString();

        }

        private bool IspseudoValid(string pseudo)
        {
            for (int i = 0; i < pseudo.Length; i++)
            {
                
                if ((pseudo.ToUpper().Trim()).Length < 3 || (pseudo.ToUpper().Trim()).Length > 20) return false;
                if (!char.IsLetterOrDigit(pseudo[i])) return false;
            }
            return true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtb_score, string.Empty);
            if (IspseudoValid(txt_pseudo.Text))
            {
                
              

                Score score = MonApplication.Score;
                score.NomJoueur = txt_pseudo.Text;
                score.ScoreJoueur = Convert.ToDouble(txtb_score.Text);
                scores.Ajouter(score);
                scores.Save(MonApplication.DispositifSauvegarde, Properties.Settings.Default.PathData);
                DialogResult resul = MessageBox.Show("Souhaitez-vous rejouer ?", "Rejouer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                switch (resul)
                {
                    
                    case DialogResult.OK:
                        this.Close();
                        InterfaceMere maman = new InterfaceMere();
                        FrmJeu jeu = new FrmJeu();
                        jeu.MdiParent = maman;
                        jeu.Show();
                        

                        break;
                    case DialogResult.Cancel:
                        Application.Exit();
                        break;
                    
                }




            }
            else
                errorProvider1.SetError(txt_pseudo, "Le pseudo n'est pas correct, \n il doit avoir entre 3 et 20 caractères \n et ne pas comporter de caractères spéciaux");
        }
    }
}
