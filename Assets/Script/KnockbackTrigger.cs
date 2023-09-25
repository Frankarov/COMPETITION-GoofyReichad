using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockbackTrigger : MonoBehaviour
{

    public PlayerMovement playerMovement;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("kenaplayer");
            playerMovement.KBCounter = 0.1f;
            if(other.transform.position.x <= transform.position.x)
            {
                playerMovement.KnockFromRight = true;
            }
            if (other.transform.position.x > transform.position.x)
            {
                playerMovement.KnockFromRight = false;
            }
        }
    }


}
