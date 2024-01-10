using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void SafeHub(){
        SceneManager.LoadScene(2);
    }

    public void Menu(){
        SceneManager.LoadScene(0);
    }
}
