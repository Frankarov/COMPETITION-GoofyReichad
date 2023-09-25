using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueOnce : MonoBehaviour
{

    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    [SerializeField] GameObject triggerDialogue;
    private BoxCollider2D boxCollider;

    private bool playerInRange;
    public FaceNPC faceNPC;
    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
    }

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
                visualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {

                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                NonAktif();
                faceNPC.ShowFace();
            }

        }
        else
        {
            visualCue.SetActive(false);
        }
    }

    private void NonAktif()
    {
            boxCollider.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }

}
