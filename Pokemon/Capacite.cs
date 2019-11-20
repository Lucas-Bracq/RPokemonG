using UnityEngine;

namespace RPokemonG {

    public class Capacite {
        public string nom;
        public string categorie;
        public Type type;
        public int pp;
        public int puissance;
        public int precision;
        public string description;

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

        public void setType (Type type) { 
            this.type = type; 
        }

        public int getPP() {
            return pp;
        }

        public void setPP(int pp) { 
            this.pp = pp;  
        }

        public int getPuissance() {
            return puissance;
        }

        public void setPuissance(int puissance) { 
            this.puissance = puissance;  
        }

        public void utiliser(Pokemon cible) {
            cible.setPV(cible.getPv() - puissance);
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