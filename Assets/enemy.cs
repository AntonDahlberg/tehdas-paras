using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    
    public Transform spawnpont;
    public Text more;
    public GameObject[] obj;
    //public GameObject obj;
    public float spawnMin;
    public float spawnMax;
    public int Health;
    public int Enemyleft;
    public GameObject endgame;
    playerHealth Playerhp;
    public GameObject key;
    public GameObject enemis;
    

    // Start is called before the first frame update
    void Start()
    {
      


    }

    // Update is called once per frame
    void Update()
    {
        more.text = Enemyleft.ToString();

    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "bullet")
        {
            if  (Health <= 0)
            {




                died();
                Enemyleft -= 1;
                Destroy(gameObject);
                


            }



            if (Enemyleft <= 0)
            {
                enemis.gameObject.SetActive(false);
                Destroy(gameObject);
                              
                
                


            }
            


        }

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "veitsi") 
        {
            if (Health <= 0)
            {




                
                Enemyleft -= 1;
                Destroy(gameObject);
                


            }



            if (Enemyleft <= 0)
            {
                enemis.gameObject.SetActive(false);
                Destroy(gameObject);
                
                



            }



        }

    }
    void died()
    {
        

    }
    void Spawn()

    {
        
        
        Enemyleft -= 1;
        Health += 100;
        transform.position = spawnpont.position;
        Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
        
       


    }
    public void Youwon()
    {
        SceneManager.LoadScene("You win");
    }
    private void Drop()
    {
        key.transform.parent = null;
        key.GetComponent<Rigidbody>().isKinematic = true;
        key.gameObject.SetActive(true);
        key = null;


    }
}
