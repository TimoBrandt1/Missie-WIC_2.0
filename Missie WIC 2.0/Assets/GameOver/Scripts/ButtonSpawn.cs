using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawn : MonoBehaviour
{
    //MMB Stands for MainMenuButton
    public GameObject MMB_Prefab;
    private GameObject MMB;

    //RB Stands for RestartButton
    public GameObject RB_Prefab;
    private GameObject RB;

    public GameObject PanelButtonParent;

    public Transform MMB_SpawnPos;
    public Transform RB_SpawnPos;

    void Start()
    {
        MMB = Instantiate(MMB_Prefab, MMB_SpawnPos.position, MMB_SpawnPos.rotation);
        RB = Instantiate(RB_Prefab, RB_SpawnPos.position, RB_SpawnPos.rotation);
        StartCoroutine(WaitForIntro());
    }

    IEnumerator WaitForIntro()
    {
        yield return new WaitForSeconds(2);
        MMB.transform.SetParent(PanelButtonParent.transform);
        RB.transform.SetParent(PanelButtonParent.transform);
    }
}
