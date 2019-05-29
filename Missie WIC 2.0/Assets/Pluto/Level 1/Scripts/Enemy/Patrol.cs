using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    public float speed;
    private bool moveingRight;
    private NavMeshAgent agent;
    Vector2 direction;
    private void Start()
    {
        moveingRight = true;
        //direction = Vector2.right;
        agent = gameObject.GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (moveingRight == true)
        {
            //transform.Translate(direction* speed * Time.deltaTime);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        direction = -direction;
        if (other.gameObject.tag == "1")
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            moveingRight = true;
        }
        if (other.gameObject.tag == "2")
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
        }
    }
}