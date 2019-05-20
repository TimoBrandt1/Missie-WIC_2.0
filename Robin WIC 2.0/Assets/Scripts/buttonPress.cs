using UnityEngine;

public class ButtonPress : CharacterController2D
{
    public GameObject player;
    public GameObject nasa;
    public GameObject nasa2;
    public GameObject nasa3;
    public GameObject nasa4;
    public bool ReversedGravity = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Button")
        {            
            if (ReversedGravity == true)
            {
                player.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                nasa.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                nasa2.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                nasa3.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                nasa4.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                player.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa2.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa3.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa4.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                player.GetComponent<CharacterController2D>().m_JumpForce = 450;
                ReversedGravity = false;
            }
            else 
            {
                player.gameObject.transform.eulerAngles = new Vector3(180, 0, 0);
                nasa.gameObject.transform.eulerAngles = new Vector3(180, 0, 0);
                nasa2.gameObject.transform.eulerAngles = new Vector3(180, 0, 0);
                nasa3.gameObject.transform.eulerAngles = new Vector3(180, 0, 0);
                nasa4.gameObject.transform.eulerAngles = new Vector3(180, 0, 0);
                player.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa2.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa3.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa4.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                player.GetComponent<CharacterController2D>().m_JumpForce = -450;
                ReversedGravity = true;
            }
        }
    }
}
