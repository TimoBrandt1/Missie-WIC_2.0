using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public float speed;
    private bool movingRight;
    private void Start()
    {
        movingRight = true;
    }
    void Update()
    {
        if (movingRight == false)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (movingRight == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.tag == "1")
        {
            transform.Rotate(0, 0, 0);
        }
        if (gameObject.tag == "2")
        {
            transform.Rotate(0, 180, 0);
        }
        if (other.gameObject.tag == "3")
        {
            transform.Rotate(0, 180, 0);
        }
        if (other.gameObject.tag == "4")
        {
            transform.Rotate(0, 180, 0);
        }
    }
}