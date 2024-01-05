using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxhealth = 50;
    public Healthbar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
        healthbar.setmaxhealth(maxhealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            Destroy(healthbar.gameObject);
        }

        healthbar.sethealth(health);
    }
}
