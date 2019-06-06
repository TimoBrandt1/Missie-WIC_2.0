using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;

    private int popUpIndex;
    public GameObject player;

   void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i ==  popUpIndex)
            {
                popUps[popUpIndex].SetActive(true);
            }
            else
            {
                popUps[popUpIndex].SetActive(false);
            }
        }
        if (popUpIndex == 0)
        {
            //Sets the jump force of the player to 0 so you can only move left and right
            player.GetComponent<CharacterController2D>().m_JumpForce = 0;
            //Checks if you have pressed the left or right buttons
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                popUpIndex++;
            }
            
        }
        else if (popUpIndex == 1)
        {
            //Sets the jump force back to normal
            player.GetComponent<CharacterController2D>().m_JumpForce = 525;
            //Checks if the player has pressed the jump button
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                popUpIndex++;
            }
        }
    }
}
