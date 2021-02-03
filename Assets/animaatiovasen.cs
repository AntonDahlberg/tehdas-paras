using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class animaatiovasen : MonoBehaviour
{
    private Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerAnim.SetBool("runn", true);


        }
        if (Input.GetKey(KeyCode.A))
        {
            playerAnim.SetBool("runn", true);

        }
        if (Input.GetKey(KeyCode.S))
        {
            playerAnim.SetBool("runn", true);

        }
        if (Input.GetKey(KeyCode.D))
        {
            playerAnim.SetBool("runn", true);

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("runn", false);


        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            playerAnim.SetBool("runn", false);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnim.SetBool("runn", false);

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            playerAnim.SetBool("runn", false);

        }

    }
}
