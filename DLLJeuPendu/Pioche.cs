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
           // _listeInitiale.Add(motCanonique.ToString().ToUpper());

            return true;
        }
       
            public void Save(string pathRepData, IEnumerable objetASauvegarder)
            {
                Type type = objetASauvegarder.GetType();

                string pathXmlDocument = string.Format("{0}\\{1}.Xml", pathRepData, type.FullName);
                using (FileStream fileStream = new FileStream(pathXmlDocument, FileMode.Create, FileAccess.Write, FileShare.Read))
                {
                    XmlTextWriter xmlTW = new XmlTextWriter(fileStream, Encoding.UTF8);
                    XmlSerializer xmlS = new XmlSerializer(type);
                    xmlS.Serialize(xmlTW, objetASauvegarder);
                    xmlTW.Close();
                    fileStream.Close();
                }
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
        public static void EcrireFichier(string lst)
        {
            foreach (var item in lst)
            {
         //       _pioche.Add((item.ToString()).ToString());
            }
            // Appeler la méthode Save //TODO
        //    ISauvegarde serialiseur = Pioche.DispositifSauvegarde;
        }
    }
    }
    

