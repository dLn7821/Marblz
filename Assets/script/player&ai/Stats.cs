using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{

    public GameObject dead;
    public float enemyhealth;


    public float enemydefense;

    private float enemycurHealth;
    private void Start()
    {

        enemycurHealth = enemyhealth;

    }

    public void enemyDamage(Transform edamageOBJ, float edamageAmount)
    {
        edamageOBJ.GetComponent<Stats>().enemyTakeDamage(edamageAmount);
        Debug.Log("Health: " + enemycurHealth);
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
        // dead.SetActive(true);
        // Time.timeScale = 0f;
        Destroy(gameObject);
    }
}
