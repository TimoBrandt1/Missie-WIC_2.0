using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSelector : MonoBehaviour
{
    private ArrayList[] planet;
    public bool PlutoSelected;
    private void Start()
    {
        planet = Pluto;
    }
    void Update()
    {
        if (planet == Pluto)
        {
            PlutoSelected = true;
        }
    }
}
