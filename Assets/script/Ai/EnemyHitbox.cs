using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : MonoBehaviour
{
    public float damage;
    public Estats stats;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("bz");
        if (other.gameObject.tag == "Player")
        {
            stats.enemyDamage(other.transform, damage);
            Debug.Log(damage);
        }
    }
}
