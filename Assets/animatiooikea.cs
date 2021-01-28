using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class animatiooikea : MonoBehaviour
{
    private Animation playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerAnim.Play("Oikea2");


        }
        if (Input.GetKey(KeyCode.A))
        {
            playerAnim.Play("Oikea2");

        }
        if (Input.GetKey(KeyCode.S))
        {
            playerAnim.Play("Oikea2");

        }
        if (Input.GetKey(KeyCode.D))
        {
            playerAnim.Play("Oikea2");

        }

    }
}
