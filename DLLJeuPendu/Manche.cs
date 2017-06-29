using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLJeuPendu
{
    public class Manche
    {
        #region Champs
        int _nbErreursMaxOk;
        int _nbErreurs;
        TimeSpan _temps=new TimeSpan();
        string _motATrouver;
        int _nbEssaisRestants;
        char[] motEnCours;
        int _nbManche;

        #endregion


        #region Propriétés

        public int NbErreurs
        {
            get
            {
                return _nbErreurs;
            }

            set
            {
                _nbErreurs = value;
            }
        }

        public TimeSpan Temps
        {
            get
            {
                return _temps;
            }

            set
            {
                _temps = value;
            }
        }

        public string MotATrouver
        {
            get
            {
                
                return _motATrouver;
            }

            set
            {
                _motATrouver = value;
                motEnCours = new char[_motATrouver.Length];
                for (int i = 0; i < _motATrouver.Length; i++)
                {
                    motEnCours[i] = '_';
                }
            }
        }

        public int NbManche
        {
            get
            {
                return _nbManche;
            }

            set
            {
                _nbManche = value;
            }
        }

        #endregion

        #region Méthodes
        /// <summary>
        /// Calcule le nombre d'essais restants au joueur. Renvoie 0, si le nb d'erreur max est atteint.
        /// </summary>
        /// <returns></returns>
        private int? CalculEssaisRestants()
        {
            if (NbErreurs < _nbErreursMaxOk)
            {
                _nbEssaisRestants = _nbErreursMaxOk - _nbErreurs;
                return _nbEssaisRestants;
            }
            return null;
        }

        /// <summary>
        /// Détermine si la lettre proposée par le joueur est comprise dans le mot.
        /// </summary>
        /// <param name="Lettre"></param>
        /// <returns></returns>
        public bool IsLettreDansMot(char lettre)
        {

            for (int i = 0; i < MotATrouver.Length; i++)
            {
                if (MotATrouver[i] == lettre)
                {
                    return true;
                }
            }
            return false;
        }
       /// <summary>
       /// Remplace le '_' par la lettre si celle-ci est présente dans le mot.
       /// </summary>
       /// <param name="lettre"></param>
       /// <returns></returns>
      public string DecouverteLettre(char lettre)
        {
           
         
            int NbOccurenceLettre=0;

            for (int i = 0; i < MotATrouver.Length; i++)
            {
                //affiche la lettre si celle-ci est présente dans le mot
                if (_motATrouver[i] == lettre)
                {
                    motEnCours[i] = lettre;
                    NbOccurenceLettre++;
                }
               
            }
            return new string(motEnCours);

            #endregion
        }

       

        
       public bool IsMancheWin()
        {
            if (motEnCours.ToString() == MotATrouver)
            {
                NbManche++;
                return true;
            }
            else
                return false;
        }
        
    }
}