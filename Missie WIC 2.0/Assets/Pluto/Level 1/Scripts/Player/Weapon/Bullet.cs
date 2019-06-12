using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool Hit = false;
    // Start is called before the first frame update
    void Update()
    {
        if (Hit == false)
        {
            Destroy(gameObject, 1);
        }
        transform.position = GameObject.FindWithTag("Player").GetComponent<Weapon>().firePoint.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        if (hitInfo.gameObject.tag == "Enemy")
        {
            hitInfo.gameObject.GetComponent<Patrol>().enabled = false;
            hitInfo.gameObject.GetComponent<collideWithLight>().enabled = false;
            StartCoroutine(Timer());
            Hit = true;
        }
        Destroy(gameObject, 1);
    }
 
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1f);
        GameObject.Find("nasa (1)").GetComponent<Patrol>().enabled = true;
        GameObject.Find("nasa (1)").GetComponent<collideWithLight>().enabled = true;
        GameObject.Find("nasa (2)").GetComponent<Patrol>().enabled = true;
        GameObject.Find("nasa (2)").GetComponent<collideWithLight>().enabled = true;
        GameObject.Find("nasa (3)").GetComponent<Patrol>().enabled = true;
        GameObject.Find("nasa (3)").GetComponent<collideWithLight>().enabled = true;
        GameObject.Find("nasa (4)").GetComponent<Patrol>().enabled = true;
        GameObject.Find("nasa (4)").GetComponent<collideWithLight>().enabled = true;
    }
}
