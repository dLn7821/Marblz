using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitBox : MonoBehaviour
{
    public static float damage;
    public Stats stats;

 public void Check(Attribute attribute, player Player)
    {

     if (string.Concat(attribute.type) == "Damage")
        {
           damage += attribute.value.ModifiedValue;
        }   
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("b");
        if (other.gameObject.tag == "Stats")
        {
            stats.Damage(other.transform, damage);
            Debug.Log("a");
        }
    }
}