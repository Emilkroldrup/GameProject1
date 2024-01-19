using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RundeScript : MonoBehaviour
{
    TextMeshProUGUI text;
    public EnemySpawner spawner;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.text = "";
          
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Round" + " " + spawner.runde;

        if (spawner.runde == spawner.lastround)
        {
            text.text = "Final Round";

        }
    }
}