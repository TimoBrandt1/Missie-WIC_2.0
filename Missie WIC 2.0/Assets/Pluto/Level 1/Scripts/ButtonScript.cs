using UnityEngine;
using System.Collections.Generic;

public class ButtonScript : CharacterController2D
{
    public GameObject player;
    public GameObject nasa;
    public GameObject nasa2;
    public GameObject nasa3;
    public GameObject nasa4;
    public GameObject[] enemies;

    private int posX = 0;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            posX -= 180;
            player.gameObject.transform.eulerAngles = new Vector3(posX,0,0);
            /*nasa.gameObject.transform.eulerAngles = new Vector3(posX, 0, 0);
            nasa2.gameObject.transform.eulerAngles = new Vector3(posX, 0, 0);
            nasa3.gameObject.transform.eulerAngles = new Vector3(posX, 0, 0);
            nasa4.gameObject.transform.eulerAngles = new Vector3(posX, 0, 0);
            */
            player.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            /*
            nasa.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa2.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa3.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa4.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            */
            player.GetComponent<CharacterController2D>().m_JumpForce *= -1;

            foreach(GameObject enem in enemies)
            {
                enem.transform.eulerAngles = new Vector3(posX, 0, 0);
                enem.GetComponent<Rigidbody2D>().gravityScale *= -1;
            }


         }
    }
}