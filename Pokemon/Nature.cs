using System;
using System.Collections.Generic;

namespace RPokemonG {
	abstract class Nature {

		//https://docs.microsoft.com/en-us/dotnet/standard/io/composing-streams?redirectedfrom=MSDN
        public static void setNature() {

            Dictionary<int, List<double>> nature = new Dictionary<int, List<double>>();
             
            string test = System.IO.File.ReadAllText(@"D:\TESTC#\test\testnature.txt");

            byte j = 0;
            byte k = 0;
            List<double> effet = new List<double>();
            for (byte i = 0; i < test.Length; ++i)
            {
                if (j == 5)
                {
                    nature.Add(k, effet);
                    ++k;                    
                    effet.Clear();
                    j = 0;
                }
                if (test[i] == '2') effet.Add(1.1);
                if (test[i] == '0') effet.Add(0.9);
                if (test[i] == '1') effet.Add(1.0);
                ++j;

                //List<double> effet = new List<double>();
                //effet.Add();
            }

            byte l = 0;
            foreach (List<double> i in nature.Values)
            {
                e_Nature nat = (e_Nature)l;
                Console.WriteLine(nat);
                foreach (double p in i)
                {
                    Console.WriteLine(p);
                }
                ++l;
            }

            Console.WriteLine();

            Console.ReadLine();
			
		}

		private double[] getEffet(){
            double[] effet = { 1.0, 1.0, 1.0, 1.0, 1.0 };
            return effet;
		} 
	}
}