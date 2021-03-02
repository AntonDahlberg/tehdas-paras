using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    bool detected;
     GameObject target;
    public Transform enemy;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (detected)
        {
            enemy.LookAt(target.transform);

        }
            

           
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            detected = true;
            target = other.gameObject;

        }
    }
}
