using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrebaf;
    public int Ammo = 9;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Ammo >= 0)
        {
            Shoot();
            Ammo--;
            GameObject.Find("InstantiateGameObjects").GetComponent<AmmoBar>().ammo--;
        }

    }

    void Shoot()
    {
        Instantiate(bulletPrebaf, firePoint.position, firePoint.rotation);
    }
}