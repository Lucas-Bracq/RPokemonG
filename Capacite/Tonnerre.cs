using System;

namespace RPokemonG{
    class Tonnerre : CapaciteSpe {
        public Tonnerre() : base(){
            nom = e_Capacite.Tonnerre;
            type = e_Type.Electrique;
            pp = 15;
            puissance = 90;
            precision = 100;
            description = "Une grosse décharge électrique tombe sur l'ennemi. Peut aussi le paralyser.";
        }

        public new void utiliser(Pokemon cible, Pokemon lanceur){ // changer la façon dont on récupère le lanceur
            base.utiliser(cible, lanceur);
        }
        private void setEffets(Pokemon cible, Pokemon lanceur){
            Random alea = new Random();
            int paralyser = alea.Next(100) + 1;
            if (paralyser <= 30) cible.setStatut(e_Statut.Paralysie);
        }
    }
}