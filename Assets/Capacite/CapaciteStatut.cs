namespace RPokemonG{
    abstract class CapaciteStatut : Capacite{
        public virtual void utiliser(Pokemon cible, Pokemon lanceur){
            base.utiliser(cible, lanceur);
        }
    }
}