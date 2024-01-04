using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{
    // waypoints
    public List<Transform> points;
    public int nextID; // value of next waypoint
    int idChangeValue = 1;

    private void Reset()
    {
        
    }

}
