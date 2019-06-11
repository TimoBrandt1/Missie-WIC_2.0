using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalHandeler : MonoBehaviour
{
    public Animator animator;
    public int starsCollectedForPortal; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        starsCollectedForPortal = GameObject.Find("Player").GetComponent<starPickup>().StarsCollected;
        if (starsCollectedForPortal == 3)
        {
            animator.SetBool("AllStarsCollected", true);
            StartCoroutine(Timer());
            Debug.Log("Test");
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(2);
        animator.SetBool("OpeningFinished", true);
    }
}
