using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PStats : MonoBehaviour
{
    public GameObject dead;
    public GameObject Char;

    public static float phealth;

    public static float pdefense;

    public static float pcurHealth;
    private void Start()
    {


        phealth = pcurHealth;

    }


    public void PDamage(Transform damageOBJ, float damageAmount)
    {
        damageOBJ.GetComponent<Stats>().TakeDamage(damageAmount);
        Debug.Log("player Health: " + pcurHealth);

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
