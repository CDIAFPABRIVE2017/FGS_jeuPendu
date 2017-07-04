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
        int _nbMancheMax;
        int _nbErreurs;
        DateTime DateDebut = new DateTime();
        DateTime DateFin = new DateTime();
        TimeSpan _temps = new TimeSpan();
        string _motATrouver;
        int _nbEssaisRestants;
        char[] motEnCours;
        int _numManche;
        double _scoreManche;
        double _scoresCumulés;
        double _moyenneScores;

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

                _motATrouver = value;

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
                _nbErreursMaxOk = Convert.ToInt32(Properties.Resources.nbErreurMax);
                return _nbErreursMaxOk;
            }

            set
            {
                _nbErreursMaxOk = value;
            }
        }

        public double ScoreManche
        {
            get
            {
                return _scoreManche;
            }

            set
            {
                _scoreManche = value;
            }
        }

        public double ScoresCumulés
        {
            get
            {
                return _scoresCumulés;
            }

            set
            {
                _scoresCumulés = value;
            }
        }

        public double MoyenneScores
        {
            get
            {
                return _moyenneScores;
            }

            set
            {
                _moyenneScores = value;
            }
        }

        public int NbMancheMax
        {
            get
            {
                return _nbMancheMax;
            }

            set
            {
                _nbMancheMax = value;
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

        public static string ChartoString(char[] mot)
        {
            string retour = string.Empty;
            foreach (char item in mot)
            {
                retour += item;
            }
            return retour;

        }


        public bool IsMancheWin()
        {
            if (ChartoString(MotEnCours) == MotATrouver)
            {
                return true;
            }
            else
                return false;
        }
        public bool IsPartieOver()
        {
            if (NumManche > NbMancheMax || NbErreurs == NbErreursMaxOk)
            {
                return true;
            }
            return false;
        }
        public char[] InitialiserMotEnCours()
        {
            MotEnCours = new char[MotATrouver.Length];
            for (int i = 0; i < MotATrouver.Length; i++)
            {
                MotEnCours[i] = '_';
            }
            return MotEnCours;
        }
        #region Méthodes de calculs du score
        public double CalculScoreManche(TimeSpan temps, int nbErreurs)
        {
            if (IsMancheWin())
            {
                ScoreManche = Convert.ToInt32(Properties.Resources.nbPointsParSeconde) * (Convert.ToDouble(temps.TotalSeconds)) + Convert.ToInt32(Properties.Resources.nbPointsParErreurs) * nbErreurs;
                ScoresCumulés += ScoreManche;
            }
            else
                ScoreManche = 0;
            return ScoreManche;

        }
        public double CalculScorePartie(double scoresCumul, int nbManchesmax)
        {
            if (IsPartieOver())
            {
                _moyenneScores = scoresCumul / nbManchesmax;
            }
            else
                MoyenneScores = 0;
            return _moyenneScores;
        }
        #endregion

        #region Temps
        public TimeSpan CalculTemps(DateTime Début, DateTime Fin, TimeSpan temps)
        {
            temps = Fin - Début;
            return temps;

        }
        #endregion
        public bool IsNbManchesValid(string nbManche)
        {
            if (Convert.ToInt32(nbManche) > Convert.ToInt32(Properties.Resources.NbManchesMaxParPartie) | Convert.ToInt32(nbManche) < Convert.ToInt32(Properties.Resources.NbManchesMinParPartie))
            {
                return false;
            }
            else return true;
        }
    }
}