using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelection : MonoBehaviour
{
    public int levelCounter;
    public string level;
    public Animator animator;


    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            levelCounter =+ 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            levelCounter =+ 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            levelCounter =- 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            levelCounter =- 1;
        }
        CheckCounter();
    }

    void CheckCounter()
    {
        if (levelCounter == 1)
        {
            animator.SetInteger("New Int", 1);
        }
        if (levelCounter == 1)
        {
            animator.SetInteger("New Int", 2);
        }
        if (levelCounter == 1)
        {
            animator.SetInteger("New Int", 3);
        }
        if (levelCounter == 1)
        {
            animator.SetInteger("New Int", 4);
        }
        if (levelCounter == 1)
        {
            animator.SetInteger("New Int", 5);
        }
        if (levelCounter == 1)
        {
            animator.SetInteger("New Int", 6);
        }
    }
}
