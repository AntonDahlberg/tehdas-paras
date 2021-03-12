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
            ScoreScript.scoreValue += 25;
            Destroy(gameObject);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
    }
}
