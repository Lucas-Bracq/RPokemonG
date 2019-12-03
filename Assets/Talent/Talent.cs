namespace RPokemonG {

    class Talent {
        private e_Talent nom;
        private string description;

        public e_Talent getNom() {
            return nom;
        }

        public void setNom(e_Talent nom) { 
            this.nom = nom; 
        }

        public string getDescription() {
            return description;
        }

        public void setDescription(string description) {
         this.description = description; 
        }
    }
}