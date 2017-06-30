﻿using System;
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
        private string _mots;
        private string _debut;
        private Stream fsSrc;
        private bool encodSrc;
        private object srSrc;
        private Encoding encodCbl;
        private Stream writer;

        private HashSet<String> _listeInitiale = new HashSet<string>();
        #endregion
        public FrmPioche()
        {
            InitializeComponent();
            ChargerDictionnaire();
        }
        private void ChargerDictionnaire()
        {
            _pioche = new Pioche();
            // appel de la méthode load 
            // en utilisant 
           // _pioche.Load(Serialiseur, Properties.Settings.Default.PathData);
        }
        #region Proprietes 
        public int AjouterMot
        {
            get;
            set;
        }
        public bool isMotValide(string _mt)
        {
            // valeur null ou min ou max
            if (_mt == null || _mt.Trim().Length < 5 || _mt.Length > 25)
            {
                return false;
            }

            // verification des caracteres
            foreach (char c in _mt)
            {
                if (!char.IsLetter(c) & !char.IsWhiteSpace(c) & c != '-')
                    return false;
            }

            return true;

        }
        public int RetraiterMot
        {
            get;
            set;
        }
        public int ExtraireMot
        {
            get;
            set;
        }
        /// <summary>
        /// Ouverture de la boite de dialogue ouvrir un fichier 
        /// ouverture du fichier selectionné après click sur ok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new
                StreamReader(openFileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();

            }
            foreach (var item in _listeInitiale)
            {
                listeInitiale.Items.Add(item);
            }

        }
        #endregion

      
        ///// <summary>
        ///// Traiter les caractères accentués
        ///// traiter la casse et la longueur des mots
        ///// </summary>
        ///// <param name="chaineOrigine"></param>
        ///// <returns></returns>

        
        
        private void FrmPioche_Load(object sender, EventArgs e)
        {
            btnExclure.Visible = false;
            btnEnregistrer.Visible = false;
            btnPiocher.Visible = false;
            btnQuiter.Visible = false;
            lblDictionnaire.Visible = false;
            lblMotsImpropres.Visible = false;
            listeInitiale.Visible = false;
            Corbeille.Visible = false;
            txtSaisie.Visible = false;
        }

       
        
        
        private void ouvrirFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnPiocher.Visible = true;
            listeInitiale.Visible = true;
            lblDictionnaire.Visible = true;
            btnEnregistrer.Visible = true;
            btnQuiter.Visible = true;
        }
        /// <summary>
        /// Chargement du dictionnaire pour traitement
        /// trier, supprimer les mots non conformes aux normes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPiocher_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                string line;
                string tampon = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (char.IsLetter(line[i]))
                        {
                            tampon += line[i].ToString();
                        }
                        else
                        {
                        //    Pioche.TraiterMot(tampon);
                            tampon = string.Empty;
                        }
                    }
                    if (tampon.Length > 0)
                    {
                     //   Pioche.TraiterMot(tampon);
                        tampon = string.Empty;

                    }

                }

                reader.Close();
                foreach (var item in _listeInitiale)
                {
                    listeInitiale.Items.Add(item);
                }

            }
        }

        private void btnQuiter_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExclure_Click(object sender, EventArgs e)
        {
            string selectionner = listeInitiale.SelectedItem.ToString();
            Corbeille.Items.Add(selectionner);
        }

        private void supprimerMotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExclure.Visible = true;
            Corbeille.Visible = true;
            btnPiocher.Visible = true;
            listeInitiale.Visible = true;
            lblDictionnaire.Visible = true;
            btnEnregistrer.Visible = true;
            btnQuiter.Visible = true;
            lblMotsImpropres.Visible = true;
        }

        private void ajouterMotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSaisie.Visible = true;
            btnExclure.Visible = true;
            Corbeille.Visible = true;
            btnPiocher.Visible = true;
            listeInitiale.Visible = true;
            lblDictionnaire.Visible = true;
            btnEnregistrer.Visible = true;
            btnQuiter.Visible = true;
            lblMotsImpropres.Visible = true;
        }
    }
}












