using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageded : MonoBehaviour
{
    public int damage;
    enemy Enemyhp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy1")
        {
            Enemyhp = other.transform.GetComponent<enemy>();
            Enemyhp.Health -= damage;




        }

    }
}
