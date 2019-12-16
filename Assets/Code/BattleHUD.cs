using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    public Text nameText;
    public Slider hpSlider;

    public void setHUD(Pokemon pokemon)
    {
        nameText.text = pokemon.name;

        hpSlider.maxValue = pokemon.baseHp;
        hpSlider.value = pokemon.currentHp;
    }

    public void setHp(int hp)
    {
        hpSlider.value = hp;
    }
}
