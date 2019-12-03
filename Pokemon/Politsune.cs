namespace RPokemonG
{
    class Politsune : Pokemon {
        public Politsune() : base() {
            espece = e_Pokemon.Politsune;
            types = new e_Type[] {e_Type.Electrique, e_Type.Glace};
            description = "Il génère de l’électricité en faisant tourner ses queues et se défend en envoyant des décharges à plus de 100 000 volts";
            talent = e_Talent.Motorise;
            pvBase = 70;
            attaqueBase = 75;
            defenseBase = 50;
            attaqueSpeBase = 105;
            defenseSpeBase = 85;
            vitesseBase = 115;
            capacitesApprenables = new e_Capacite[] {e_Capacite.Hate,
                                    e_Capacite.Laser_Glace,
                                    e_Capacite.Machouille,
                                    e_Capacite.Plenitude,
                                    e_Capacite.Pouvoir_Lunaire,
                                    e_Capacite.Tonnerre
                                    };
        }
    }
}