namespace RPokemonG
{
    class Carbrelace : Pokemon {
        public Carbrelace() : base() {
            espece = e_Pokemon.Carbrelace;
            types = new e_Type[] {e_Type.Eau, e_Type.Glace};
            description = "Il utilise la glace carbonique qui sort de son dos pour aveugler et geler ses adversaires pour ensuite les attaquer";
            talent = e_Talent.Prognathe;
            pvBase = 80;
            attaqueBase = 100;
            defenseBase = 80;
            attaqueSpeBase = 100;
            defenseSpeBase = 60;
            vitesseBase = 90;
            capacitesApprenables = new e_Capacite[] {e_Capacite.Crocs_Givre,
                                    e_Capacite.Glace_Carbonique,
                                    e_Capacite.Hydrocanon,
                                    e_Capacite.Hydroqueue,
                                    e_Capacite.Machouille,
                                    e_Capacite.Vibrobscur
                                    };
        }
    }
}