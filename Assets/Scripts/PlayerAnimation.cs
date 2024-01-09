using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    public float rotationSpeed = 5f;

        void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        
        
    }

    void RotatePlayer(float horizontalInput){
        if(horizontalInput != 0){
            float rotationAmount = -horizontalInput * rotationSpeed;
            Quaternion deltaRotation = Quaternion.Euler(0f,180f,0f);
            GetComponent<Rigidbody2D>().MoveRotation(GetComponent<Rigidbody2D>().rotation + rotationAmount);
        }
    }
}
