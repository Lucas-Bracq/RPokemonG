using System;

namespace RPokemonG{
    abstract class CapaciteDegats : Capacite{
        protected int puissance;
        public int getPuissance(){
            return puissance;
        }

        public virtual void utiliser(Pokemon cible, Pokemon lanceur){
            base.utiliser(cible, lanceur);
            Random alea = new Random();
            int reussite = alea.Next(100) + 1;  //number between 0 and 99 + 1

            if(reussite <= precision / cible.getEsquive() * lanceur.getPrecision()){    //L'attaque réussit
                int variation = alea.Next(85, 101); // Variation des dégâts
                double coeff = ((double)variation) / 100;
                if (type == lanceur.getType()[0] || (2 == lanceur.getType().Length && type == lanceur.getType()[1])) coeff *= 1.5; //STAB
                // TODO : efficacité attaque
                coeff *= impactTalent();
                coeff *= coupCritique();
                setDegats(cible, lanceur, coeff);
                if (cible.getCurrPv() == 0) setEffets(cible, lanceur);
            }
            else {
                Console.WriteLine("{0} ", cible, " évite l'attaque");
            }
        }

        private double coupCritique(){
            Random alea = new Random();
            int coupCritique = alea.Next(1, 25);
            if (coupCritique == 24) return 1.5;
            return 1.0;
        }

        private double impactTalent(){
            return 1.0;
            //TODO
        }

        private void setDegats(Pokemon cible, Pokemon lanceur, double coeff){
            //cible.setCurrPv(cible.getCurrPv() - (int)(((22 * lanceur.getCurrAttaqueSpe() * puissance) /(cible.getCurrDefenseSpe() * 50) + 2 ) * coeff));
        }
        private void setEffets(Pokemon cible, Pokemon lanceur){}
    }
}