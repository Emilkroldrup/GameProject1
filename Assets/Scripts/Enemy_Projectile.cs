using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Projectile : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    private float timer;

    public float force;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

        float rota = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg; // the rotation of the projectile
        transform.rotation = Quaternion.Euler(0, 0, rota); // add '+' after rota and a number describing the degree you want your object to rotate
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 10)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealth>().health -= 10;
            Destroy(gameObject);
        }
    }
}
