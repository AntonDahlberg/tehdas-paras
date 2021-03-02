using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class aikatimer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startTime = 60f;
    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString ("0");
       

        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene("you lose");
            ScoreScript.scoreValue -= 10;

        }
               
    }
   
}
