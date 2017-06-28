using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLLJeuPendu;

namespace testJeuPendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Manche Mot1= new Manche();
            Mot1.MotATrouver = "ANNACONDA";
            char lettre1 = 'N';
            bool result = Mot1.IsLettreDansMot(lettre1);
           string res= Mot1.DecouverteLettre(lettre1);
            bool win=Mot1.IsMancheWin();
            Console.WriteLine("islettredansmot={0},Motencours={1}, win={2}", result, res, win);
            Console.ReadLine();

            Manche Mot2 = new Manche();
            Mot2.MotATrouver = "PAPA";
            char lettre2 = 'P';

            
            Mot2.IsLettreDansMot(lettre2);
            

            
        }
    }
}
