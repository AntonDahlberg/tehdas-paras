using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    public GameObject endgame;
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            endgame.gameObject.SetActive(true);
            Destroy(gameObject);
            Cursor.lockState = CursorLockMode.None;
            
        }
    }
}
