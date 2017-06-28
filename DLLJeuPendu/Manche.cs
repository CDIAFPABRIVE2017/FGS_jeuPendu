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
        TimeSpan _temps;
        string _motATrouver;
        int _nbEssaisRestants;

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
        private bool IsLettreDansMot(char Lettre)
        {

            for (int i = 0; i < MotATrouver.Length; i++)
            {
                if (MotATrouver[i] == Lettre)
                {
                    return true;
                }
            }
            return false;
        }
        private string Decouverte()
        {
            char[] motEnCours = new char[MotATrouver.Length];
            char[] motTampon = new char[MotATrouver.Length];

            return motEnCours.ToString();

            #endregion
        }
    }
}