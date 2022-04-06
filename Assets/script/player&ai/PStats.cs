using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PStats : MonoBehaviour
{
    public GameObject dead;
    public static float playerhealth;

    public static float playerdefense;
    private static float playercurHealth;
    private void Start()
    {
        playercurHealth = playerhealth;

    }
    public void playerDamage(Transform damageOBJ, float damageAmount)
    {
        damageOBJ.GetComponent<PStats>().playerTakeDamage(damageAmount);
        Debug.Log("Health: " + playercurHealth);
    }

    public void playerTakeDamage(float amount)
    {
        if (playerdefense < amount)
        {
            playercurHealth -= (amount - playerdefense);
        }
        if (playercurHealth <= 0)
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
