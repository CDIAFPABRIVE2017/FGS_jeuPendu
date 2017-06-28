
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

namespace DLLJeuPendu
{


    //si le score de la manche entre dans le classement , enrregistrer le score et le nom du joueur 
    //dans le fichier.
    //ressortir le nom et scores classes
    class Score
    {

        //
        private double _scoreJoueur;
        private string _nomJoueur;
        private int limit = 10 ;



        
        public Score() { }

        public Score(int score , string nomJoueur)
        {

            this.ScoreJoueur = score;
            this.NomJoueur = nomJoueur ;
           

        }


        Score test = new Score(1,"er");
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


        //fonction pour enregistrer un score et nom d'un joueur si le score est sup au min des 10 
        public void enregistrerJoueur(Score test)
        {


            if (!File.Exists("scores.Xml"))
            {
                using (FileStream fsCreate = new FileStream("scrores.Xml", FileMode.Create))
                {
                    fsCreate.Close();
                }
            }
            XmlSerializer xs = new XmlSerializer(typeof(Score));
            FileStream fs = new FileStream("scores.Xml", FileMode.Open, FileAccess.Write);
            xs.Serialize(fs, test);


            StreamWriter sr = new StreamWriter(fs);
            /*xs.Serialize(fs, test);*/
            sr.WriteLine(xs);
            fs.Close();

        }

        //fonction pour classer les scores des joueurs recuperees dans le fichier Xml 
        public void classement()
        {

            FileStream fs = new FileStream("scores.Xml", FileMode.Open, FileAccess.Read);


        }


        //fonction qui va verrifier si le score d'un joueur entre dans le classement (10)
        // dans manche ?? pour simplifier if true new score ...

        public static bool scoreValide(int score)
        {
            if (score < 10 )
            {
                return false;
            }
            return true;
        }


    }


}

