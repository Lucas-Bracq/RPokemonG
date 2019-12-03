namespace RPokemonG{
    abstract class CapaciteStatut : Capacite{
        public new virtual void utiliser(Pokemon cible, Pokemon lanceur){
            base.utiliser(cible, lanceur);
        }
    }
}