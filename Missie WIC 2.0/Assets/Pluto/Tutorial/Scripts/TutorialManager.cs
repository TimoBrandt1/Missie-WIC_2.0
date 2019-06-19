using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] PopUps;
    private int PopUpIndex;

    public GameObject player;
    public GameObject Nasa;
    
    public bool DoubleJumpDone;
    public bool CollectedStar;
    private bool Finished;
  
    public void Start()
    {
        
    }
   public void Update()
    {
        for (int i = 0; i < PopUps.Length; i++)
        {
            if (i == PopUpIndex)
            {
                PopUps[i].SetActive(true);
            }
            else
            {
                PopUps[i].SetActive(false);
            }
        }
        //Checks if player walks Left or Right
        if (PopUpIndex == 0)
        {
            player.GetComponent<CharacterController2D>().m_JumpForce = 0;
            if (player.transform.position.x > 1)
            {
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
                {
                    PopUpIndex++;
                }
            }
        }
        //Checks if the player jumps
        else if (PopUpIndex == 1)
        {
            player.GetComponent<CharacterController2D>().m_JumpForce = 525;
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                StartCoroutine(WaitFewSeconds());
            }
        }
        //Checks if you collected a star
        else if (PopUpIndex == 2)
        {
            if (CollectedStar == true)
            {
                PopUpIndex++;
            }
        }
        //Checks if you have done a wall jump
        else if (PopUpIndex == 3)
        {
            if (DoubleJumpDone == true)
            {
                PopUpIndex++;
            }
        }
        //Dont get Spotted
        else if (PopUpIndex == 4)
        {
            StartCoroutine(Timer());
            if (Finished == true)
            {
                PopUpIndex++;
                Finished = false;
            }
        }
        //Go in the portal
        else if (PopUpIndex == 5)
        {
            StartCoroutine(Wait());
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        Finished = true;
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        PopUpIndex++;
    }
    IEnumerator WaitFewSeconds()
    {
        yield return new WaitForSeconds(1);
        PopUpIndex++;
    }
}
