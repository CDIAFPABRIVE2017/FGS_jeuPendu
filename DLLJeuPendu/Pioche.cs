using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Collections;
using System.Xml.Serialization;


namespace DLLJeuPendu
{
    public class Pioche : HashSet<string>
    {
        static listeInitiale _listeInitiale;
        static Pioche _pioche;

        public string ExtraireMot()
        {
            int x = 5;// A remplacer par définition d'un nombre aléatoire
            return this.ElementAt(x);
        }
        /// <summary>
        /// Traiter les caractères accentués
        /// traiter la casse et la longueur des mots
        /// </summary>
        /// <param name="chaineOrigine"></param>
        /// <returns></returns>

        public static bool TraiterMot(string chaineOrigine)
        {
            if (chaineOrigine == null || chaineOrigine.Trim().Length < 5 || chaineOrigine.Trim().Length > 25)
                return false;


            chaineOrigine = chaineOrigine.Normalize(NormalizationForm.FormD);
            StringBuilder motCanonique = new StringBuilder();
            foreach (char caractere in chaineOrigine)
            {
                if (char.IsLetter(caractere))
                {
                    motCanonique.Append(caractere);
                }
            }
            _listeInitiale.Add(motCanonique.ToString().ToUpper());

            return true;
        }

        public void Save(string pathRepData, IEnumerable objetASauvegarder)
        {

            string[] lstInitiale = new string[];
            FileStream File = new FileStream("dictionnaire.txt", FileMode.Create, FileAccess.Write);
            StreamWriter flux = new StreamWriter(File);
            for (int i = 0; i < _listeInitiale.Items.Count; i++)
            {
                flux.WriteLine(_listeInitiale.Items[i]);
            }
            flux.Close();
            File.Close();
        }
        public void Load(string pathRepData, Type typeACharger)
        {
            Object objet = null;

            string pathXmlDocument = string.Format("{0}\\{1}.Xml", pathRepData, typeACharger.FullName);
            using (FileStream fileStream = new FileStream(pathXmlDocument, FileMode.Open, FileAccess.Read, FileShare.Read))
            {

                XmlTextReader xmlTR = new XmlTextReader(fileStream);
                XmlSerializer xmlS = new XmlSerializer(typeACharger);

                objet = xmlS.Deserialize(xmlTR);
                xmlTR.Close();
                fileStream.Close();
            }

            //return objet as IEnumerable;
        }
        /// <summary>
        /// //ouverture du fichier cible en ecriture
        /// </summary>
        /// <param name="pathSrc"></param>
        /// <param name="pathCbl"></param>
        /// <param name="encodSrc"></param>
        /// <param name="encodCbl"></param>
        public static string EcrireFichier(string lst)
        {
            foreach (var item in lst)
            {
                _pioche.Add((item).ToString());
            }
            // Appeler la méthode Save //TODO
            ISauvegarde serialiseur = Pioche.DispositifSauvegarde;
        }


        /// <summary>
        /// Rechercher un mot dans le dictionnaire par son debut
        /// </summary>
        /// <param name="Dbt"></param>
        private void RechercherMot(string rMot) /////////////////////////////////////////////////////////////////////TODO
        {
            // Ensure we have a proper string to search for.
            if (rMot != string.Empty)
            {
                // Recherche d'un mot dans la liste et sauvegarde de son index
                int index = _listeInitiale.FindString(rMot);
                // Determine si l'index est valide et selectionne l'element correspodant
                if (index != -1)
                    _listeInitiale.SetSelected(index, true);
                else
                    return;
                //Exception ex:
                //MessageBox.Show("le mot n'existe pas dans la liste");
            }
        }


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
    }
}
