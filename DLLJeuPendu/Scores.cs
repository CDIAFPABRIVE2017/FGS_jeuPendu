using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DLLJeuPendu
{
    class Scores :List<Score>
    {





        List<Score> dixMeilleursScores = new List<Score>();


       

       

        public void verifierNombreScores()
        {
            for (int i = 0; i < dixMeilleursScores.Count; i++)
            {
                if ((dixMeilleursScores[i].ScoreJoueur < dixMeilleursScores[i+1].ScoreJoueur)
                     && (dixMeilleursScores[i + 1] <= dixMeilleursScores.Count))
                {

                }
            }
        }

        public void ajouterJoueur(Score joueur)
        {
            if (dixMeilleursScores.Count > 9)
            {
                Console.WriteLine("Vous ne faites pas partie des 10 meilleurs scores");
            }
                dixMeilleursScores.Add(joueur);
        }

        /// <summary>
        /// 
        /// </summary>
        public void trierListe()
        {
            //object[] tmp; 
            for (int i = 0; i < dixMeilleursScores.Count; i++)
            {
                for (int j = 0; j < dixMeilleursScores.Count - 1; j++)
                {

                    if (dixMeilleursScores[i].ScoreJoueur >  dixMeilleursScores[j+1].ScoreJoueur)
                    {
                        dixMeilleursScores[i] = dixMeilleursScores[i + 1];
                        dixMeilleursScores[i+1] = dixMeilleursScores[i -2];
                    }

                }
            }

        }
    }
}
