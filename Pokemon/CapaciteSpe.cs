using unityEngine;

namespace RPokemonG{
    public abstract class CapaciteSpe : Capacite{
        private int puissance;
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