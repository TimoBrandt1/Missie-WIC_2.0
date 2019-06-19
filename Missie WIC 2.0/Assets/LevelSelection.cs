using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public int levelCounter = 0;
    public Animator animator;

    void Update()
    {
        Debug.Log(levelCounter);
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            levelCounter++;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            levelCounter++;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            levelCounter--;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            levelCounter--;
        }
        LoadSelectedLevel();
        //CheckCounter();
    }
    void LoadSelectedLevel()
    {
        if (levelCounter == 0 && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Tutorial");
        }
        if (levelCounter == 1 && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("level 1");
        }
        if (levelCounter == 2 && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("level 2");
        }
        if (levelCounter == 3 && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("level 3");
        }
        if (levelCounter == 4 && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("level 4");
        }
        if (levelCounter == 5 && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("level 5");
        }
        if (levelCounter == 6 && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("level 7(Demo)");
        }
    }
    /*void CheckCounter()
    {
    }*/
}
