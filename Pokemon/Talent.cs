using UnityEngine;

namespace RPokemonG {

    public class Talent {
        public string nom;
        public string description;

        public string getNom() {
            return nom;
        }

        public void setNom(string nom) { 
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