using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST};

public class BattleSysteme : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;

    public Transform enemyPodium;
    public Transform playerPodium;

    public BattleState state;

    public BattleHUD playerHUD;
    public BattleHUD enemyHUD;

    public Text dialogueText;

    Pokemon playerPoke;
    Pokemon enemyPoke;
    
    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetUpBattle());
    }

    IEnumerator SetUpBattle()
    {
        GameObject playerGO = Instantiate(player, playerPodium);
        playerPoke = playerGO.GetComponent<Pokemon>();

        GameObject enemyGO = Instantiate(enemy, enemyPodium);
        enemyPoke = enemyGO.GetComponent<Pokemon>();

        dialogueText.text = "Un " + enemyPoke.name + " sauvage apparait !";

        playerHUD.setHUD(playerPoke);
        enemyHUD.setHUD(enemyPoke);

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    IEnumerator PlayerAttack()
    {
        bool isDead = enemyPoke.TakeDamage(playerPoke.attaqueBase);
        enemyHUD.setHp(enemyPoke.currentHp);
        dialogueText.text = "C'est efficace !";

        yield return new WaitForSeconds(2f);

        if (isDead)
        {
            state = BattleState.WON;
            EndBattle();
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
    }

    IEnumerator EnemyTurn()
    {
        dialogueText.text = enemyPoke.name + " attaque !";

        yield return new WaitForSeconds(2f);

        bool isDead = playerPoke.TakeDamage(enemyPoke.attaqueBase);
        playerHUD.setHp(playerPoke.currentHp);

        yield return new WaitForSeconds(1f);

        if (isDead)
        {
            state = BattleState.LOST;
            EndBattle();
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
    }

    void PlayerTurn()
    {
        dialogueText.text = "Choisissez une action à effectuer : ";
    }

    void EndBattle()
    {
        if(state == BattleState.WON)
        {
            dialogueText.text = "Bravo, vous avez gagné le combat !";
        }else if(state == BattleState.LOST)
        {
            dialogueText.text = "Vous avez été vaincu !";
        }
    }

    public void OnAttackButton()
    {
        if(state != BattleState.PLAYERTURN)
            return;
       
        StartCoroutine(PlayerAttack());
    }
}
