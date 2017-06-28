﻿
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

namespace DLLJeuPendu
{


    //si le score de la manche entre dans le classement , enrregistrer le score et le nom du joueur 
    //dans le fichier.
    //ressortir les 10 meilleurs scores
    //definir le score max et le score min 
    class Score
    {

        //
        private double _scoreJoueur;
        private DateTime date;
        private string _nomJoueur;
        private int limit = 10;



        public Score() { }

        public Score(int score, DateTime date, string nomJoueur)
        {

            this.ScoreJoueur = score;
            this.Date = date;
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
                date = value;
            }
        }


        //fonction pour enregistrer un score et nom d'un joueur si le score est sup au min des 10 
        public void enregistrerJoueur(object test)
        {


            if (!File.Exists("scores.xml"))
            {
                using (FileStream fsCreate = new FileStream("scrores.xml", FileMode.Create))
                {
                    fsCreate.Close();
                }
            }

            XmlSerializer xs = new XmlSerializer(typeof(Score));
            FileStream fs = new FileStream("scores.xml", FileMode.Open, FileAccess.ReadWrite);
            //XmlSerializer serial = new XmlSerializer(typeof(Score));
            //serial.Deserialize(fs);

            XPathDocument document = new XPathDocument("scores.xml");
            XPathNavigator navigator = document.CreateNavigator();

            // Save the entire input.xml document to a string.
            string xml = navigator.OuterXml;

            if (xml.IndexOf("score") > 20 )
            {

                xs.Serialize(fs, test);
                StreamWriter sr = new StreamWriter(fs);
                /*xs.Serialize(fs, test);*/
                sr.WriteLine(xs);
                fs.Close();
            }
          
            fs.Close();
        }
        /*else
        {

            Console.Write("erreur bool score min max");
        }*/

    


        //fonction qui sort les 10 meilleurs scores du fichier xml
        public void afficherScoresJoueurs()
        {

            FileStream fs = new FileStream("scores.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer serial = new XmlSerializer(typeof(Score));




            serial.Deserialize(fs);









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

