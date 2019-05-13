using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    //The main player
    public GameObject player;

    //The inventory slots
    public GameObject[] itemSlots = new GameObject[5];
    public int selectedSlot = 0;
    public Transform selectedSlotMarker;

    //Item size
    public float itemScale = 0.6f;

    //The inventory itself
    private ArrayList items = new ArrayList();

    //The main player hand (where we display the item in hand)
    public GameObject mainHand;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() {
        //Here we handle inventory related input

        //When the player wants to drop an item
        if (Input.GetKeyDown(KeyCode.Q)) {
            GameObject currentObject = useItemInSlot(selectedSlot);
            if (currentObject == null) return;
            currentObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 0);
            currentObject.transform.parent.gameObject.SetActive(true);
            currentObject.GetComponent<Item>().dropAudio(currentObject.GetComponent<AudioSource>());
        }

        //When the player wants to trow an item
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            GameObject currentObject = (GameObject)items[selectedSlot];
            if (currentObject == null) return;
            if (!currentObject.GetComponent<Item>().isTrowable) return;

            //Throwing the object
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 mouseDir = mousePos - gameObject.transform.position;
            mouseDir.z = 0.0f;
            mouseDir = mouseDir.normalized;

            player.GetComponent<CharacterController2D>().Move(mouseDir.x, false, false);
            player.GetComponent<Animator>().SetBool("throwing", true);
            player.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Audio/Player/Throwing"));
        }

        //Scroll through slots
        if (Input.GetAxis("Mouse ScrollWheel") < 0) {
            selectedSlot++;
            if (selectedSlot >= itemSlots.Length) selectedSlot = 0;
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0) {
            selectedSlot--;
            if (selectedSlot < 0) selectedSlot = itemSlots.Length - 1;
        }

        //Select an slot with the number keys
        if (Input.GetKeyDown(KeyCode.Alpha1)) selectedSlot = 0;
        if (Input.GetKeyDown(KeyCode.Alpha2)) selectedSlot = 1;
        if (Input.GetKeyDown(KeyCode.Alpha3)) selectedSlot = 2;
        if (Input.GetKeyDown(KeyCode.Alpha4)) selectedSlot = 3;
        if (Input.GetKeyDown(KeyCode.Alpha5)) selectedSlot = 4;

        //Update marker and hand
        selectedSlotMarker.position = itemSlots[selectedSlot].transform.position;
        mainHand.GetComponent<SpriteRenderer>().sprite = itemSlots[selectedSlot].gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    //This function will add an item to the inventory, it will return false when the inventory is full
    public bool AddItemToInventory(GameObject item) {
        if (items.Count >= itemSlots.Length) return false;
        items.Add(item);
        updateInventory();
        return true;
    }

    //This will sync the visual inventory with the arraylist
    private void updateInventory() {
        int index = 0;
        foreach(GameObject item in items) {
            itemSlots[index].GetComponent<SpriteRenderer>().sprite = item.GetComponent<SpriteRenderer>().sprite;
            itemSlots[index].transform.localScale = new Vector3(itemScale, itemScale, 0);
            index++;
        }

        index = 0;
        foreach (GameObject item in itemSlots) {
            bool removeItem = true;

            if(index < items.Count) {
                if (item.GetComponent<SpriteRenderer>().sprite == ((GameObject)items[index]).GetComponent<SpriteRenderer>().sprite) removeItem = false;
            }

            if (removeItem) item.GetComponent<SpriteRenderer>().sprite = null;
            index++;
        }
    }

    //Check if inventory contains an object or not
    public bool Contains(GameObject item) {
        if (items.Contains(item)) return true;
        return false;
    }

    //Take item from inventory
    public GameObject useItemInSlot(int slot) {
        if (items.Count <= slot) return null;
        GameObject item = (GameObject)items[slot];
        items.Remove(item);
        updateInventory();
        return item;
    }

    //Throw current object funtion (gets called at the end of the trhowing animation)
    public void throwItem() {
        GameObject currentObject = useItemInSlot(selectedSlot);
        if (!currentObject.GetComponent<Item>().isTrowable) return;

        currentObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 0);
        currentObject.transform.parent.gameObject.SetActive(true);

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mouseDir = mousePos - gameObject.transform.position;
        mouseDir.z = 0.0f;
        mouseDir = mouseDir.normalized;
        currentObject.GetComponent<Rigidbody2D>().AddForce(mouseDir * 1000);
        currentObject.GetComponent<Item>().isThrown = true;
    }
} 
