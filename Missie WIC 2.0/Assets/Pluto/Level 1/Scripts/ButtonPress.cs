using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ButtonPress : MonoBehaviour
{
    private int posX = 0;
    public GameObject player;
    public GameObject[] nasa1;
    public GameObject nasa;
    public GameObject nasa2;
    public GameObject nasa3;
    public GameObject nasa4;
    //private bool facingRight;
    public bool Test = false;
    private void Update()
    {
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
        yield return new WaitForSeconds(5);
        Test = false;
    }
        
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.gameObject.tag == "Player" && Test == false)
        {
            posX -= 180;
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

            Test = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Test == true)
        {
            StartCoroutine(Waitforbutton());
        }
    } 
}
