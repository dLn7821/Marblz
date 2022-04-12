using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estats : MonoBehaviour
{
    public float health;
    public float  curHealth;
    private void Start()
    {
        curHealth = health;
    }

    public void Damage(Transform damageOBJ, float damageAmount)
    {
        damageOBJ.GetComponent<PStats>().pTakeDamage(damageAmount);
    }

    public void eTakeDamage(float Amount)
    {
        curHealth -= Amount;
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
