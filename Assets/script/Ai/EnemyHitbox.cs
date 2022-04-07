using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : MonoBehaviour
{
    public float edamage;
    public Stats stats;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("bz");
        if (other.gameObject.tag == "Player")
        {
            stats.enemyDamage(other.transform, edamage);
            Debug.Log("damage: "+edamage);
        }
    }
}
