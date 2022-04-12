using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{

//     public Text thealth;
//     public GameObject dead;
//     public GameObject Char;
//     public float health;
//     public static float phealth;
//     public float defense;
//     public static float pdefense;
     
//     private float curHealth;
//     private  float pcurHealth;
//     private void Start()
//     {
       
//         curHealth = health;
//         pcurHealth = AddStats.hp;

//     }
//     public void enemyDamage(Transform edamageOBJ, float edamageAmount)
//     {
//         edamageOBJ.GetComponent<Stats>().pTakeDamage(edamageAmount);
//         Debug.Log("Health: " + pcurHealth);
//     }
//     public void PDamage(Transform damageOBJ, float damageAmount)
//     {
//         damageOBJ.GetComponent<Stats>().TakeDamage(damageAmount);
//         Debug.Log("Health: " + curHealth);

//     }
//     public void TakeDamage(float  damageAmount)
//     {
//         if (defense < damageAmount)
//         {
//             curHealth -= (damageAmount - defense);

//         }
//         if (curHealth <= 0)
//         {
//             Die();

//         }
//     }
//     public void pTakeDamage(float edamageAmount)
//     {
//         if (pdefense <edamageAmount)
//         {
//             pcurHealth -= (edamageAmount - pdefense);

//         }
//         if (pcurHealth <= 0)
//         {
//             pDie();

//         }
//     }
//     private void pDie()
//     {
//         dead.SetActive(true);
//         Time.timeScale = 0f;
//         Destroy(gameObject);
//     }
//     private void Die()
//     {

//         Destroy(gameObject);
//     }
 }
