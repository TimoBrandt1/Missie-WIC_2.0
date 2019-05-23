using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("Mainscreen");
        }
    }
}
