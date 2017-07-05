using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitaires;
using DLLJeuPendu;

namespace JeuPendu_windowsforms
{
  public static  class MonApplication
    {
        static ISauvegarde _dispositifSauvegarde = new SauvegardeXML();
        static Scores _scoresJeu = new Scores();
        static Pioche _pioche = new Pioche();
        static Manche _manche = new Manche();
        static Score _score = new Score();
       
        
        public static ISauvegarde DispositifSauvegarde
        {
            get { return MonApplication._dispositifSauvegarde; }
        }

        public static Scores ScoresJeu
        {
            get
            {
                return _scoresJeu;
            }

          
        }
        public static Pioche Pioche
        {
            get
            {
                return _pioche;
            }
        }
        

        public static Manche Manche
        {
            get
            {
                return _manche;
            }

            
        }

        public static Score Score
        {
            get
            {
                return _score;
            }

            set
            {
                _score = value;
            }
        }
    }
}
