using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceNPC : MonoBehaviour
{
    public GameObject NPCFace;
    public Image image;


    private void Start()
    {
        image = NPCFace.GetComponent<Image>();
    }

    public void ShowFace()
    {

        NPCFace.GetComponent<Image>().enabled = true;

    }
}

