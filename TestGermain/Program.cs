using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitaires;
using DLLJeuPendu;

namespace TestGermain
{
    class Program
    {
        static void Main(string[] args)
        {
            SauvegardeXML sauvegarde = new SauvegardeXML();
            Scores scores = new Scores();
            scores.Load(sauvegarde, Properties.Settings.Default.PathScores);
          
            scores.Ajouter(new Score() { NomJoueur = "Germain", ScoreJoueur = 1 });
            //scores.Ajouter(new Score() { NomJoueur = "Germain", ScoreJoueur = 2 });
            //scores.Ajouter(new Score() { NomJoueur = "Germain", ScoreJoueur = 3 });
            scores.trierListe();


            scores.Save(sauvegarde, Properties.Settings.Default.PathScores);



        }
    }
}
