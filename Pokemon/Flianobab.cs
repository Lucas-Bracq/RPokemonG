namespace RPokemonG
{
    class Flianobab : Pokemon {
        public Flianobab() : base() {
            espece = e_Pokemon.Flianobab;
            types = new e_Type[] {e_Type.Plante, e_Type.Fee};
            description = "Il est au service des autres Pokemon qu’il apaise grâce aux pouvoirs des fleurs sur sa tête";
            talent = e_Talent.Rege_Force;
            pvBase = 120;
            attaqueBase = 60;
            defenseBase = 100;
            attaqueSpeBase = 80;
            defenseSpeBase = 110;
            vitesseBase = 40;
        }
    }
}