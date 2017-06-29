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
        int _nbManche;
        int _nbErreurs;
        DateTime DateDebut = new DateTime();
        DateTime DateFin = new DateTime();
        TimeSpan _temps = new TimeSpan();
        string _motATrouver;
        int _nbEssaisRestants;
        char[] motEnCours;
        int _numManche;

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

                _temps = DateFin1 - DateDebut1;
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
                value = "ANNACONDA";
                _motATrouver = value;
                MotEnCours = new char[_motATrouver.Length];
                for (int i = 0; i < _motATrouver.Length; i++)
                {
                    MotEnCours[i] = '_';
                }
            }
        }

        public int NumManche
        {
            get
            {
                return _numManche;
            }

            set
            {
                _numManche = value;
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

        public DateTime DateDebut1
        {
            get
            {
                return DateDebut;
            }

            set
            {
                DateDebut = value;
            }
        }

        public DateTime DateFin1
        {
            get
            {
                return DateFin;
            }

            set
            {
                DateFin = value;
            }
        }

        public char[] MotEnCours
        {
            get
            {
                return motEnCours;
            }

            set
            {
                motEnCours = value;
            }
        }

        public int NbErreursMaxOk
        {
            get
            {
                return _nbErreursMaxOk;
            }

            set
            {
                _nbErreursMaxOk = value;
            }
        }

        #endregion

        #region Méthodes
        /// <summary>
        /// Calcule le nombre d'essais restants au joueur. Renvoie 0, si le nb d'erreur max est atteint.
        /// </summary>
        /// <returns></returns>
        public int CalculEssaisRestants()
        {
            if (NbErreurs < NbErreursMaxOk)
            {
                _nbEssaisRestants = NbErreursMaxOk - _nbErreurs;
                return _nbEssaisRestants;
            }
            return 0;
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


            int NbOccurenceLettre = 0;

            for (int i = 0; i < MotATrouver.Length; i++)
            {
                //affiche la lettre si celle-ci est présente dans le mot
                if (_motATrouver[i] == lettre)
                {
                    MotEnCours[i] = lettre;
                    NbOccurenceLettre++;
                }

            }
            return new string(MotEnCours);

            #endregion
        }




        public bool IsMancheWin()
        {
            if (MotEnCours.ToString() == MotATrouver)
            {
                NumManche++;
                return true;
            }
            else
                return false;
        }
        public bool IsPartieOver()
        {
            if (NumManche == NbManche || NbErreurs == NbErreursMaxOk)
            {
                return true;
            }
            return false;
        }

    }
}