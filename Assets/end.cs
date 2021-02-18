using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    public GameObject endgame;
    public GameObject aika;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            endgame.gameObject.SetActive(true);
            aika.gameObject.SetActive(false);
            Destroy(gameObject);
            Cursor.lockState = CursorLockMode.None;
            
        }
    }
}
