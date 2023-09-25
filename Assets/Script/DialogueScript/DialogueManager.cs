using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{
    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private UnityEngine.UI.Text dialogueText;
    private PenentuanDialogue penentuanDialogue;

    private Ink.Runtime.Story currentStory;

    [Header("Choices of UI")]
    [SerializeField] private GameObject[] choices;
    private UnityEngine.UI.Text[] choicesText;

    public bool dialogueIsPlaying { get; private set; }

    private static DialogueManager instance;

    public GameObject HoodieFace;
    public GameObject NPCFace1;
    public GameObject NPCFace2;
    public GameObject NPCFace3;
    public GameObject NPCFace4;
    public GameObject NPCFace5;
    public GameObject NPCFace6;
    public GameObject NPCFace7;
    public GameObject NPCFace8;
    public GameObject NPCFace9;
    public GameObject NPCFace10;
    public GameObject NPCFace11;
    public GameObject NPCFace12;
    public GameObject NPCFace13;
    public GameObject PENJAGADUNGEON;
    public Image imageHoodieFace;
    public Image imageNPCFace1;
    public Image imageNPCFace2;
    public Image imageNPCFace3;
    public Image imageNPCFace4;
    public Image imageNPCFace5;
    public Image imageNPCFace6;
    public Image imageNPCFace7;
    public Image imageNPCFace8;
    public Image imageNPCFace9;
    public Image imageNPCFace10;
    public Image imageNPCFace11;
    public Image imageNPCFace12;
    public Image imageNPCFace13;
    public Image imagePENJAGADUNGEON;
    //public FaceNPC faceNPC;


    private void Awake()
    {
        instance = this;
    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    private void Start()
    {
        imageHoodieFace = HoodieFace.GetComponent<Image>();
        imageNPCFace1 = NPCFace1.GetComponent<Image>();
        imageNPCFace2 = NPCFace2.GetComponent<Image>();
        imageNPCFace3 = NPCFace3.GetComponent<Image>();
        imageNPCFace4 = NPCFace4.GetComponent<Image>();
        imageNPCFace5 = NPCFace5.GetComponent<Image>();
        imageNPCFace6 = NPCFace5.GetComponent<Image>();
        imageNPCFace7 = NPCFace5.GetComponent<Image>();
        imageNPCFace8 = NPCFace5.GetComponent<Image>();
        imageNPCFace9 = NPCFace5.GetComponent<Image>();
        imageNPCFace10 = NPCFace5.GetComponent<Image>();
        imageNPCFace11 = NPCFace5.GetComponent<Image>();
        imageNPCFace12 = NPCFace5.GetComponent<Image>();
        imageNPCFace13 = NPCFace5.GetComponent<Image>();
        imagePENJAGADUNGEON = PENJAGADUNGEON.GetComponent<Image>();
        penentuanDialogue = FindObjectOfType<PenentuanDialogue>();

        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

        choicesText = new UnityEngine.UI.Text[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<UnityEngine.UI.Text>();
            index++;
        }

    }

    private void Update()
    {
        if(!dialogueIsPlaying)
        {
            return;
        }
        if (currentStory.currentChoices.Count == 0 &&Input.GetKeyUp(KeyCode.E))
        {

            ContinueStory();


        }
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        dialoguePanel.SetActive(true);
        currentStory = new Ink.Runtime.Story(inkJSON.text);
        ContinueStory();
        dialogueIsPlaying = true;
    }
    /* === */
    private void ExitDialogueMode()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";


        if (penentuanDialogue != null)
        {
            int dialogueInt = penentuanDialogue.dialogueInt;
            if (dialogueInt == 1)
            {
                HoodieFace.GetComponent<Image>().enabled = false;
            }
            else if (dialogueInt == 2)
            {
                NPCFace1.GetComponent<Image>().enabled = false;
            }
            else if (dialogueInt == 3)
            {
                NPCFace2.GetComponent<Image>().enabled = false;
            }
            else if (dialogueInt == 4)
            {
                NPCFace3.GetComponent<Image>().enabled = false;
            }
            else if (dialogueInt == 5)
            {
                NPCFace4.GetComponent<Image>().enabled = false;
            }
            else if (dialogueInt == 6)
            {
                NPCFace5.GetComponent<Image>().enabled = false;
            }
            else if (dialogueInt == 7)
            {
                NPCFace6.GetComponent<Image>().enabled = false;
            }
            else if (dialogueInt == 8)
            {
                NPCFace7.GetComponent<Image>().enabled = false;
            }
            else if (dialogueInt == 9)
            {
                NPCFace8.GetComponent<Image>().enabled = false;
            }
            else if (dialogueInt == 50)
            {
                PENJAGADUNGEON.GetComponent<Image>().enabled = false;
            }
            else if (dialogueInt == 10)
            {
                NPCFace9.GetComponent<Image>().enabled = false;
            }else if (dialogueInt == 11)
            {
                NPCFace10.GetComponent<Image>().enabled = false;
            }
            else if (dialogueInt == 12)
            {
                NPCFace10.GetComponent<Image>().enabled = false;
                NPCFace11.GetComponent<Image>().enabled = false;
            }
            else if (dialogueInt == 13)
            {
                NPCFace12.GetComponent<Image>().enabled = false;
            }
            else if (dialogueInt == 14)
            {
                NPCFace13.GetComponent<Image>().enabled = false;
            }
        }
    }

    private void ContinueStory()
    {
        if(currentStory.canContinue)
        {
            dialogueText.text = currentStory.Continue();
            DisplayChoices();
        }
        else if(!currentStory.canContinue)
        {
            ExitDialogueMode();
        }
    }

    private void DisplayChoices()
    {
        List<Ink.Runtime.Choice> currentChoices = currentStory.currentChoices;

        int index = 0;
        foreach (Ink.Runtime.Choice choice in currentChoices)
        {
            //if (index < choices.Length)
           // {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
           // }

            index++;
        }
        for(int i=index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }
        StartCoroutine(SelectFirstChoice());
    }

    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    public void MakeChoice(int choiceIndex)
    {
       Debug.Log("MakeChoice");
        currentStory.ChooseChoiceIndex(choiceIndex);
        ContinueStory();
    }

}
