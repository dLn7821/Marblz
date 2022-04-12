using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PStats : MonoBehaviour
{
    public GameObject dead;
    public float health;
    public float curHealth;
    private void Start()
    {
        curHealth =health+AddStats.hp;

    }
    public void Damage(Transform damageOBJ, float damageAmount)
    {
        damageOBJ.GetComponent<Estats>().eTakeDamage(damageAmount);
    }

    public void pTakeDamage(float amount)
    {
        curHealth -= amount;
        if (curHealth <= 0)
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
