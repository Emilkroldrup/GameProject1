using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lost : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject lostPrefab;
    private bool lostCon = false;

    void Update()
    {
        if(player == null && lostCon != true){
            GameObject lostCanvas = Instantiate(lostPrefab, transform.position, transform.rotation);
            lostCon = true;
        }
    }
}
