using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        enum Nat
        {
            assure,
            bizarre,
            brave,
            calme,
            discret,
            docile,
            doux,
            foufou,
            gentil,
            hardi,
            jovial,
            lache,
            malin,
            malpoli,
            mauvais,
            modeste,
            naif,
            presse,
            prudent,
            pudique,
            relax,
            rigide,
            serieux,
            solo,
            timide
        };

        public static int NumNat (string nature)
        {
            int j = 0; 
            foreach (int i in Enum.GetValues(typeof(Nat)))
            {
                if (Enum.GetName(typeof(Nat), i) == nature)
                {
                    j = i; 
                    break;
                }
                else
                {
                    Console.WriteLine("La nature n'est pas valide"); 
                }
            }
            return j;
        } 

        public static List<double> getE(int indice, Dictionary<int, List<double>> dictionnaire)
        {
                foreach (int i in dictionnaire.Keys)
                {
                    if (i == indice)
                    {
                        return dictionnaire[i]; 
                    }
                }
            return null;
        }

        static void Main(string[] args)
        {
            Dictionary<int, List<double>> nature = new Dictionary<int, List<double>>();
             
            string test = System.IO.File.ReadAllText(@"D:\TESTC#\test\testnature.txt");

            byte j = 0;
            byte k = 0;
            byte i = 0;
            List<double> effet = new List<double>();
            for (; i < test.Length; ++i)
            {
                if (j == 5)
                {
                    nature.Add(k, effet);
                    ++k;                    
                    effet = new List<double>();
                    j = 0;
                }
                if (test[i] == '2') effet.Add(1.1);
                if (test[i] == '0') effet.Add(0.9);
                if (test[i] == '1') effet.Add(1.0);
                ++j;
            }

            byte l = 0;
            foreach (List<double> m in nature.Values)
            {
                Nat nat = (Nat)l;
                Console.WriteLine(nat);
                foreach (double p in m)
                {
                    Console.WriteLine(p);
                }
                ++l;
            }

            List<double> listeEffets; 
            listeEffets = getE(NumNat("brave"), nature);

            foreach (double p in listeEffets)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine(listeEffets);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
