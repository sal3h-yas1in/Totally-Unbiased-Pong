using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPause;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        isPause = true;
        pauseMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isPause)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        if(isPause)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                QuitGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPause = false;
    }

    public void QuitGame()
    {
        isPause = true;
        SceneManager.LoadScene("Title Screen");
    }
}
