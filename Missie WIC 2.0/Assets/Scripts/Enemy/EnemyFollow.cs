using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyFollow : MonoBehaviour
{
    public float speed;
    public bool FacingRight;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(5);
        GameObject.Find("Player").GetComponent<Patrol>().enabled = true;
        GameObject.Find("Player").GetComponent<EnemyFollow>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Flip();
        CheckWalkPos();
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    public void Flip()
    {
        if (FacingRight == true)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (FacingRight == false)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
        }
    }

    public void CheckWalkPos()
    {
        if (transform.position.x > GameObject.Find("Player").transform.position.x)
        {
            FacingRight = false;
        }
        if (transform.position.x < GameObject.Find("Player").transform.position.x)
        {
            FacingRight = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "MaxFollowPos")
        {
            StartCoroutine(timer());
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //GAME OVER LOAD MISSION FAILED SCREEN
        }
    }
}
