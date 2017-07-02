
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Data;
using System.Xml;
using System.Xml.XPath;

namespace DLLJeuPendu
{


    //si le score de la manche entre dans le classement , enrregistrer le score et le nom du joueur 
    //dans le fichier.
    //ressortir les 10 meilleurs scores
    //definir le score max et le score min 
    [Serializable()]

    public class Score
    {
        //
        private double _scoreJoueur;
        private DateTime date;
        private string _nomJoueur;

        private int limit = 10;



        public Score() { }

        public Score(double score, string nomJoueur)
        {

            this.ScoreJoueur = score;
           
            this.NomJoueur = nomJoueur;


        }



        public double ScoreJoueur
        {
            get
            {
                return _scoreJoueur;
            }

            set
            {
                _scoreJoueur = value;
            }
        }

        public string NomJoueur
        {
            get
            {
                return _nomJoueur;
            }

            set
            {
                _nomJoueur = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {


                date = DateTime.Now;



            }
        }







        /* fonction qui cree le fichier xml pour enregistrer la liste
         * d'objets (joueur,score...) si la liste est inferieur a 10 et
         * que le score du joueur est superieur au plus petit des 10
         * tant que le liste n'est pas a 10
         * et qui supprime le score le plus petit pour enregistrer le joueur joueur*/

        /*public void enregistrerJoueur(Score test)
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
            else if(xml.IndexOf("score") >= 20 && (test.ScoreJoueur > this.ScoreMin))
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
        //  }











        //fonction qui sort les 10 meilleurs scores du fichier xml


        //fonction qui va verrifier si le score d'un joueur entre dans le classement (10)
        // dans manche ?? pour simplifier if true new score ...
        /// <summary>
        /// 
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public  bool scoreValide(double score)
        {
            if (score < 10)
            {
                return false;
            }
            return true;
        }
    }
    

}
    




