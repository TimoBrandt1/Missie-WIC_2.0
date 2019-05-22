﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideWithLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<EnemyFollow>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            //Activate follow Script
            //gameObject.GetComponent<EnemyFollow>().enabled = true;
            gameObject.GetComponent<Patrol>().enabled = false;
            GameObject.Find("Player").GetComponent<PlayerMovement>().seen = true;
            StartCoroutine(timer());
            
        }

    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(1);
        GameObject.Find("Player").GetComponent<PlayerMovement>().seen = false;
    }
}
