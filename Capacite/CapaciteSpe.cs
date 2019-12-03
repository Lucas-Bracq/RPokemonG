namespace RPokemonG{
    abstract class CapaciteSpe : CapaciteDegats{
        public CapaciteSpe() : base(){
            categorie = e_Categorie.Speciale;
        }
        public new virtual void utiliser(Pokemon cible, Pokemon lanceur){
            base.utiliser(cible, lanceur);
        }

        private void setDegats(Pokemon cible, Pokemon lanceur, double coeff){
            cible.setCurrPv(cible.getCurrPv() - 
                (int)(((22 * lanceur.getCurrAttaqueSpe() * puissance) /
                (cible.getCurrDefenseSpe() * 50) + 2 ) * coeff));
        }
    }
}