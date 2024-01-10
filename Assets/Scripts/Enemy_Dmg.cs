using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Dmg : MonoBehaviour
{
    private PlayerHealth playerHealth;  // Reference to the player's health script
    public int damage;
    public Coins coins;

    // Start is called before the first frame update
    void Start()
    {
        // Find the player's health script at runtime
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();

        GameObject coinssobjekt = GameObject.FindGameObjectWithTag("Coins");
        if (coins != null)
        {
            coins = coinssobjekt.GetComponent<Coins>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Your update logic here
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
        if (Application.isPlaying)
        {
            Conditions.wincondition--;
            EnemySpawner.currentSpawns--;
            coins.UpdateGoldOnEnemyDestroyed();
        }
    }
}