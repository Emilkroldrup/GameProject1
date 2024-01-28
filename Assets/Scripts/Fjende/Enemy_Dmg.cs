using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Dmg : MonoBehaviour
{
    private PlayerHealth playerHealth;  // Reference to the player's health script
    public int damage; 
    public Coins coins;
    public Enemy_Health health;

    // Start is called before the first frame update
    void Start()
    {
        // Find the player's health script at runtime
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
   
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Enemy"))
        {

        }
        // Your update logic here
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerHealth.TakeDamage(damage);
        }
    }
    
   
    
}