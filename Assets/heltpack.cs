using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heltpack : MonoBehaviour
{
    public int damage;
    playerHealth Playerhp;
    // Start is called before the first frame update


    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Playerhp = other.transform.GetComponent<playerHealth>();
            Playerhp.Health += damage;
            Destroy(gameObject);



        }

    }
}
