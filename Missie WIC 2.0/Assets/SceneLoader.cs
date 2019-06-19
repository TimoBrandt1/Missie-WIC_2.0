using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public bool plutoSelected;
    void Update()
    {
        plutoSelected = GameObject.Find("Scriptholder").GetComponent<PlanetSelector>().PlutoSelected;
        if (Input.GetKey(KeyCode.Space) && plutoSelected == true)
        {
            SceneManager.LoadScene("PlutoLevelSelectie");
        }
    }
}
