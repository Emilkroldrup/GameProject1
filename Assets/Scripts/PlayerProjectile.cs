using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public float speed = 4.5f;
    public float bulletDamage;

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<Enemy_Health>();
        if (enemy)
        {
            enemy.TakeDamage(bulletDamage);
        }
        Destroy(gameObject);
    }
}
