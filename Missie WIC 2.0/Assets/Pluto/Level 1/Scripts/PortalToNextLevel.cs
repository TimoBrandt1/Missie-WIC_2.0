using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalToNextLevel : MonoBehaviour
{
    public bool PortalClosed = true;
    public int stageCounter;
    private void Update()
    {
        PlayerPrefs.SetInt("stage", stageCounter);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PortalClosed == false)
        {
            //From Tutorial to level 1
            if (collision.gameObject.tag == "Player" && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Tutorial"))
            {
                SceneManager.LoadScene("level 1");
                stageCounter += 1;
            }
            //From Level 1 to level 2
            if (collision.gameObject.tag == "Player" && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 1"))
            {
                SceneManager.LoadScene("level 2");
                stageCounter += 1;
            }
            //From level 2 to level 3
            if (collision.gameObject.tag == "Player" && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 2"))
            {
                SceneManager.LoadScene("level 3");
                stageCounter += 1;
            }
            //From level 3 to level 4
            if (collision.gameObject.tag == "Player" && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 3"))
            {
                SceneManager.LoadScene("level 4");
                stageCounter += 1;
            }
            //From level 4 to level 5
            if (collision.gameObject.tag == "Player" && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 4"))
            {
                SceneManager.LoadScene("level 5");
                stageCounter += 1;
            }
            //From Level 5 to End
            if (collision.gameObject.tag == "Player" && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level 5"))
            {
                SceneManager.LoadScene("level 7(Demo)");
            }
        }

    }
}
