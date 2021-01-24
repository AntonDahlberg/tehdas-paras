using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patroller : MonoBehaviour
{
    public Transform[] waypoints;
    public int speed;

    private int waypointIndex;
    private float dist;
    
    // Start is called before the first frame update
    void Start()
    {
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
        
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if(dist < 1f)
        {
            indexpatrol();
        }
        Patrol();
        
    }
    void Patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
       
    }
    void indexpatrol()
    {
        waypointIndex++;
        if(waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
        transform.LookAt(waypoints[waypointIndex].position);

    }
}
