using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] obj;
    //public GameObject obj;
    public float spawnMin;
    public float spawnMax;

    // Use this for initialization
    void Start()
    {


        Spawn();


    }

    void Spawn()

    {
        //for (int i = 0; i < 10; i++)
        //  Instantiate(obj, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
        Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));

    }

}
