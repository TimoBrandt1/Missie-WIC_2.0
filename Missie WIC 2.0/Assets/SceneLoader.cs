using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public bool plutoSelected;
    public bool neptuneSelected;
    public bool uranusSelected;
    public bool saturnSelected;
    public bool jupiterSelected;
    public bool marsSelected;
    public bool moonSelected;
    public bool earthSelected;
    public bool venusSelected;
    public bool mercurySelected;
    void Update()
    {
        plutoSelected = GameObject.Find("Scriptholder").GetComponent<PlanetSelector>().PlutoSelected;
        neptuneSelected = GameObject.Find("Scriptholder").GetComponent<PlanetSelector>().NeptuneSelected;
        uranusSelected = GameObject.Find("Scriptholder").GetComponent<PlanetSelector>().UranusSelected;
        saturnSelected = GameObject.Find("Scriptholder").GetComponent<PlanetSelector>().SaturnSelected;
        jupiterSelected = GameObject.Find("Scriptholder").GetComponent<PlanetSelector>().JupiterSelected;
        marsSelected = GameObject.Find("Scriptholder").GetComponent<PlanetSelector>().MarsSelected;
        moonSelected = GameObject.Find("Scriptholder").GetComponent<PlanetSelector>().MoonSelected;
        earthSelected = GameObject.Find("Scriptholder").GetComponent<PlanetSelector>().EarthSelected;
        venusSelected = GameObject.Find("Scriptholder").GetComponent<PlanetSelector>().VenusSelected;
        mercurySelected = GameObject.Find("Scriptholder").GetComponent<PlanetSelector>().MercurySelected;
        if (Input.GetKey(KeyCode.Return) && plutoSelected == true)
        {
            SceneManager.LoadScene("PlutoLevelSelectie");
        }
    }
}
