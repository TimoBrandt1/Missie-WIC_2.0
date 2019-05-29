using UnityEngine;

public class ButtonPress : MonoBehaviour
{   
    private int posX = 0;
    private int Ypos = 0;
    public GameObject player;
    public GameObject nasa;
    public GameObject nasa2;
    public GameObject nasa3;
    public GameObject nasa4;
    //private bool facingRight;
    private bool Test = true;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && Test == true)
        {
            Test = false;
            
            /*if (facingRight == true)
            {
                Ypos = 0;
            }
            if (facingRight == false)
            {
                Ypos = 180;
            }*/
            posX -= 180;
            player.transform.Rotate(posX, 0, 0);
            nasa.transform.Rotate(posX, 0, 0);
            nasa2.transform.Rotate(posX, 0, 0);
            nasa3.transform.Rotate(posX, 0, 0);
            nasa4.transform.Rotate(posX, 0, 0);
            /*
            nasa.gameObject.transform.eulerAngles = new Vector3(posX, 0, 0);
            nasa2.gameObject.transform.eulerAngles = new Vector3(posX, 0, 0);
            nasa3.gameObject.transform.eulerAngles = new Vector3(posX, 0, 0);
            nasa4.gameObject.transform.eulerAngles = new Vector3(posX, 0, 0);
            */
            player.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa2.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa3.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa4.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            player.GetComponent<CharacterController2D>().m_JumpForce *= -1;
            
        }
    }
}
