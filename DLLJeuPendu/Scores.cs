

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

   //     List<Score> listJoueurs = new List<Score>();

       
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
      
     

        public void trierListe()
        {
           
            for (int i= 0; i < this.Count - 1; i++)
            {
                for (int j = i - 1; j < this.Count - 1; j++)
                {



                    Score tmp;
                    if (this[i].ScoreJoueur < this[j+1].ScoreJoueur)
                    {

                        do
                        {



                            tmp = this[i];
                            this[i] = this[i + 1];
                            this[i + 1] = tmp;

                        } while (this[i].ScoreJoueur < this[j + 1].ScoreJoueur);
                    }
                }
            }
        }


        public void Ajouter(Score score)
        {
            
          

            
            if (Count < 9)
            {

              
               
                this.Add(score);



                trierListe();
            }
            else
            {

                int pos = 0 ;
                for (int i = 0; i < this.Count; i++)
                {
                    if (this[i].ScoreJoueur <= score.ScoreJoueur)
                    {
                        int count = 0;
                        do
                        {
                            pos = i;
                        } while (count < 1);
                    }
                }
                this.RemoveAt(pos);
                this.Add(score);
                this.trierListe();

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



