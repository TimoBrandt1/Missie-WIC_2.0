using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSpawn : MonoBehaviour
{
    public GameObject StartButtonPrefab;
    private GameObject StartButton;

    public GameObject PanelButtonParent;

    public Transform ButtonSpawnPos;
    // Start is called before the first frame update
    void Start()
    {
        StartButton = Instantiate(StartButtonPrefab, ButtonSpawnPos.position, ButtonSpawnPos.rotation);
        StartCoroutine(WaitForIntro());
    }

    IEnumerator WaitForIntro()
    {
        yield return new WaitForSeconds(4);
        StartButton.transform.SetParent(PanelButtonParent.transform);
    }
}
