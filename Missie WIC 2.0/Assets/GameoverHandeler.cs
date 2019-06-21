using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameoverHandeler : MonoBehaviour
{
    public int levelIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("CurrentLevel", levelIndex);
        //Tutorial
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Tutorial"))
        {
            levelIndex = 0;
        }
        //Level 1
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 1"))
        {
            levelIndex = 1;
        }
        //Level 2
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 2"))
        {
            levelIndex = 2;
        }
        //Level 3
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 3"))
        {
            levelIndex = 3;
        }
        //Level 4
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 4"))
        {
            levelIndex = 4;
        }
        //Level 5
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 5"))
        {
            levelIndex = 5;
        }
    }
}
