using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public GameObject doorClose;
    private BoxCollider2D boxCollideDoor;
    private BoxCollider2D boxColliderTrigger;
    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        boxCollideDoor = doorClose.GetComponent<BoxCollider2D>();
        boxColliderTrigger = doorClose.GetComponent<BoxCollider2D>();
        spriteRenderer = doorClose.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            boxCollideDoor.enabled = true;
            spriteRenderer.enabled = true;
        }
    }

}
