using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;
    public bool seen = false;

    float horizontalMove = 0f;

    bool jump = false;
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        CheckJump();

        CheckSeen();
    }
    public void CheckJump()
    {
        if (GameObject.Find("Player").GetComponent<CharacterController2D>().m_Grounded == false)
        {
            animator.SetBool("IsJumping", true);
        }
        else
        {
            animator.SetBool("IsJumping", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;

        }
    }
    public void CheckSeen()
    {
        if (seen == true)
        {
            animator.SetBool("Seen", true);
        }
        if (seen == false)
        {
            animator.SetBool("Seen", false);
        }
    }
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}
