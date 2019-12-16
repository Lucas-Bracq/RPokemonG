using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon : MonoBehaviour
{
    //public e_Pokemon espece;
    public string name;
    public e_Type type1;
    public e_Type type2;
    //private string description;
    /*public e_Nature nature;
    public e_Talent talent;
    public e_Statut statut;*/
    public int baseHp;
    public int currentHp;

    public int attaqueBase;
    public int attaqueSpeBase;
    public int defenseBase;
    public int defenseSpeBase;
    public int vitesseBase;
    public float precisionBase;
    public float esquiveBase;

    public bool TakeDamage(int damage)
    {
        currentHp -= damage;

        if (currentHp <= 0)
            return true;
        else
            return false;
    }
}

public enum e_Type
{
    none,
    Acier,
    Combat,
    Dragon,
    Eau,
    Electrique,
    Fee,
    Feu,
    Glace,
    Infomatique,
    Insecte,
    Normal,
    Plante,
    Poison,
    Psy,
    Roche,
    Sol,
    Spectre,
    Tenebres,
    Vol
}

public enum e_Pokemon
{
    Carbrelace,
    Diabreaumon,
    Flianobab,
    Pikatique,
    Polistune,
    Pyrizzai
}

public enum e_Statut
{
    Brulure,
    Gel,
    Poison,
    Paralysie,
}
public enum e_Talent
{
    Compilation,
    Griffe_Dure,
    Motorise,
    Prognathe,
    Rege_Force,
    Tete_de_Roc,
}

public enum e_Nature
{
    Assure,
    Bizarre,
    Brave,
    Calme,
    Discret,
    Docile,
    Doux,
    Foufou,
    Gentil,
    Hardi,
    Jovial,
    Lache,
    Malin,
    Malpoli,
    Mauvais,
    Modeste,
    Naif,
    Presse,
    Prudent,
    Pudique,
    Relax,
    Rigide,
    Serieux,
    Solo,
    Timide
}