using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject endgame;
    public GameObject endgame2;
    void Start()
    {

        Cursor.lockState = CursorLockMode.None;
    }

    public void  Playgame ()
    {
        SceneManager.LoadScene("tehdas peli");
    }
    public void Playgame1 ()
    {
        endgame.gameObject.SetActive(true);
        endgame2.gameObject.SetActive(false);
    }
    public void Playgame2 ()
    {

        endgame.gameObject.SetActive(false);
        endgame2.gameObject.SetActive(true);
    }
    public void QuitGame ()
    {
        Application.Quit();
    }
    
}

