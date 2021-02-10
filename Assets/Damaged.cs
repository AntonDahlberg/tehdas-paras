using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged : MonoBehaviour
{
  
    public int damage;
    enemy Enemyhp;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
       
    }







    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Enemyhp = other.transform.GetComponent<enemy>();
            Enemyhp.Health-=damage;
            



        }

    }

}
