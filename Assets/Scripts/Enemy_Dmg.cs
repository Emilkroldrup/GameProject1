using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Dmg : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 2;
    public Coins coins;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
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
