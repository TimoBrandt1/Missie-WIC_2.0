using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("Mainscreen");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
