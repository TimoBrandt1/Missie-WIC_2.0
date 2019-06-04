using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ButtonPress : MonoBehaviour
{
    private int posX = 0;
    public GameObject player;
    public GameObject nasa;
    public GameObject nasa2;
    public GameObject nasa3;
    public GameObject nasa4;
    //private bool facingRight;
    public bool Test = true;
    private void Update()
    {
        Debug.Log(posX);
        /* if (Input.GetKeyDown(KeyCode.A))
         {
             facingRight = false;
         }
         if (Input.GetKeyDown(KeyCode.D))
         {
             facingRight = true;
         }
         if (facingRight == true)
         {
             Ypos = 0;
         }
         if (facingRight == false)
         {
             Ypos = 180;
         }*/
    }
    IEnumerator Waitforbutton()
    {
        yield return new WaitForSeconds(2);
        Test = true;
    }
        
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && Test == true && posX == 180)
        {
            posX = 0;
            player.transform.Rotate(posX, 0, 0);
            nasa.transform.Rotate(posX, 0, 0);
            nasa2.transform.Rotate(posX, 0, 0);
            nasa3.transform.Rotate(posX, 0, 0);
            nasa4.transform.Rotate(posX, 0, 0);
            player.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa2.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa3.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa4.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            player.GetComponent<CharacterController2D>().m_JumpForce *= -1;

            Test = false;
        }
        if (collision.gameObject.tag == "Player" && Test == true && posX == 0)
        {
            posX = 180;
            player.transform.Rotate(posX, 0, 0);
            nasa.transform.Rotate(posX, 0, 0);
            nasa2.transform.Rotate(posX, 0, 0);
            nasa3.transform.Rotate(posX, 0, 0);
            nasa4.transform.Rotate(posX, 0, 0);
            player.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa2.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa3.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa4.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            player.GetComponent<CharacterController2D>().m_JumpForce *= -1;

            Test = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && Test == false)
        {
             StartCoroutine(Waitforbutton());
        }
    }
    
}
