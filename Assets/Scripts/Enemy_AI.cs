using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{   
    public float speed;
    public bool chase = false;
    public Coins coins;
    public Transform startingPoint;

    private GameObject player;

    private Boolean hasdestroyed = false;

    // Start is called before the first frame update
    private void Start()
    {
       
            player = GameObject.FindGameObjectWithTag("Player");


        GameObject coinssobjekt = GameObject.FindGameObjectWithTag("Coins");
        if (coins != null)
        {
            coins = coinssobjekt.GetComponent<Coins>();
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
            return;
        if (chase == true)
            Chase();
        else
            ReturnStartPoint();
        Flip();
    }

    private void Chase()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime); // this will be called in Update()
        
    }

    private void ReturnStartPoint()
    {
        transform.position = Vector2.MoveTowards(transform.position, startingPoint.transform.position, speed * Time.deltaTime);
    }

    private void Flip()
    {
        if (transform.position.x > player.transform.position.x)
            transform.rotation = Quaternion.Euler(0, 0, 0);
        else
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }
    
    private void OnDestroy()
    {

        if (hasdestroyed)
        {
            Conditions.wincondition--;
            EnemySpawner.currentSpawns--;
            coins.UpdateGoldOnEnemyDestroyed();
            hasdestroyed = true;
        }
     
    }
}
