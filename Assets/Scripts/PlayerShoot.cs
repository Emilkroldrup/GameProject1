using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public PlayerProjectile projectile;
    public Transform FirePoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // left ctrl
        {

            Instantiate(projectile, FirePoint.position, transform.rotation);
        }
    }

 
}
