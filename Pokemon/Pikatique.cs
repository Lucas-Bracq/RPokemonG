namespace RPokemonG
{
    class Pikatique : Pokemon {
        public Pikatique() : base() {
            espece = e_Pokemon.Pikatique;
            types = new e_Type[] {e_Type.Electrique, e_Type.Infomatique};
            description = "Il est né des expériences d’un scientifique sur des Pikachu";
            talent = e_Talent.Compilation;
            pvBase = 60;
            attaqueBase = 70;
            defenseBase = 50;
            attaqueSpeBase = 85;
            defenseSpeBase = 75;
            vitesseBase = 120;
            capacitesApprenables = new e_Capacite[] {e_Capacite.Casse_Brique,
                                    e_Capacite.Cybersecurite,
                                    e_Capacite.Hate,
                                    e_Capacite.Piratage,
                                    e_Capacite.Rayon_Signal,
                                    e_Capacite.Tonnerre,
                                    };
        }
    }
}