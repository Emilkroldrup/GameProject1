using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level2 : MonoBehaviour
{
    public Slider slider;
    public float antal = 0f;
    public float maxAntal = 0f;
    public EnemySpawner es;

    void Start(){
        maxAntal = es.totalfjender;
    }

    void Update()
    {
        slider.value = antal/maxAntal;
    }

    public void IncreaseAntal(){
        antal++;
    }
}
