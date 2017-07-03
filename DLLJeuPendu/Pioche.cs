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
        /// <summary>
        /// Rechercher un mot dans la liste par son debut
        /// </summary>
        /// <param name="_mot"></param>
        public List<int> RechercherMot(string _mot)
        {
            List<int> ind = new List<int>();
            for (int i = 0; i < this.Count - 1; i++)
            {
                if (this.ElementAt(i).Length >= _mot.Length)
                {
                    string debut = this.ElementAt(i).Substring(0, _mot.Length);
                    if (string.Equals(debut, _mot.ToUpper()))
                    {
                        ind.Add(i);

                    }
                }
            }
            return ind;
        }
        /// <summary>
        /// Extraire un mot du dictionnaire aléatoirement
        /// </summary>
        /// <returns></returns>
        public string ExtraireMot()
        {
            Random rd = new Random();
            int x = rd.Next(1, this.Count - 1);// Définition d'un nombre aléatoire random
            return this.ElementAt(x);
        }
        /// <summary>
        /// Vérifier la longueur des mots 
        /// </summary>
        /// <param name="chaineOrigine"></param>
        /// <returns></returns>
        public static bool IsMotCorrect(string chaineOrigine)
        {
            if (chaineOrigine == null || chaineOrigine.Trim().Length < 5 || chaineOrigine.Trim().Length > 25)
                return false;
            return true;
        }
        /// <summary>
        /// Traiter les caractères accentués
        /// traiter la casse 
        /// </summary>
        /// <param name="chaineOrigine"></param>
        /// <returns></returns>

        public static string TraiterMot(string chaineOrigine)
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

       
        /// <summary>
        /// Ajout de mots dans la liste (dictionnaire)
        /// </summary>
        /// <param name="mot"></param>
        /// <returns></returns>
        public bool AjouterMot(string mot)
        {
            return this.Add(TraiterMot(mot));
        }
        /// <summary>
        /// Suppression de mots du dictionnaire
        /// </summary>
        /// <param name="mot"></param>
        /// <returns></returns>
        public bool SupprimerMot(string mot)
        {
            return this.Remove(mot);
        }

        /// <summary>
        /// Sauvegarde des modifications(ajout/suppression)
        /// </summary>
        /// <param name="sauvegarde"></param>
        /// <param name="pathRepData"></param>
        public void Save(ISauvegarde sauvegarde, string pathRepData)
        {
            sauvegarde.Save(pathRepData, this);
        }

       
        /// <summary>
        /// chargement du fichier passé en paramétre (pathRepData)
        /// </summary>
        /// <param name="sauvegarde"></param>
        /// <param name="pathRepData"></param>
        public void Load(ISauvegarde sauvegarde, string pathRepData)
        {
           Pioche ls = sauvegarde.Load( (pathRepData), this.GetType()) as Pioche;
            
           if (ls != null)
            {
                this.SymmetricExceptWith(ls);
            }

        }




        private bool TesterDoublon(string _mot)
        {
            bool doublon = false;
            if (this.Contains(_mot))
            {
                doublon = true;

            }

            return doublon;
        }

      
           
    }
}
