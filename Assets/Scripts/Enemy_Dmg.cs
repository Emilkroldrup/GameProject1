using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Dmg : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage;
    public Coins coins;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerHealth.TakeDamage(damage);
        }
    }

    private void OnDestroy()
    {
       
            Conditions.wincondition--;
            EnemySpawner.currentSpawns--;
            coins.UpdateGoldOnEnemyDestroyed();
        
  
    }
}
