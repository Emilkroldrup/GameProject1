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
   
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = Vector2.Distance(transform.position, player.transform.position); //  Detects the distance between enemy and the player
        
        if(distance < 8)
        {
            timer += Time.deltaTime;

            if(timer > 2)
            {
                timer = 0;
                Shoot();
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
            EnemySpawner.currentSpawns--;
            coins.UpdateGoldOnEnemyDestroyed();
        

    }
}
