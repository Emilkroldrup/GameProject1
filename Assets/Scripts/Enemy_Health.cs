using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    public int health;
    public int maxhealth = 15;
    public Healthbar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
        healthbar.setmaxhealth(maxhealth);
    }

    public void TakeDamage(int amount) // amount = amount of damage taken
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
            Destroy(healthbar.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            Destroy(healthbar.gameObject);
        }

        healthbar.sethealth(health);
    }
}
