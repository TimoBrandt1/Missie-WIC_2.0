using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSelector : MonoBehaviour
{
    public Animator animator;
    private string planets;
    private int planetCounter = 0;
    public bool PlutoSelected;
    public bool NeptuneSelected;
    public bool UranusSelected;
    public bool SaturnSelected;
    public bool JupiterSelected;
    public bool MarsSelected;
    public bool MoonSelected;
    public bool EarthSelected;
    public bool VenusSelected;
    public bool MercurySelected;
    void Update()
    {
        Debug.Log(planetCounter);
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
        if (planets == "Neptune")
        {
            NeptuneSelected = true;
        }
        if (planets == "Uranus")
        {
            UranusSelected = true;
        }
        if (planets == "Saturn")
        {
            SaturnSelected = true;
        }
        if (planets == "Jupiter")
        {
            JupiterSelected = true;
        }
        if (planets == "Mars")
        {
            MarsSelected = true;
        }
        if (planets == "Earth")
        {
            EarthSelected = true;
        }
        if (planets == "Venus")
        {
            VenusSelected = true;
        }
        if (planets == "Mercury")
        {
            MercurySelected = true;
        }
    }
    void CheckCounter()
    {
        if (planetCounter == 1)
        {
            planets = "Pluto";
        }
        if (planetCounter == 2)
        {
            planets = "Neptune";
        }
        if (planetCounter == 3)
        {
            planets = "Uranus";
        }
        if (planetCounter == 4)
        {
            planets = "Saturn";
        }
        if (planetCounter == 5)
        {
            planets = "Jupiter";
        }
        if (planetCounter == 6)
        {
            planets = "Mars";
        }
        if (planetCounter == 7)
        {
            planets = "Moon";
        }
        if (planetCounter == 8)
        {
            planets = "Earth";
        }
        if (planetCounter == 9)
        {
            planets = "Venus";
        }
        if (planetCounter == 10)
        {
            planets = "Mercury";
        }
    }
}
