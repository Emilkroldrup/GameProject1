using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyprefab;

    public GameObject player;
    public static int MaxSpawn = 6;
    public static int totalspawns;
    public static int currentSpawns;
    public static int maxcurrentspawns = 5;
    public static int runde = 1;
    public static bool levelcomplete = false;
    [HideInInspector]
    public int randomfjende;
    private float tid;
    public float cooldown;
    private float maxx = 10;
    private float minx = 3;


    // Start is called before the first frame update
    void Start()
    {
        tid = cooldown;
       
    }

    // Update is called once per frame
    void Update()
    {
        tid -= Time.deltaTime;

        if (currentSpawns < maxcurrentspawns && tid <= 0 && totalspawns <MaxSpawn && player != null)
        {
                spawnenemy();
                tid = cooldown;
         
        }
       
            rundelogik();
    }

    private void spawnenemy()   
    {
        if(player != null)
        {
            randomfjende = Random.Range(1, 10);
            float spawnrange = Random.Range(minx, maxx);
            Transform playerTransform = player.transform;
            Vector3 spawnposition = playerTransform.position + new Vector3(spawnrange, 0, 0);



            if (randomfjende <= 7)
            {
                currentSpawns++;
                totalspawns++;
                Instantiate(enemyprefab[0], spawnposition, Quaternion.identity);

            }
            else if (randomfjende >= 8)
            {
                currentSpawns++;
                totalspawns++;
                Instantiate(enemyprefab[1], spawnposition, Quaternion.identity);

            }
        }
    }

    private void rundelogik()
    {
        if(runde <=3 && totalspawns == MaxSpawn && currentSpawns == 0 && player !=null)
        {
            runde++;
            Debug.Log(runde);
            if(runde != 4)
            {
                totalspawns = 0;
                MaxSpawn += 2;
                maxcurrentspawns += 1;
            }
        }

        if(runde == 4)
        {
            levelcomplete = true;
        }
    }
       
}