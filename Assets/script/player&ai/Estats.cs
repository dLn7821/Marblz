using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estats : MonoBehaviour
{
    public float enemyhealth;

    public float enemydefense;
    private float enemycurHealth;
    private void Start()
    {
        enemycurHealth = enemyhealth;
    }

    public void enemyDamage(Transform damageOBJ, float damageAmount)
    {
        damageOBJ.GetComponent<Stats>().enemyTakeDamage(damageAmount);
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
        Destroy(gameObject);
    }
}
