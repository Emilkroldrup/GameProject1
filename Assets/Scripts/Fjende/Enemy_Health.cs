using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_Health : MonoBehaviour
{
    public float health;
    public float maxhealth = 10;
    public Enemy_hb healthbar;
    public Coins coins;
    public EnemySpawner spawner;
    public Conditions Conditions;
    private Level2 lvl2;
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex == 3){
            lvl2 = GameObject.FindGameObjectWithTag("Waves").GetComponent<Level2>();
        }
        health = maxhealth;
        healthbar.SetHealth(health, maxhealth);

        GameObject coinssobjekt = GameObject.FindGameObjectWithTag("Coins");
        if (coins != null)
        {
            coins = coinssobjekt.GetComponent<Coins>();
        }

        GameObject spawnerobjekt = GameObject.FindGameObjectWithTag("Spawner");
      
            spawner = spawnerobjekt.GetComponent<EnemySpawner>();
        
    }

    public void TakeDamage(float amount) // amount = amount of damage taken
    {
        health -= amount;
        if (health <= 0)
        {
            if(SceneManager.GetActiveScene().buildIndex == 3){
                lvl2.IncreaseAntal();
            }
            Conditions.wincondition--;
            spawner.currentSpawns--;
            coins.UpdateGoldOnEnemyDestroyed();
            Destroy(gameObject);
        }
    }
    
}
