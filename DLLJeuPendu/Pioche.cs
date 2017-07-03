using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Collections;
using System.Xml.Serialization;
using Utilitaires;

namespace DLLJeuPendu
{
    public class Pioche : HashSet<string>, ICollectionMetier
    {



        public string ExtraireMot()
        {
            int x = 5;// A remplacer par définition d'un nombre aléatoire random
            return this.ElementAt(x);
        }
        public static bool IsMotCorrect(string chaineOrigine)
        {
            if (chaineOrigine == null || chaineOrigine.Trim().Length < 5 || chaineOrigine.Trim().Length > 25)
                return false;
            return true;
        }

        public bool AjouterMot(string mot)
        {

            return this.Add(TraiterMot(mot));
        }
        /// <summary>
        /// Traiter les caractères accentués
        /// traiter la casse et la longueur des mots
        /// </summary>
        /// <param name="chaineOrigine"></param>
        /// <returns></returns>

        public string TraiterMot(string chaineOrigine)
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

        public void Save(ISauvegarde sauvegarde, string pathRepData)
        {
            sauvegarde.Save(pathRepData, this);
        }

        public void Load(ISauvegarde sauvegarde, string pathRepData)
        {
            Pioche pioche = sauvegarde.Load(pathRepData, this.GetType()) as Pioche;
            if (pioche != null)
            {
                this.SymmetricExceptWith(pioche);
            }
        }
            /// <summary>


            /// <summary>
            /// Rechercher un mot dans le dictionnaire par son debut
            /// </summary>
            /// <param name="Dbt"></param>
            //private void RechercherMot(string rMot) /////////////////////////////////////////////////////////////////////TODO
            //{
            //    // Ensure we have a proper string to search for.
            //    if (rMot != string.Empty)
            //    {
            //        // Recherche d'un mot dans la liste et sauvegarde de son index
            //        int index = this.FindString(rMot);
            //        // Determine si l'index est valide et selectionne l'element correspodant
            //        if (index != -1)
            //            _listeInitiale.SetSelected(index, true);
            //        else
            //            return;
            //        //Exception ex:
            //        //MessageBox.Show("le mot n'existe pas dans la liste");
            //    }
            //}

            //public void Save(ISauvegarde sauvegarde, string pathRepData)
            //{

            //}

            //public void Load(ISauvegarde sauvegarde, string pathRepData)
            //{

            //}


            //private void ChargerMots(string _mots) ///////////////////////////////////////////////////////////////////////////////////////////TODO
            //{
            //    // _mots = new Mots();
            //    ISauvegarde serialiseur = Pioche.DispositifSauvegarde;
            //    Pioche.Load(serialiseur, Properties.Settings.Default.AppData);
            //    foreach (Pioche item in _)
            //    {
            //        _listeInitiale.Items.Add(_mots);
            //    }
            //}
            //        private void ChargerMots(string _mots) ///////////////////////////////////////////////////////////////////////////////////////////TODO
            //        {

            //            If(_listeInitiale.ListCount)
            //                {
            //                _listeInitiale.Value = _mots;
            //    If Err Then
            //        Err.Clear
            //        ListBox1.AddItem(ComboBox1)
            //        ListBox1.Value = ListBox1.ListCount - 1
            //    Else
            //        MsgBox "Ce nom a déjà été ajouté à la liste!", vbExclamation, "Tentative de doublon"
            //    End If
            //Else
            //    ListBox1.AddItem(ComboBox1)
            //    ListBox1.Value = ListBox1.ListCount - 1
            //End If
            //cordialement
        }
    }
    