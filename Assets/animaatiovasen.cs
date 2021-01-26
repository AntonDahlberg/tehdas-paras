using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class animaatiovasen : MonoBehaviour
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
            playerAnim.Play("Vasen1anim");


        }
        if (Input.GetKey(KeyCode.A))
        {
            playerAnim.Play("Vasen1anim");

        }
        if (Input.GetKey(KeyCode.S))
        {
            playerAnim.Play("Vasen1anim");

        }
        if (Input.GetKey(KeyCode.D))
        {
            playerAnim.Play("Vasen1anim");

        }

    }
}
