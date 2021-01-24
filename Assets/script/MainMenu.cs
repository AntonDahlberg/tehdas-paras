using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {

        Cursor.lockState = CursorLockMode.None;
    }

    public void  Playgame ()
    {
        SceneManager.LoadScene("tehdas peli");
    }
    public void QuitGame ()
    {
        Application.Quit();
    }
    
}

