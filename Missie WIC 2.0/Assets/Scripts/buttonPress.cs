﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            player.gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            player.gameObject.transform.eulerAngles = new Vector3(0,0,180);
        }
    }
}
