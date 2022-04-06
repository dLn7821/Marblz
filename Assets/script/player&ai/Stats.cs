using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{

    public GameObject dead;
    public static float playerhealth;
    public float enemyhealth;

    public static float playerdefense;
    public float enemydefense;
    private static float playercurHealth;
    private float enemycurHealth;
    private void Start()
    {
        playercurHealth = playerhealth;
        enemycurHealth = enemyhealth;

    }
    public void playerDamage(Transform pdamageOBJ, float pdamageAmount)
    {
        pdamageOBJ.GetComponent<Stats>().playerTakeDamage(pdamageAmount);
        Debug.Log("Health: " + playercurHealth);
    }
    public void enemyDamage(Transform edamageOBJ, float edamageAmount)
    {
        edamageOBJ.GetComponent<Stats>().enemyTakeDamage(edamageAmount);
        Debug.Log("Health: " + enemycurHealth);
    }
    public void playerTakeDamage(float amount)
    {
        if (playerdefense < amount)
        {
            playercurHealth -= (amount - playerdefense);
            Debug.Log("pcurhealt: "+playercurHealth);
        }
        if (playercurHealth <= 0)
        {
            Die();


        }
    }
    public void enemyTakeDamage(float amount)
    {
        if (enemydefense < amount)
        {
            enemycurHealth -= (amount - enemydefense);

        }
        if (enemycurHealth <= 0)
        {
            Die();

        }
    }
    private void Die()
    {
        dead.SetActive(true);
        Time.timeScale = 0f;
        Destroy(gameObject);
    }
}
