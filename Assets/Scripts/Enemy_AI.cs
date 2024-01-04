using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{
    [SerializeField]private GameObject player;
    [SerializeField]private float speed;
    private float distance;

    void start()
    {

    }

    void Update()
    {
        // Gets distance between player opbject and enemy ai
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

    }
}
