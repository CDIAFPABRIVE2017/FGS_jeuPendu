using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace JeuPendu_windowsforms
{
    public partial class FrmPioche : Form
	{
        #region champs
        private string _mots;
        #endregion
        public FrmPioche()
		{
			InitializeComponent();
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
            { return false;
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
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }


        }
        #endregion

        public class Mot
        {
            public string Debut { get; set; }
            public string Description { get; set; }
           
        }
        /// <summary>
        /// créer une collection Dictionary
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, Mot> BuildDictionary()
        {
            return new Dictionary<string, Mot>
    {
        {"A",
            new Mot() { Debut = "A", Description="Assiduite"}},
        {"C",
            new Mot() { Debut="C", Description="Catastrophe"}},
        {"S",
            new Mot() { Debut="S", Description ="Scotland"}},
        {"T",
            new Mot() { Debut="T", Description="Tirailler"}}
    };
        }
        /// <summary>
        /// Rechercher un mot dans le dictionnaire par son debut
        /// </summary>
        /// <param name="Dbt"></param>
        private bool isFindInDictionary(string Dbt)
        {
            Dictionary<string, Mot> mots = BuildDictionary();

            if (mots.ContainsKey(Dbt) == false)
            {
                return false;
            }
            else
            {
                Mot ceMot = mots[Dbt];
                return true;
            }
        }


        //private void ChargerMots()
        //{
        //    mots = new Mots();
        //    ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
        //    utilisateurs.Load(serialiseur, Properties.Settings.Default.AppData);
        //    foreach (Utilisateur item in utilisateurs)
        //    {
        //        cbUtilisateurs.Items.Add(item.Identifiant);
        //    }
        //}
        private static string TraiterChaineMajSansAccent(string chaineOrigine)
        {

            chaineOrigine = chaineOrigine.Normalize(NormalizationForm.FormD);
            StringBuilder motCanonique = new StringBuilder();
            foreach (char caractere in chaineOrigine)
            {
                if (char.IsLetter(caractere))
                {
                    motCanonique.Append(caractere);
                }
            }
            return motCanonique.ToString().ToUpper();
        }

    }


}

