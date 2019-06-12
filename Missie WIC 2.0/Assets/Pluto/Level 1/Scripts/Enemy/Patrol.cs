using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public Transform Pos1;
    public Transform Pos2;
    public float speed;
    private bool movingRight;
    private bool Reversed;
    private int Xpos;
    private void Start()
    {
        movingRight = true;
        Reversed = GameObject.Find("button").GetComponent<ButtonPress>().Test;
    }
    void Update()
    {
        Xpos = GameObject.Find("button").GetComponent<ButtonPress>().posX;
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
        if (other.gameObject.tag == "1")
        {
            transform.Rotate(Xpos, 0, 0);
            movingRight = true;
        }
        if (other.gameObject.tag == "2")
        {
            transform.Rotate(Xpos, -180, 0);
        }
    }
}