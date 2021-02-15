using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectscript : MonoBehaviour
{
    bool detected;
    GameObject target;
    public Transform enemy;
    public GameObject bullet;
    public Transform shootPoint;
    public float shootSpeed;
    public float TimetoShoot;
    float originalTime;
   
    // Start is called before the first frame update
    void Start()
    {
        originalTime = TimetoShoot;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (detected)
        {
            enemy.LookAt(target.transform);
        }
        
    }
    private void FixedUpdate()
    {
        if (detected)
        {
            TimetoShoot -= Time.deltaTime;
            if (TimetoShoot < 0)
            {
                Shootplayer();
                TimetoShoot = originalTime;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            detected = true;
            target = other.gameObject;
            
        }
    }
    private void Shootplayer()
    {
        GameObject currentBullet = Instantiate(bullet, shootPoint.position, shootPoint.rotation);
        Rigidbody rig = currentBullet.GetComponent<Rigidbody>();
        rig.AddForce(transform.forward * shootSpeed, ForceMode.VelocityChange);
    }

}
