using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    public int Xpos;
    public float speed;
    private bool movingRight;
    private NavMeshAgent agent;
    private void Start()
    {
        Xpos = 0;
        movingRight = true;
        agent = gameObject.GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (movingRight == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "1")
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            movingRight = true;
        }
        if (other.gameObject.tag == "2")
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
        }
    }
}