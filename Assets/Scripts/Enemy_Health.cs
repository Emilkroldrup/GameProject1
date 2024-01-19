using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Health : MonoBehaviour
{
    public float health;
    public float maxhealth = 10;
    public Enemy_hb healthbar;
    public Coins coins;
    public EnemySpawner spawner;
    public Conditions Conditions;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
        healthbar.SetHealth(health, maxhealth);

        GameObject coinssobjekt = GameObject.FindGameObjectWithTag("Coins");
        if (coins != null)
        {
            coins = coinssobjekt.GetComponent<Coins>();
        }

        GameObject spawnerobjekt = GameObject.FindGameObjectWithTag("Spawner");
        if (spawner != null)
        {
            spawner = spawnerobjekt.GetComponent<EnemySpawner>();
        }
    }

    public void TakeDamage(float amount) // amount = amount of damage taken
    {
        health -= amount;
        if (health <= 0)
        {
            Conditions.wincondition--;
            spawner.currentSpawns--;
            coins.UpdateGoldOnEnemyDestroyed();
            Destroy(gameObject);
        }
    }
    
}
