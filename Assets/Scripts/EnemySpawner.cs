using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyprefab;
    public static int MaxSpawn = 6;
    public static int totalspawns;
    public static int currentSpawns;
    [HideInInspector]
    public int randomfjende;
    private float tid;
    private float cooldown = 1f;
    [HideInInspector]
   

    // Start is called before the first frame update
    void Start()
    {
        tid = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        tid -= Time.deltaTime;

        if (currentSpawns < 5 && tid <= 0 && totalspawns <MaxSpawn)
        {
                spawnenemy();
                tid = cooldown;
        }
    }

    private void spawnenemy()
    {
        randomfjende = Random.Range(1, 10);

        if (randomfjende <= 7)
        {
            currentSpawns++;
            totalspawns++;
            Instantiate(enemyprefab[0], transform.position, Quaternion.identity);
          
        }
        else if (randomfjende >= 8)
        {
            currentSpawns++;
            totalspawns++;
            Instantiate(enemyprefab[1], transform.position, Quaternion.identity);
            
        }
    }
}