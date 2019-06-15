using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[RequireComponent(typeof(AudioSource))]
public class ButtonPress : MonoBehaviour
{
    public int posX = 0;
    public GameObject player;
    public GameObject[] nasa1;
    public bool Test = true;
    IEnumerator Waitforbutton()
    {
        yield return new WaitForSeconds(2);
        Test = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Test == true)
        {
            posX = 180;
            foreach (var nasa in nasa1)
            {
                nasa.transform.Rotate(posX, 0, 0);
                nasa.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            }
            player.transform.Rotate(posX, 0, 0);
            player.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            player.GetComponent<CharacterController2D>().m_JumpForce *= -1;
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