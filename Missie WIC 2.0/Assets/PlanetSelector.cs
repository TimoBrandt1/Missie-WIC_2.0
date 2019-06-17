using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSelector : MonoBehaviour
{
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            planetCounter++;
        }
        if (Input.GetKey(KeyCode.D))
        {
            planetCounter++;
        }
        if (Input.GetKey(KeyCode.A))
        {
            planetCounter--;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            planetCounter--;
        }
        CheckCounter();
        CheckPlanet();
    }
    void CheckPlanet()
    {
        if (planets == "Pluto")
        {
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
        //Uranus
        //Saturnus
        //Jupiter
        //Mars
        //Maan
        //Aarde
        //Venus
        //Mercurius
    }
}
