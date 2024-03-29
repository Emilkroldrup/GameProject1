using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    public float speed;

    private Rigidbody2D rb;
    //private Animator anim; // only used when I add some animations
    private Transform currentPoint;

    

    // Start is called before the first frame update
    void Start()
    {
        pointA = GameObject.Find("PatrolPointA");
        pointB = GameObject.Find("PatrolPointB");
        rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
        currentPoint = pointB.transform;
        //anim.SetBool("isRunning", true);

      
    }

    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointB.transform)   // pointB is right, pointA is left
        {
            rb.velocity = new Vector2(speed, 0);    // B
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);   // A
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            Flip();
            currentPoint = pointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            Flip();
            currentPoint = pointB.transform;
        }
        
    }

    private void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }

    
 
    
}
