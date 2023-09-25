using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenentuanDialogue : MonoBehaviour
{
    public int dialogueInt = 0; // The integer value to store the dialogue determination
    public int checkpointInt = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("TagA"))
        {
            dialogueInt = 1;
        }
        else if (collision.CompareTag("TagB"))
        {
            dialogueInt = 2;
        }
        else if(collision.CompareTag("TagC")){
            dialogueInt = 3;
        }
        else if (collision.CompareTag("TagD"))
        {
            dialogueInt = 4;
        }
        else if (collision.CompareTag("TagE"))
        {
            dialogueInt = 5;
        }
        else if (collision.CompareTag("TagF"))
        {
            dialogueInt = 6;
        }
        else if (collision.CompareTag("TagG"))
        {
            dialogueInt = 7;
        }
        else if (collision.CompareTag("TagH"))
        {
            dialogueInt = 8;
        }
        else if (collision.CompareTag("TagI"))
        {
            dialogueInt = 9;
        }
        else if (collision.CompareTag("TagJ"))
        {
            dialogueInt = 10;
        }
        else if (collision.CompareTag("TagK"))
        {
            dialogueInt = 11;
        }
        else if (collision.CompareTag("TagL"))
        {
            dialogueInt = 12;
        }
        else if (collision.CompareTag("TagM"))
        {
            dialogueInt = 13;
        }else if (collision.CompareTag("TagN"))
        {
            dialogueInt = 14;
        }
        else if (collision.CompareTag("TagDUNGEON"))
        {
            dialogueInt = 50;
        }
        else if (collision.CompareTag("TagCHECK"))
        {
            checkpointInt = 1;
        }
        else if (collision.CompareTag("TagCHECK2"))
        {
            checkpointInt = 2;
        }
        // Add more else if statements for other tags if needed

        // You can now use 'dialogueInt' to determine which dialogue to trigger or handle the dialogue logic accordingly
    }
}
