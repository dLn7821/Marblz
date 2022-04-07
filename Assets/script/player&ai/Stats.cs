using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public GameObject dead;
    public GameObject Char;
    public float health;
    public float h;
    public static float phealth;
    public float ph;
    public float defense;
    public static float pdefense;
    private float curHealth;
    public static float pcurHealth;
    private void Start()
    {

        health = curHealth;
        phealth = pcurHealth + ph;

    }
    // public void get(Attribute attribute)
    // {
    //     if (string.Concat(attribute.type) == "Health")
    //     {

    //         phealth += attribute.value.ModifiedValue;
    //         Debug.Log(" hápé: " + phealth);
    //     }

    //     if (string.Concat(attribute.type) == "Defense")
    //     {
    //         pdefense += attribute.value.ModifiedValue;
    //     }
    // }

    public void Damage(Transform edamageOBJ, float edamageAmount)
    {
        edamageOBJ.GetComponent<Stats>().TakeDamage(edamageAmount);
        Debug.Log(" enemy Health: " + curHealth);
    }
    public void PDamage(Transform damageOBJ, float damageAmount)
    {
        damageOBJ.GetComponent<Stats>().TakeDamage(damageAmount);
        Debug.Log("player Health: " + pcurHealth);

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
    public void pTakeDamage(float pamount)
    {
        if (pdefense < pamount)
        {
            pcurHealth -= (pamount - pdefense);

        }
        if (pcurHealth <= 0)
        {
            Die();

        }
    }

    private void Die()
    {

        dead.SetActive(true);
        Time.timeScale = 0f;
        Destroy(Char);
    }
}
