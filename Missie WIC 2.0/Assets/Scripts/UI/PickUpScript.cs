using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    private Inventory inventory;
    public GameObject GunButton;
    // Start is called before the first frame update
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //ITEM CAN BE ADDED TO INVENTORY !
                    inventory.isFull[i] = true;
                    Instantiate(GunButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }

            }
        }
    }
}

