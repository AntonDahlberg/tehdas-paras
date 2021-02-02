using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class hyppyanimaatio : MonoBehaviour
{
    private Animation playerAnime;
    // Start is called before the first frame update
    void Start()
    {
        playerAnime = GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            playerAnime.Play("vasenhyppy");
        }



    }
}
