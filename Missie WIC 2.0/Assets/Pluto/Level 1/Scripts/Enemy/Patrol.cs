using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    public float speed;
    private bool moveingRight;
    private bool Reversed;
    private NavMeshAgent agent;
    private int Xpos;
    //Vector2 direction;
    private void Start()
    {
        Xpos = 0;
        moveingRight = true;
        //direction = Vector2.right;
        agent = gameObject.GetComponent<NavMeshAgent>();
        Reversed = GameObject.Find("button").GetComponent<ButtonPress>().Test;
    }
    void Update()
    {
        if (  == false)
        {
            Xpos = 180;
        }
        if (moveingRight == true)
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
        moveingRight = true;
        }
        if (other.gameObject.tag == "2")
        {
            transform.eulerAngles = new Vector3(Xpos, -180, 0);
        }
    }
}