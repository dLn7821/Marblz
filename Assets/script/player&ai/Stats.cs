using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{

    public Text thealth;
    public GameObject dead;
    public GameObject Char;
    public float health;

    public static float phealth;
    public float defense;
    public static float pdefense;
    private float curHealth;
    public static float pcurHealth;
    public void Check(Attribute attribute, player Player)
    {

        if (Char.tag == "Player")
        {
            if (string.Concat(attribute.type) == "Health")
            {
                phealth += attribute.value.ModifiedValue;
            }
            if (string.Concat(attribute.type) == "Defense")
            {
                pdefense += attribute.value.ModifiedValue;
            }
        }
    }
    private void Start()
    {

        curHealth = health;
        pcurHealth = phealth;

    }
    private void Update()
    {
        thealth.text = pcurHealth.ToString();
    }

    public void Damage(Transform edamageOBJ, float edamageAmount)
    {
        edamageOBJ.GetComponent<Stats>().TakeDamage(edamageAmount);
        Debug.Log("Health: " + curHealth);
    }
    public void PDamage(Transform pdamageOBJ, float pdamageAmount)
    {
        pdamageOBJ.GetComponent<Stats>().TakeDamage(pdamageAmount);
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
    public void pTakeDamage(float amount)
    {
        if (pdefense < amount)
        {
            pcurHealth -= (amount - pdefense);

        }
        if (pcurHealth <= 0)
        {
            pDie();

        }
    }
    private void pDie()
    {
        dead.SetActive(true);
        Time.timeScale = 0f;
        Destroy(gameObject);
    }
    private void Die()
    {

        Destroy(gameObject);
    }
}
