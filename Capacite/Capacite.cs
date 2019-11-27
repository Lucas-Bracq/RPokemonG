namespace RPokemonG {

    abstract class Capacite {
        protected e_Capacite nom;
        protected e_Categorie categorie;
        protected e_Type type;
        protected int pp;
        protected int precision;
        protected string description;

        public e_Capacite getNom() {
            return nom;
        }

        public void setNom(e_Capacite nom) {
            this.nom = nom; 
        }

        public e_Categorie getCategorie() {
            return categorie;
        }

        public void setCategorie(e_Categorie categorie) {
            this.categorie = categorie;  
        }

        public e_Type getType() {
            return type;
        }
        public void setType(e_Type type) {
            this.type = type;
        }

        public int getPP() {
            return pp;
        }

        public void setPP(int pp) { 
            this.pp = pp;  
        }

        public void utiliser(Pokemon cible, Pokemon lanceur) {
            --pp;
        }

        public int getPrecision() {
            return precision;
        }

        public void setPrecision(int precision) { 
            this.precision = precision;  
        }

        public string getDescription() {
            return description;
        }

        public void setDescription(string description) { 
            this.description = description; 
        }
        
    }
}