using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{

    [SerializeField]
    public static int wincondition = 1;
    public GameObject win;
    public GameObject Playercanvas;
    private bool hasInitialized = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( wincondition == 0 && !hasInitialized )
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
