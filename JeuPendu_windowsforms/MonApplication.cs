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
    }
}
