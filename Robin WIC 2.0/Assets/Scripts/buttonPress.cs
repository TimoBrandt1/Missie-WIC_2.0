using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour
{
    public GameObject player;
    public GameObject nasa;
    public GameObject nasa2;
    public GameObject nasa3;
    public GameObject nasa4;
    private bool ReversedGravity = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (ReversedGravity == false)
            {
                player.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa2.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa3.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                nasa4.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
                player.gameObject.transform.eulerAngles = new Vector3(180, 0, 0);
                nasa.gameObject.transform.eulerAngles = new Vector3(180, 0, 0);
                nasa2.gameObject.transform.eulerAngles = new Vector3(180, 0, 0);
                nasa3.gameObject.transform.eulerAngles = new Vector3(180, 0, 0);
                nasa4.gameObject.transform.eulerAngles = new Vector3(180, 0, 0);

                ReversedGravity = true;
            }
            else
            {
                player.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                nasa.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                nasa2.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                nasa3.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                nasa4.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                player.gameObject.GetComponent<Rigidbody2D>().gravityScale *= 1;
                nasa.gameObject.GetComponent<Rigidbody2D>().gravityScale *= 1;
                nasa2.gameObject.GetComponent<Rigidbody2D>().gravityScale *= 1;
                nasa3.gameObject.GetComponent<Rigidbody2D>().gravityScale *= 1;
                nasa4.gameObject.GetComponent<Rigidbody2D>().gravityScale *= 1;

                ReversedGravity = false;
            }
        }
    }
}
