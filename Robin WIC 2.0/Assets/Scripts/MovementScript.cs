using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float speed;
    public float floatHeight;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
      void FixedUpdate()
    {
            if (Input.GetKey(KeyCode.Space)||Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.W))
            {
            transform.position += Vector3.up * speed * Time.deltaTime; 
            }
        }
}

