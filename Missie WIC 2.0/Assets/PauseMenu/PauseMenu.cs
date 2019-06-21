using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public int Selected;
    public GameObject pauseMenuUI;
    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow) && GameIsPaused == true || Input.GetKeyUp(KeyCode.S) && GameIsPaused == true)
        {
            Selected -= 1;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) && GameIsPaused == true || Input.GetKeyUp(KeyCode.W) && GameIsPaused == true)
        {
            Selected += 1;
        }
        if (Selected >= 5)
        {
            Selected = 1;
        }
        if (Selected <= 0)
        {
            Selected = 4;
        }
        //Contiue button
        if (Selected == 1)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                Resume();
            }
        }
        //Restart Button
        if (Selected == 2)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                RestartLevel();
            }
        }
        //MainMenu Button
        if (Selected == 3)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                LoadMenu();
            }
        }
        //Quit Game
        if (Selected == 4)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                QuitGame();
            }
        }
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
        SceneManager.LoadScene("PlanetSelection");
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
