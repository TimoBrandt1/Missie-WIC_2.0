using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collideWithLight : MonoBehaviour
{
    public GameObject Gun;
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
            GameObject.Find("Player").GetComponent<PlayerMovement>().seen = true;
            GameObject.Find("Player").GetComponent<CharacterController2D>().enabled = false;

            Destroy(Gun);
            gameObject.GetComponent<NasaAnimation>().SpottedAlienWithLight = true;
            gameObject.GetComponent<Patrol>().enabled = false;

            StartCoroutine(Timer());
        }

    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1);
        GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("GameOver");
    }
}
