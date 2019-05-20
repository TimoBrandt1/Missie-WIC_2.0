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
            
            Hit = true;
        }
        Destroy(gameObject, 1);
    }
}
