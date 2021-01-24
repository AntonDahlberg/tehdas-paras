using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float leftLimit = -250;
    public float rightlimit = 250;
    public float uplimit = 50;
    public int damage;
    enemy Enemyhp;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightlimit)

            Destroy(gameObject);
        else if (transform.position.y > uplimit)

            Destroy(gameObject);
    }







    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Enemyhp = other.transform.GetComponent<enemy>();
            Enemyhp.Health-=damage;
            Destroy(gameObject);
            


        }

    }
}
