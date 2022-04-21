using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estats : MonoBehaviour
{
    public float health;
    public float curHealth;
    public Loot[] loots;
    [System.Serializable]
    public class Loot
    {
        public GameObject item;
        [Range(0.01f, 100f)]
        public float droprate;
        public int minQuantity;
        public int maxQuantity;
    }
    private void Start()
    {
        curHealth = health;
    }

    public void Damage(Transform damageOBJ, float damageAmount)
    {
        damageOBJ.GetComponent<PStats>().pTakeDamage(damageAmount);
    }

    public void eTakeDamage(float Amount)
    {
        curHealth -= Amount;
        if (curHealth <= 0)
        {
            Die();
            ObjectDropItem();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
    public void ObjectDropItem()
    {

        foreach (Loot loot in loots)
        {
            float spawnChance = Random.Range(-0.01f, 100f);
            if (spawnChance <= loot.droprate)
            {
                int spawnamount = Random.Range(loot.minQuantity, loot.maxQuantity);
                for (int i = 0; i < spawnamount; i++)
                {
                    GameObject currentDrop = Instantiate(loot.item, transform.position, transform.rotation * Quaternion.Euler(new Vector3(0, 0, Random.Range(transform.rotation.y - 40, transform.rotation.y + 40))));
                    currentDrop.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(0, 10), ForceMode2D.Impulse);
                }
            }
        }
    }
}