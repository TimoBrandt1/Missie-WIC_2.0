using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;

    private NavMeshAgent agent;
    private void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }
    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "1")
        {
            agent.SetDestination(pos2.position);
        }
        if (other.tag == "2")
        {
            agent.SetDestination(pos1.position);
        }
    }
}