using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSelector : MonoBehaviour
{
    public Animator animator;
    private string planets;
    private int planetCounter;
    public bool PlutoSelected;
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            planetCounter =+ 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            planetCounter =+ 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            planetCounter =- 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            planetCounter =- 1;
        }
        if (planetCounter <= 0)
        {
            planetCounter = 0;
        }
        CheckCounter();
        CheckPlanet();
    }
    void CheckPlanet()
    {
        if (planets == "Pluto")
        {
            animator.SetBool("PlutoSelected", true);
            PlutoSelected = true;
        }
    }
    void CheckCounter()
    {
        if (planetCounter == 1)
        {
            planets = "Pluto";
        }
    }
}
