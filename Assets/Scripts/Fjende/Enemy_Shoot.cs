using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform projectilePos;

    private float timer;
    private GameObject player;
    public Coins coins;
    public EnemySpawner spawner;
    public Conditions Conditions;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        GameObject coinssobjekt = GameObject.FindGameObjectWithTag("Coins");
        if (coins != null)
        {
            coins = coinssobjekt.GetComponent<Coins>();
        }

        GameObject spawnerobjekt = GameObject.FindGameObjectWithTag("Spawner");
      
            spawner = spawnerobjekt.GetComponent<EnemySpawner>();
        
    }
    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            float distance = Vector2.Distance(transform.position, player.transform.position); //  Detects the distance between enemy and the player
            if (distance < 8)
            {
                timer += Time.deltaTime;

                if (timer > 2)
                {
                    timer = 0;
                    Shoot();
                }

            }
        }
    }
    void Shoot()
    {
        Instantiate(projectile, projectilePos.position, Quaternion.identity);
    }
    
    private void OnDestroy()
    {
            Conditions.wincondition--;
            spawner.currentSpawns--;
            coins.UpdateGoldOnEnemyDestroyed();
    }
}
