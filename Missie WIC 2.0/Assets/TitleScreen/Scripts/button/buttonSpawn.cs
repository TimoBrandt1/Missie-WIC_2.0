using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonSpawn : MonoBehaviour
{
    public GameObject StartText;
    public bool AbleToStart;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForIntro());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && AbleToStart == true)
        {
            SceneManager.LoadScene("PlutoLevelSelectie");
        }
    }
    IEnumerator WaitForIntro()
    {
        yield return new WaitForSeconds(4);
        Instantiate(StartText);
        AbleToStart = true;
    }
}
