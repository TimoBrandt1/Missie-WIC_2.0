using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEquip : MonoBehaviour
{
    public GameObject gun;
    public bool PlayerGunSprite;
    private SpriteRenderer SpriteRenderer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "GlitterGun")
        {
            Destroy(this.gameObject);
            PlayerGunSprite = true;
            gun.GetComponent<SpriteRenderer>();
        }
    }
}
