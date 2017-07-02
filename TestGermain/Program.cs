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
            Score azerty2 = new Score(777,"a");
            scores.Load(sauvegarde, Properties.Settings.Default.PathScores);

            scores.Ajouter(azerty2);


           

            scores.Save(sauvegarde, Properties.Settings.Default.PathScores);



        }
    }
}
