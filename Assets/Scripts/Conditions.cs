using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{

  
    public static int wincondition = EnemySpawner.MaxSpawn;
    public GameObject win;
    public GameObject Playercanvas;
    private bool hasInitialized = false;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( wincondition <= 0 && !hasInitialized && player != null)
        {
            Initializewincon(win);
            DisableOtherPrefab(Playercanvas);
            hasInitialized = true;

          
        }
    }

    void Initializewincon(GameObject prefab)
    {
        
        GameObject winCanvas = Instantiate(prefab, transform.position, transform.rotation);

    
    }


    void DisableOtherPrefab(GameObject otherPrefab)
    {

        
            Playercanvas.SetActive(false);
        

    }
}
