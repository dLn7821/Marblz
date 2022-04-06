using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemystats : MonoBehaviour
{
    public float health = -7;
    public float defense;

    private float curHealth;
    private void Start()
    {
        curHealth = health;
    }
    public void Damage(Transform damageObj, float damageAmount)
    {
        damageObj.GetComponent<enemystats>().TakeDamage(damageAmount);
        Debug.Log("Health: " + curHealth);
    }

    public void TakeDamage(float amount)
    {
        if (defense < amount)
        {
            curHealth -= (amount - defense);
        }
        if (curHealth <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
