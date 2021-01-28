using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class patroller : MonoBehaviour
{
    public Transform[] waypoints;
    public int speed;

    private int waypointIndex;
    private float dist;
    private Animation playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
        playerAnim = GetComponent<Animation>();
        





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
        playerAnim.Play("zombikavelyoikea");




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
