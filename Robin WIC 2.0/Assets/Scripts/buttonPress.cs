using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour
{
    public GameObject player;
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
                player.gameObject.transform.eulerAngles = new Vector3(0, 0, 180);
                ReversedGravity = true;
            }
            else
            {
                player.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                player.gameObject.GetComponent<Rigidbody2D>().gravityScale *= 1;
                ReversedGravity = false;
            }
        }
    }
}
