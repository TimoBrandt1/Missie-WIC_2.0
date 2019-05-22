using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starPickup : MonoBehaviour
{
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject Star1Prefab;
    public GameObject Star2Prefab;
    public GameObject Star3Prefab;
    // Start is called before the first frame update

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Star1")
        {
            Destroy(star1);
            Instantiate(Star1Prefab);
        }
        if (collision.gameObject.name == "Star2")
        {
            Destroy(star2);
            Instantiate(Star2Prefab);
        }
        if (collision.gameObject.name == "Star3")
        {
            Destroy(star3);
            Instantiate(Star3Prefab);
        }
    }
}
