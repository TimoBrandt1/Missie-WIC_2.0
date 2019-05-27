using UnityEngine;

public class ButtonScript : CharacterController2D
{
    public GameObject player;
    public GameObject nasa;
    public GameObject nasa2;
    public GameObject nasa3;
    public GameObject nasa4;
    public int VectorX;
    private void Start()
    {
        VectorX = 180;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Button")
        {
                player.gameObject.transform.eulerAngles = new Vector3(0 - VectorX,0,0);
                nasa.gameObject.transform.eulerAngles *= -1;
                nasa2.gameObject.transform.eulerAngles *= -1;
                nasa3.gameObject.transform.eulerAngles *= -1;
                nasa4.gameObject.transform.eulerAngles *= -1;
                player.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa2.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa3.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa4.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                player.GetComponent<CharacterController2D>().m_JumpForce *= -1;
         }
    }
}