using UnityEngine;

namespace RPokemonG{
    public class Tonnerre : CapaciteSpe {
        public Tonnerre() : base(){
            nom = "Tonnerre";
            type = electrique;
            pp = 15;
            puissance = 90;
            precision = 100;
            description = "Une grosse décharge électrique tombe sur l'ennemi. Peut aussi le paralyser.";
        }

        public override void utiliser(Pokemon cible, Pokemon lanceur){ // changer la façon dont on récupère le lanceur
            // Test: à redévelopper et intégrer dans une classe mère
            base.utiliser(cible);
            Random alea = new Random();
            int reussite = alea.Next(100) + 1;  //number between 0 and 99 + 1

            if(reussite <= precision / cible.getEsquive() * lanceur.getPrecision()){    //L'attaque réussit
                int variation = alea.Next(85, 101); // Variation des dégâts
                float coeff = ((float)variation) / 100;
                if (type == lanceur.GetType()) coeff *= 1.5; //STAB
                // TODO : efficacité attaque
                // TODO : impact talent
                int coupCritique = alea.Next(1, 25);
                if (coupCritique == 24) coeff *= 1.5;   // Coup Critique
                cible.setCurrPV(cible.getCurrPV() - (int)((22 * lanceur.getCurrAttaqueSpe() * puissance) /(cible.getCurrDefenseSpe() * 50) + 2 ) * coeff);
                if (cible.getCurrPv() > 0){
                    int paralyser = alea.Next(100) + 1;
                    if (paralyser <= 30) cible.setEtat(paralysie);
                }
            }
            else {
                Console.WriteLine("{0} ", id, " évite l'attaque");
            }
        }
    }
}