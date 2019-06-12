using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolTutorial : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    public float speed;
    private bool movingRight;
    private int Xpos;
    //Vector2 direction;
    private void Start()
    {
        Xpos = 0;
        movingRight = true;
        //direction = Vector2.right;
    }
    void Update()
    {
        if (movingRight == false)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (movingRight == true)
        {
            //transform.Translate(direction* speed * Time.deltaTime);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //direction = -direction;
        if (other.gameObject.tag == "1")
        {
            transform.eulerAngles = new Vector3(Xpos, 0, 0);
            movingRight = true;
        }
        if (other.gameObject.tag == "2")
        {
            transform.eulerAngles = new Vector3(Xpos, -180, 0);
        }
    }
}
