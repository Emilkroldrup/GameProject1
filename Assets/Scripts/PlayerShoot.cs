using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public PlayerProjectile projectile;
    public Transform launchOffSet;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectile, launchOffSet.position, transform.rotation);
        }
    }

 
}
