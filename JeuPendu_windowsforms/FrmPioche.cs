using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.IO;
using DLLJeuPendu;


namespace JeuPendu_windowsforms
{
    [Serializable]
    public partial class FrmPioche : Form
    {
        #region champs
        private Pioche _pioche;
        private string oChemin;
       
            
        #endregion

        public FrmPioche()
        {
            InitializeComponent();
           
        }
        
        #region Evénements 
             
        private void FrmPioche_Load(object sender, EventArgs e)
        {

            CacherControles();
            
        }

        private void btnQuiter_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //Suppression de mots
        private void btnExclure_Click(object sender, EventArgs e)
        {
            string _motselectionner = ctl_lstInitiale.SelectedItem.ToString();

            DialogResult dialogResult = MessageBox.Show("Etes vous sure de supprimer " + _motselectionner, "Suppression", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Corbeille.Items.Add(_motselectionner);
                if (_pioche.SupprimerMot(_motselectionner))
                    _pioche.Save(MonApplication.DispositifSauvegarde, oChemin);
                chargerListBox();
            }


        }

        private void ajouterMotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherControles();
        }

        /// <summary>
        ///Chargement du dictionnaire par le controle OpenFileDialog via la classe pioche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chargerDictionnaireToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                oChemin = openFileDialog1.FileName;
                Chargement();
            }
        }

        /// <summary>
        /// Ajout de mots au dictionnaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string _mot = txtSaisie.Text.Trim();
            if (!string.IsNullOrEmpty(_mot) && !_pioche.Contains(_mot.ToUpper()))
            {
                _pioche.AjouterMot(_mot);

                _pioche.Save(MonApplication.DispositifSauvegarde, oChemin);
                chargerListBox();
                txtSaisie.Clear();
            }
            else
            {
                MessageBox.Show(string.Format("{0} est déjà dans la liste!\n{1}", _mot, "Veuillez en saisir un autre mot"), "Tentative de doublon");
            }
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _pioche.Clear();
            ctl_lstInitiale.Items.Clear();
            CacherControles();
        }
        //Recherche d'un mot dans le dictionnaire
        private void btRecherche_Click(object sender, EventArgs e)
        {
            List<int> ind = _pioche.RechercherMot(txtSaisie.Text.Trim());
            ctl_lstInitiale.SelectedIndex = -1;
            if (ind.Count == 0)
            { MessageBox.Show("Le mot recherché n'existe pas dans la liste!"); }
            else
            {
                foreach (int indice in ind)
                    ctl_lstInitiale.SelectedIndex = indice; // selectionner l'élément trouvé.

            }




        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherControles();

        }
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _pioche.Save(MonApplication.DispositifSauvegarde, oChemin);
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_pioche.Count > 0)
            {
                txtSaisie.Visible = true;
                btnAjouter.Visible = true;
            }
            else
            {
                MessageBox.Show("charger un fichier !");
            }


        }
        #endregion

        #region Méthodes
        private void CacherControles()
        {
            foreach (Control ctrl in this.Controls)
                ctrl.Visible = false;

            this.menuStrip1.Visible = true;
            btnQuiter.Visible = true;
        }
        private void AfficherControles()
        {
            foreach (Control ctrl in this.Controls)
                ctrl.Visible = true;

            
        }
        //Chargement de la liste à partir du dictionnaire(fichier txt)
        private void Chargement()
        {
            _pioche = new Pioche();
           
            _pioche.Load(MonApplication.DispositifSauvegarde, oChemin);
            chargerListBox();
        }

        private void chargerListBox()
        {   // chargement de la liste box 
            ctl_lstInitiale.Items.Clear();

            foreach (var item in _pioche)
            {
                ctl_lstInitiale.Items.Add(item);

            }
            ctl_lstInitiale.Visible = ctl_lstInitiale.Items.Count > 0;
            this.Text = ctl_lstInitiale.Items.Count + " mots";
            //lblDictionnaire.Visible = true;
        }

        private void lblMotsImpropres_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //private void btExtraire_Click(object sender, EventArgs e)
        //{
        //    txtSaisie.Text = _pioche.ExtraireMot();
        //}
    }
}












