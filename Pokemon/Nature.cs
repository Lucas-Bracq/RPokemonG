using System;
using System.IO;

namespace RPokemonG {
	class Nature {

		//Map<Nature,double[5]> nature;

		//https://docs.microsoft.com/en-us/dotnet/standard/io/composing-streams?redirectedfrom=MSDN
        public void setNature() {
            byte i = 0;
            byte j = 0;
            char c = ';';
			string file = "../Fichier/nature.txt";
            //OUVERTURE FICHIER
			if(!File.Exists(file)){
				Console.WriteLine(file + " does not exist!");
            	return;
			}
            while (true) {
                while (c != ';') {
                    double[] effet;
                    while (c != ',') {
                        if (c == '2') effet[i] = 1.1;
                        else if (c == '0') effet[i] = 0.9;
                        else effet[i] = 1.0;
                        ++i;
                        //DEPLACEMENT CHAR DE LECTURE
                    }
                    //this.nature[i] = effet;
                    ++j;
                }
            }
        }

		private double[] getEffet(){
            double[] effet = { 1.0, 1.0, 1.0, 1.0, 1.0 };
            return effet;
		} 

		private enum Nat {
			assure,
			bizzare,
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
			timide,
		}
	}
}