

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Data;
using System.Runtime.Serialization;
using System.Xml;
using System;
using System.Xml;
using System.Xml.XPath;
using Utilitaires;

namespace DLLJeuPendu
{
    public class Scores :List<Score>, ICollectionMetier
    {
        private double _scoreMin;
        private double _scoreMax;

        List<Score> listJoueurs = new List<Score>();
        public double ScoreMin
        {
            get
            {
                double _scoreMin = 1000;
                for (int i = 0; i < this.Count; i++)
                {
                    if (this[i].ScoreJoueur < _scoreMin)
                    {
                        _scoreMin = this[i].ScoreJoueur;
                    }

                }
                return _scoreMin;
            }

            set
            {
                _scoreMin = value;
            }
        }

        public double ScoreMax
        {
            get
            {
                double _scoreMax = 0;
                for (int i = 0; i < this.Count; i++)
                {
                    if (this[i].ScoreJoueur > _scoreMax)
                    {
                        _scoreMax = this[i].ScoreJoueur;
                    }
                }
                return _scoreMax;
            }

            set
            {
                _scoreMax = value;
            }
        }

       

        public void ajouterJoueur(Score joueur)
        {
            if (this.Count > 9)
            {
                Console.WriteLine("Vous ne faites pas partie des 10 meilleurs scores");
            }
                this.Add(joueur);
        }

        /// <summary>
        /// 
        /// </summary>
        public void enregistrerJoueur(Score test)
        {


            if (!File.Exists("scores.xml"))
            {
                using (FileStream fsCreate = new FileStream("scrores.xml", FileMode.Create))
                {
                    fsCreate.Close();
                }
            }
            XPathDocument document = new XPathDocument("scores.xml");
            XPathNavigator navigator = document.CreateNavigator();

            // Save the entire input.xml document to a string.
            string xml = navigator.OuterXml;

            if ((xml.IndexOf("score") < 20))
            {
                listJoueurs.Add(test);
                XmlSerializer xs = new XmlSerializer(typeof(Score));
                FileStream fs = new FileStream("scores.xml", FileMode.Open, FileAccess.ReadWrite);

                xs.Serialize(fs, test);
                StreamWriter sr = new StreamWriter(fs);
                xs.Serialize(fs, listJoueurs);
                sr.WriteLine(xs);
                fs.Close();
            }
            else if (xml.IndexOf("score") >= 20 && (test.ScoreJoueur > this.ScoreMin))
            {
                //trouver le premier score inferieur au score du joueur le supprimer de la liste et insserrer 
                //le nouveau score (le liste sera triee apres)
                FileStream replace = new FileStream("scores.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer serial = new XmlSerializer(typeof(Score));
                serial.Deserialize(replace);





            }




            /*FileStream replace = new FileStream("scores.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer serial = new XmlSerializer(typeof(Score));
            serial.Deserialize(replace);*/
            //selectionner le premier score inferieur a int score et le supprimer
        }

        public void ajouter(Score score)
        {
            if (!File.Exists("scores.xml"))
            {
                using (FileStream fsCreate = new FileStream("scrores.xml", FileMode.Create))
                {
                    fsCreate.Close();
                }
            }

            //this.Load("scrores.xml", Score score);




            if (listJoueurs.Count < 9)
            {
                listJoueurs.Add(score);
                XmlSerializer xs = new XmlSerializer(typeof(Score));
                FileStream fs = new FileStream("scores.xml", FileMode.Open, FileAccess.ReadWrite);

                xs.Serialize(fs, listJoueurs);
                StreamWriter sr = new StreamWriter(fs);
                xs.Serialize(fs, listJoueurs);
                sr.WriteLine(xs);
                fs.Close();
            }
            else if(listJoueurs.Count >= 9)
            {
                for (int i = 0; i < listJoueurs.Count ; i++)
                {
                    if (listJoueurs[i].ScoreJoueur <= score.ScoreJoueur)
                    {
                        int count = 0;
                        do
                        {
                            listJoueurs.Remove(listJoueurs[i]);
                        } while (count < 1);
                    }
                }
                    listJoueurs.Add(score);
                    
            }
        }
            
        public void afficherListe()
        {

            FileStream replace = new FileStream("scores.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer serial = new XmlSerializer(typeof(Score));
            serial.Deserialize(replace);



        }

        public  bool verifScore(double score)
        {
            if (score >= this.ScoreMin)
            {
                return true;
            }

            return false;
        }

        public void Save(ISauvegarde sauvegarde, string pathRepData)
        {
            sauvegarde.Save(pathRepData, this);
        }

        public void Load(ISauvegarde sauvegarde, string pathRepData)
        {
            Scores scores = sauvegarde.Load(pathRepData, this.GetType()) as Scores;
            if (scores != null)
            { this.AddRange(scores); };
        }
    }
  }



