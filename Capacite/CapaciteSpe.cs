namespace RPokemonG{
    abstract class CapaciteSpe : Capacite{
        protected int puissance;
        public CapaciteSpe() : base(){
            this.categorie = "speciale";
        }
        public int getPuissance(){
            return puissance;
        }
        public virtual void utiliser(Pokemon cible){
            base.utiliser(cible);
        }
    }
}