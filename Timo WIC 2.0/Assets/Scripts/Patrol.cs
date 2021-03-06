﻿using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public float speed;
    private bool moveingRight;
    private NavMeshAgent agent;
    private void Start()
    {
        moveingRight = true;
        agent = gameObject.GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (moveingRight == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
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