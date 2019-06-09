using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ButtonPress : MonoBehaviour
{
    private int posX = 0;
    public GameObject player;
    public GameObject[] nasa1;
    //public GameObject nasa;
    //public GameObject nasa2;
    //public GameObject nasa3;
    //public GameObject nasa4;
    //private bool facingRight;
    public bool Test = true;
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
        yield return new WaitForSeconds(2);
        Test = true;
    }
        
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.gameObject.tag == "Player" && Test == true)
        {
            posX -= 180;
            player.transform.Rotate(posX, 0, 0);
            player.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            player.GetComponent<CharacterController2D>().m_JumpForce *= -1;
            foreach (var nasa in nasa1)
            {
                transform.Rotate(posX, 0, 0);
                gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            }
            Test = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Test == false)
        {
            StartCoroutine(Waitforbutton());
        }
    } 
}
