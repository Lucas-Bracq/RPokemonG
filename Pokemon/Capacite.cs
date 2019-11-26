namespace RPokemonG {

    class Capacite {
        protected string nom;
        protected string categorie;
        protected Type type;
        protected int pp;
        protected int precision;
        protected string description;

        public string getNom() {
            return nom;
        }

        public void setNom(string nom) {
            this.nom = nom; 
        }

        public string getCategorie() {
            return categorie;
        }

        public void setCategorie(string categorie) {
            this.categorie = categorie;  
        }

        public Type getType() {
            return type;
        }
        public void setType(Type type) {
            this.type = type;
        }

        public int getPP() {
            return pp;
        }

        public void setPP(int pp) { 
            this.pp = pp;  
        }

        public void utiliser(Pokemon cible) {
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

    enum Type {
        infomatique,
        fee,
        normal,
        feu,
        eau,
        plante,
        electrique,
        glace,
        combat,
        poison,
        sol,
        vol,
        psy,
        insecte,
        roche,
        spectre,
        dragon
    }
}