using UnityEngine;
using System.Collections;

public class ButtonSoundPress : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {

        Debug.Log("Entered");
    }

    //Deactivate the Main function when player is go away from alarm spot
    void OnTriggerExit(Collider other)
    {

        Debug.Log("Exited");
    }
}
