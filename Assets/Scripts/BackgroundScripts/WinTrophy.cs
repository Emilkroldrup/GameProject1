using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrophy : MonoBehaviour
{
    public bool trophyTouched = false;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            trophyTouched = true;
            Conditions.runde++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           
        }
    }

}

