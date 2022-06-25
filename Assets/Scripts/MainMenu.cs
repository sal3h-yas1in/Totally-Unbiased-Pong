using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //this is important for SceneManager

public class MainMenu : MonoBehaviour
{ 
    //Play button function
     public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //current build index=0
    }

    //Quit button function
    public void QuitGame()
    {
        Application.Quit();
    }
}
