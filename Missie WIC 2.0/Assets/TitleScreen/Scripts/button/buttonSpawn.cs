using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSpawn : MonoBehaviour
{
    public GameObject StartButtonPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForIntro());
    }

    IEnumerator WaitForIntro()
    {
        yield return new WaitForSeconds(4);
        Instantiate(StartButtonPrefab);
    }
}
