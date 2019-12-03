namespace RPokemonG
{
    class Diabreaumon : Pokemon {
        public Diabreaumon() : base() {
            espece = e_Pokemon.Diabreaumon;
            types = new e_Type[] {e_Type.Combat, e_Type.Tenebres};
            description = "Il tape sa tête violemment sur tout et n’importe quoi pour accroître sa puissance";
            talent = e_Talent.Tete_de_Roc;
            pvBase = 90;
            attaqueBase = 110;
            defenseBase = 60;
            attaqueSpeBase = 80;
            defenseSpeBase = 60;
            vitesseBase = 105;
            capacitesApprenables = new e_Capacite[] {e_Capacite.Casse_Brique,
                                    e_Capacite.Fracass_Tete,
                                    e_Capacite.Griffe_Ombre,
                                    e_Capacite.Machouille,
                                    e_Capacite.Sacrifice,
                                    e_Capacite.Traumatisme_Cranien
                                    };
        }
    }
}