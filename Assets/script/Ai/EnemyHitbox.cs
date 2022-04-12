using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitbox : MonoBehaviour
{
    public int damage;
    public Estats stats;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("bz");
        if (other.gameObject.tag == "Player")
        {
            stats.Damage(other.transform, damage);
            Debug.Log("damage: "+damage);
        }
    }
}
