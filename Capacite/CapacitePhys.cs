namespace RPokemonG{
    abstract class CapacitePhys : CapaciteDegats{
        public CapacitePhys() : base(){
            categorie = e_Categorie.Physique;
        }
        public new virtual void utiliser(Pokemon cible, Pokemon lanceur){
            base.utiliser(cible, lanceur);
        }

        private void setDegats(Pokemon cible, Pokemon lanceur, double coeff){
            cible.setCurrPv(cible.getCurrPv() - 
                (int)(((22 * lanceur.getCurrAttaque() * puissance) /
                (cible.getCurrDefense() * 50) + 2 ) * coeff));
        }
    }
}