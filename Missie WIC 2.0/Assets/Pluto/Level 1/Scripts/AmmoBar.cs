using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBar : MonoBehaviour
{
    public int ammo = 9; 
    public GameObject Bar0;
    public GameObject Bar1;
    public GameObject Bar2;
    public GameObject Bar3;
    public GameObject Bar4;
    public GameObject Bar5;
    public GameObject Bar6;
    public GameObject Bar7;
    public GameObject Bar8;
    public GameObject Bar9;

    private bool IsCreatedBar0 = false;
    private bool IsCreatedBar1 = false;
    private bool IsCreatedBar2 = false;
    private bool IsCreatedBar3 = false;
    private bool IsCreatedBar4 = false;
    private bool IsCreatedBar5 = false;
    private bool IsCreatedBar6 = false;
    private bool IsCreatedBar7 = false;
    private bool IsCreatedBar8 = false;
    private bool IsCreatedBar9 = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ammo == 9 && IsCreatedBar9 == false)
        {
            Instantiate(Bar9);
            IsCreatedBar9 = true;
        }
        if (ammo == 8 && IsCreatedBar8 == false)
        {
            Instantiate(Bar8);
            Destroy(GameObject.Find("bar full(Clone)"));
            IsCreatedBar8 = true;
        }
        if (ammo == 7 && IsCreatedBar7 == false)
        {
            Instantiate(Bar7);
            Destroy(GameObject.Find("bar 90(Clone)"));
            IsCreatedBar7 = true;
        }
        if (ammo == 6 && IsCreatedBar6 == false)
        {
            Instantiate(Bar6);
            Destroy(GameObject.Find("bar 80(Clone)"));
            IsCreatedBar6 = true;
        }
        if (ammo == 5 && IsCreatedBar5 == false)
        {
            Instantiate(Bar5);
            Destroy(GameObject.Find("bar 70(Clone)"));
            IsCreatedBar5 = true;
        }
        if (ammo == 4 && IsCreatedBar4 == false)
        {
            Instantiate(Bar4);
            Destroy(GameObject.Find("bar 50(Clone)"));
            IsCreatedBar4 = true;
        }
        if (ammo == 3 && IsCreatedBar3 == false)
        {
            Instantiate(Bar3);
            Destroy(GameObject.Find("bar 40(Clone)"));
            IsCreatedBar3 = true;
        }
        if (ammo == 2 && IsCreatedBar2 == false)
        {
            Instantiate(Bar2);
            Destroy(GameObject.Find("bar 30(Clone)"));
            IsCreatedBar2 = true;
        }
        if (ammo == 1 && IsCreatedBar1 == false)
        {
            Instantiate(Bar1);
            Destroy(GameObject.Find("bar 20(Clone)"));
            IsCreatedBar1 = true;
        }
        if (ammo == 0 && IsCreatedBar0 == false)
        {
            Instantiate(Bar0);
            Destroy(GameObject.Find("bar 10(Clone)"));
            IsCreatedBar0 = true;
        }
    }
    
}
