

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
using System.Collections;


namespace DLLJeuPendu
{

    [Serializable()]
    public class Scores :List<Score>, ICollectionMetier
    {
        private double _scoreMin;
        private double _scoreMax;
        object tmp;

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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="joueur"></param>
        ///  <param name="pathRepData"></param>


        public void ajouterJoueur(Score joueur)
        {

            if (!File.Exists("scores.xml"))
            {
                using (FileStream fsCreate = new FileStream("scores.xml", FileMode.Create))
                {
                    fsCreate.Close();
                }
            }

            FileStream replace = new FileStream("scores.xml", FileMode.Open, FileAccess.ReadWrite);
            XmlSerializer serial = new XmlSerializer(typeof(Score));
            if (replace.Length < 0)
            {
                serial.Deserialize(replace);
            }
            replace.Close();
            if (listJoueurs.Count > 9)
            {
                for (int i = 0; i < listJoueurs.Count; i++)
                {
                    if (listJoueurs[i].ScoreJoueur < joueur.ScoreJoueur)
                    {
                        int supp = 0;
                        do
                        {
                          listJoueurs.Remove(joueur);
                        } while (supp < 1);
                    }
                }
                listJoueurs.Add(joueur);
               
            }
            listJoueurs.Add(joueur);

            XmlSerializer xs = new XmlSerializer(typeof(Score));
            FileStream fs = new FileStream("scores.xml", FileMode.Open, FileAccess.ReadWrite);

            xs.Serialize(fs, listJoueurs);
            StreamWriter sr = new StreamWriter(fs);
            xs.Serialize(fs, listJoueurs);
            sr.WriteLine(xs);
            fs.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        public void enregistrerJoueur(Score test)
        {


            /*if (!File.Exists("scores.xml"))
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





            }*/




        }

        public void trierListe()
        {
           
            for (int i= 0; i < this.Count - 1; i++)
            {

                Score tmp = new Score();
                if (this[i].ScoreJoueur < this[i].ScoreJoueur)
                {
                    tmp = this[i];
                    this[i] = this[i + 1];
                    this[i + 1] = tmp;
                }
            }
        }
       

        public void ajouter(Score score)
        {
            if (!File.Exists("scores.xml"))
            {
                using (FileStream fsCreate = new FileStream("scores.xml", FileMode.Create))
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



