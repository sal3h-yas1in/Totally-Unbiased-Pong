using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //this is important for SceneManager

public class MainMenu : MonoBehaviour
{
    public AudioSource audioSource;
    public void Play_1P()
    {
        SceneManager.LoadScene("1-Player Game"); //load the 1 - player game mode
    }

    //Play 2 players function
     public void Play_2P()
    {
        SceneManager.LoadScene("2-Player Game"); //load the 2 - player game mode
    }

    //Quit button function
    public void QuitGame()
    {
        Application.Quit();
    }
}
