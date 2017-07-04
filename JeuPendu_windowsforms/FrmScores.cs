using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitaires;
using DLLJeuPendu;

namespace JeuPendu_windowsforms
{
    public partial class FrmScores : Form
    {
        Scores scores = MonApplication.ScoresJeu;
        public FrmScores()
        {
            InitializeComponent();
        }
        private void FrmScores_Load(object sender, EventArgs e)
        {
            SauvegardeXML sauvegarde = new SauvegardeXML();
            Score azerty2 = new Score(777, "aaaaaaaaaaa");
            scores.Load(sauvegarde, Properties.Settings.Default.PathData);

            listbx_scores.Sorted = true;
            chargerListBox();


        }

        private void chargerListBox()
        {   // chargement de la liste box 
            listbx_scores.Items.Clear();
            listbx_pseudos.Items.Clear();

            foreach (var Item in scores)
            {
                listbx_scores.Items.Add(Item.ScoreJoueur);
                listbx_pseudos.Items.Add(Item.NomJoueur);
                listBox_date.Items.Add(Item.Date);
            }
            listbx_scores.Visible = listbx_scores.Items.Count > 0;
            listbx_pseudos.Visible = listbx_pseudos.Items.Count > 0;
            listbx_pseudos.Visible = listBox_date.Items.Count > 0;

        }

        private void listbx_scores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
