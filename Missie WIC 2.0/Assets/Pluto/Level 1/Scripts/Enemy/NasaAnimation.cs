using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NasaAnimation : MonoBehaviour
{
    public Animator animator;

    public bool SpottedAlienWithLight = false;
    // Update is called once per frame
    void Update()
    {
        CheckSpottedAlien();
    }
    public void CheckSpottedAlien()
    {
        if (SpottedAlienWithLight == true)
        {
            gameObject.GetComponent<Patrol>().enabled = false;
            gameObject.GetComponent<PatrolTutorial>().enabled = false;
            animator.SetBool("SpottedAlien", true);
        }
        if (SpottedAlienWithLight == false)
        {
            animator.SetBool("SpottedAlien", false);
        }
    }
}
