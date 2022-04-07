using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitBox : MonoBehaviour
{
    public static float damage;
    public Stats stats;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("b");
        if (other.gameObject.tag == "Stats")
        {
            stats.PDamage(other.transform, damage+AddStats.damage);
            Debug.Log("a");
        }
    }
}