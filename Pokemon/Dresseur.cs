using System;

namespace RPokemonG { 
	
	class Dresseur { 
		public Pokemon[] ListePokemon = new Pokemon[3];
        /*
		public byte nbVictoire; 
		public byte nbDefaite; 
		*/

        public Pokemon[] getListePokemon() {
        	return ListePokemon; 
        }

        public void setListePokemon(Pokemon membre) {
			for (byte nbPokemon = 0; nbPokemon < ListePokemon.Length - 1; nbPokemon++)
			{
    			ListePokemon[nbPokemon] = membre; 
			}
        }

        public void display() {

        	for (byte nbPokemon = 0; nbPokemon < ListePokemon.Length - 1; nbPokemon++)
			{
				Console.WriteLine("Pokémon n°" + nbPokemon + 1 + " : " + ListePokemon[nbPokemon].getEspece() + "\n"); 
			}
        }
/*
        public void incrVictoire() {
        	if(on appel l'évènement gagner) {
        		nbVictoire += 1;
        	}
        } 

        public void displayNbVictoire() {
        	Console.WritLine(nbVictoire); 
        }

        public void incrDefaite() {
        	if(on appel l'évènement perdre) {
        		nbDdefaite += 1;
        	}
        } 

        public void displayNbDefaite() {
        	Console.WritLine(nbDefaite); 
        }
	}

*/
	}
}