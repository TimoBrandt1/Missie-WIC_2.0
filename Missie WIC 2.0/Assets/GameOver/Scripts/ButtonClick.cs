using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public int CurrentLevel;
    void Update()
    {
        CurrentLevel = PlayerPrefs.GetInt("CurrentLevel");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Mainscreen");
    }
    public void Restart()
    {
        if (CurrentLevel == 0)
        {
            SceneManager.LoadScene("Tutorial");
        }
        if (CurrentLevel == 1)
        {
            SceneManager.LoadScene("level 1");
        }
        if (CurrentLevel == 2)
        {
            SceneManager.LoadScene("level 2");
        }
        if (CurrentLevel == 3)
        {
            SceneManager.LoadScene("level 3");
        }
        if (CurrentLevel == 4)
        {
            SceneManager.LoadScene("level 4");
        }
        if (CurrentLevel == 5)
        {
            SceneManager.LoadScene("level 5");
        }
    }
}
