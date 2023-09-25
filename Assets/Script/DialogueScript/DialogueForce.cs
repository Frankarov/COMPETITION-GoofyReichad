using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueForce : MonoBehaviour
{



    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    [SerializeField] GameObject triggerDialogue;
    private BoxCollider2D boxCollider;

    private bool playerInRange;
    public FaceNPC faceNPC;
    private void Awake()
    {
        playerInRange = false;
    }

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {

            DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            StartCoroutine(NonAktifTemp());
            faceNPC.ShowFace();
        }
        else
        {

        }
    }

    private IEnumerator NonAktifTemp()
    {
            boxCollider.enabled = false;
            yield return new WaitForSeconds(20); //ini ada bug dikit
            Debug.Log("waktunya disable boxcollider");
            boxCollider.enabled = true;
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
