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


        }

        private void chargerListBox()
        {   // chargement de la liste box 
            listbx_scores.Items.Clear();

            foreach (var item in scores)
            {
                listbx_scores.Items.Add(item);

            }
            listbx_scores.Visible = listbx_scores.Items.Count > 0;
            this.Text = listbx_scores.Items.Count + " mots";
            //lblDictionnaire.Visible = true;
        }

    }
}
