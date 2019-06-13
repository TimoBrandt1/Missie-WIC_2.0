using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject TutorialMenuUI;
    private bool AbleToStart;
    public GameObject player;

    public void Start()
    {
        Time.timeScale = 0.4f;
        
        
        TutorialMenuUI.SetActive(true);
        StartCoroutine(Timer());
    }
   public void Update()
    {
        if (AbleToStart == false)
        {
            player.GetComponent<CharacterController2D>().m_JumpForce = 0;
            player.GetComponent<PlayerMovement>().runSpeed = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space) && AbleToStart == true)
        {
            player.GetComponent<CharacterController2D>().m_JumpForce = 525;
            player.GetComponent<PlayerMovement>().runSpeed = 20;
            TutorialMenuUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(4);
        AbleToStart = true;
    }
}
