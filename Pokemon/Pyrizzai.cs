namespace RPokemonG
{
    class Pyrizzai : Pokemon {
        public Pyrizzai() : base() {
            espece = e_Pokemon.Pyrizzai;
            types = new e_Type[] {e_Type.Feu};
            description = "Il embrase les deux lames dans son dos avec le frottement contre sa fourrure";
            talent = e_Talent.Griffe_Dure;
            pvBase = 100;
            attaqueBase = 105;
            defenseBase = 90;
            attaqueSpeBase = 75;
            defenseSpeBase = 60;
            vitesseBase = 80;
            capacitesApprenables = new e_Capacite[] {e_Capacite.Boutefeu,
                                    e_Capacite.Casse_Brique,
                                    e_Capacite.Danse_Lames,
                                    e_Capacite.Griffe_Acier,
                                    e_Capacite.Griffe_Ombre,
                                    e_Capacite.Lame_de_Feu,
                                    };
        }
    }
}