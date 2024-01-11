using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    public float health;
    public float maxhealth = 10;
    public Enemy_hb healthbar;

    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
        healthbar.SetHealth(health, maxhealth);
    }

    public void TakeDamage(float amount) // amount = amount of damage taken
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
