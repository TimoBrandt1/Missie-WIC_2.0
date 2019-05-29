using UnityEngine;

public class ButtonPress : CharacterController2D
{   
    private int Xpos = 0;
    private int Ypos = 0;
    public GameObject player;
    public GameObject nasa;
    public GameObject nasa2;
    public GameObject nasa3;
    public GameObject nasa4;
    private bool facingRight;
    private void Update()
    {
        Debug.Log(facingRight);
        Debug.Log(Ypos);
        Debug.Log(Xpos);
        if (Input.GetKeyDown(KeyCode.A))
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
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Xpos -= 180;
            if (facingRight == true)
            {
                Ypos = 0;
            }
            if (facingRight == false)
            {
                Ypos = 180;
            }
            player.gameObject.transform.eulerAngles = new Vector3(Xpos, 0, 0);
            nasa.gameObject.transform.eulerAngles = new Vector3(Xpos, 0, 0);
            nasa2.gameObject.transform.eulerAngles = new Vector3(Xpos, 0, 0);
            nasa3.gameObject.transform.eulerAngles = new Vector3(Xpos, 0, 0);
            nasa4.gameObject.transform.eulerAngles = new Vector3(Xpos, 0, 0);
            player.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa2.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa3.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            nasa4.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            player.GetComponent<CharacterController2D>().m_JumpForce *= -1;
            
        }
    }
}
