using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NextLevel : MonoBehaviour
{
    
    public TMP_Text nextLevel;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")){
            SceneManager.LoadSceneAsync("Level" + Conditions.runde);

        }
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  // goes to the next scene in line
        }
        
    }

    void Update(){
        nextLevel.text = "Level " + Conditions.runde;
    }
}
