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
        private Pioche _pioche =MonApplication.Pioche ;
        private string oChemin;


        #endregion

        public FrmPioche()
        {
            InitializeComponent();

        }

        #region Evénements 

        private void FrmPioche_Load(object sender, EventArgs e)
        {
            //  oChemin = Properties.Settings.Default.PathData;
            //   Chargement();
            ctl_lstInitiale.Sorted = true;
            CacherControles();

        }
        private void ChargerFichier(string path)
        {
            using (var fileStream = File.OpenRead(path))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    ChargerMots(line);
                }
                fileStream.Close();
                streamReader.Close();
            }
        }

        private void ChargerMots(string line)
        {
            string tampon = string.Empty;
            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsLetter(line[i]))
                {
                    tampon += line[i].ToString();
                }
                else
                {
                    if (Pioche.IsMotCorrect(tampon))
                    {
                        string motRetraite = Pioche.TraiterMot(tampon);
                        if(!estDoublon(motRetraite))
                        {
                            ctl_lstInitiale.Items.Add(motRetraite); }
                        
                    }
                    tampon = string.Empty;
                }
            }
            if (tampon.Length > 0)
            {
                if (Pioche.IsMotCorrect(tampon))
                {
                    string motRetraite = Pioche.TraiterMot(tampon);
                    if (!estDoublon(motRetraite))
                    {
                        ctl_lstInitiale.Items.Add(motRetraite);
                    }

                }
                tampon = string.Empty;
            }
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
                ctl_lstInitiale.Items.Remove(ctl_lstInitiale.SelectedItem);


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

                ChargerFichier(openFileDialog1.FileName);
                AfficherControles();

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

            if (!string.IsNullOrEmpty(_mot) && Pioche.IsMotCorrect(_mot))
            {
                if (!estDoublon(_mot))
                { 
                ctl_lstInitiale.Items.Add(Pioche.TraiterMot(_mot));
                }
                else
                {
                    MessageBox.Show(string.Format("{0} est déjà dans la liste!\n{1}", _mot, "Veuillez en saisir un autre mot"), "Tentative de doublon");
                }
                txtSaisie.Clear();
            }
            else
            {
                MessageBox.Show(string.Format("{0} n'est pas correct!\n{1}", _mot, "Veuillez en saisir un autre mot"), "Tentative de doublon");
            }
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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
        private bool estDoublon(string _mot)
        {
            foreach (var item in ctl_lstInitiale.Items)
            {
                if (item.ToString() == _mot)
                { return true;
                }
               
                    
            }
            return false;
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherControles();

        }


        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ctl_lstInitiale.Items.Count > 0)
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

        private void btnAlimenterPioche_Click(object sender, EventArgs e)
        {
            foreach (var item in ctl_lstInitiale.Items)
            {
                _pioche.AjouterMot(item.ToString());
            }
            _pioche.Save(MonApplication.DispositifSauvegarde, Properties.Settings.Default.PathData);
        }
        #endregion

        //private void btExtraire_Click(object sender, EventArgs e)
        //{
        //    txtSaisie.Text = _pioche.ExtraireMot();
        //}
    }
}












