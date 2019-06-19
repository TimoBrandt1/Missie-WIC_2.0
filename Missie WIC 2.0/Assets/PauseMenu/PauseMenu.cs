using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Mainscreen");
    }

    public void QuitGame()
    {
        Debug.Log("Quiting The Game");
        Application.Quit();
    }
    public void RestartLevel()
    {
        //Restart Tutorial
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Tutorial"))
        {
            SceneManager.LoadScene("Tutorial");
            Resume();
        }
        //Restart level 1
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 1"))
        {
            SceneManager.LoadScene("level 1");
            Resume();
        }
        //Restart level 2
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 2"))
        {
            SceneManager.LoadScene("level 2");
            Resume();
        }
        //Restart level 3
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 3"))
        {
            SceneManager.LoadScene("level 3");
            Resume();
        }
        //Restart level 4
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 4"))
        {
            SceneManager.LoadScene("level 4");
            Resume();
        }
        //Restart level 5
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 5"))
        {
            SceneManager.LoadScene("level 5");
            Resume();
        }
        //Restart level 6
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 6"))
        {
            SceneManager.LoadScene("level 6");
            Resume();
        }
    }
}
