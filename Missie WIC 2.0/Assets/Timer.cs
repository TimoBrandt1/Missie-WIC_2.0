using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    bool videoEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForVideoEnd());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator WaitForVideoEnd()
    {
        yield return new WaitForSeconds(14);
        SceneManager.LoadScene("PlutoLevelSelectie");
    }
}
