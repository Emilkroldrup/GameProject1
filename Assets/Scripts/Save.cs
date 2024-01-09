using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    void Awake(){
        DontDestroyOnLoad(transform.gameObject);
    }
}
