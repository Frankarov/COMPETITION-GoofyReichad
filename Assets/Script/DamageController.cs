using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageController : MonoBehaviour
{
    #region A
    public Transform playerTransform;
    public GameObject tpTarget;

    [SerializeField] private float damage;
    [SerializeField] private LifeController lifeController;
    private PenentuanDialogue penentuanDialogue;
    private LifeController lifeScript;



    private void Awake()
    {
        penentuanDialogue = FindObjectOfType<PenentuanDialogue>();
        lifeScript = FindObjectOfType<LifeController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            lifeController.LifeGone(damage);
        }
    }

    /*===================================================*/
    /*Gerbang Code */
    /*
                float lifeTemp = lifeScript.currentLife;
                if(lifeTemp > 50)
                {
                    Debug.Log("Bisa Masuk");
                    door1A.SetActive(false);
                }
                else
                {

                    playerTransform.position = tpTarget.transform.position;

                    Debug.Log("Gk bisa masuk");
                } 
    */


    #endregion

    public void ButtonA()
    {


        if (penentuanDialogue != null)
        {
            int dialogueInt = penentuanDialogue.dialogueInt;
            int checkINT = penentuanDialogue.checkpointInt;
            if (dialogueInt == 1)
            {

            }
            else if (dialogueInt == 2)
            {

            }
            else if (dialogueInt == 3)
            {
                damage = 2.5f;
                lifeController.LifeGone(damage);
            }
            else if (dialogueInt == 4)
            {
                damage = 2.5f;
                lifeController.LifeGone(damage);
            }
            else if (dialogueInt == 5) //GATE
            {
                float lifeTemp = lifeScript.currentLife;
                if (lifeTemp > 50)
                {
                    Debug.Log("Bisa Masuk");
                    damage = 15f;
                    lifeController.LifeGone(damage);
                    //door1A.SetActive(false);
                    Vector3 teleportPosition = new Vector3(-43.26f, 20.27f, playerTransform.position.z);
                    playerTransform.position = teleportPosition;

                }
                else
                {

                    playerTransform.position = tpTarget.transform.position;

                    Debug.Log("Gk bisa masuk");
                }

            }else if(dialogueInt == 6)
            {
                damage = 7.5f;
                lifeController.LifeGain(damage);
            }
            else if (dialogueInt == 7)
            {
                damage = 7.5f;
                lifeController.LifeGone(damage);
            }
            else if (dialogueInt == 8)
            {
                damage = 10f;
                lifeController.LifeGone(damage);
            }
            else if (dialogueInt == 9) //GATE
            {
                float lifeTemp = lifeScript.currentLife;
                if (lifeTemp > 40)
                {
                    Debug.Log("Bisa Masuk");
                    damage = 20f;
                    lifeController.LifeGone(damage);
                    //door1A.SetActive(false);
                    Vector3 teleportPosition = new Vector3(-42.35f, 42f, playerTransform.position.z);
                    playerTransform.position = teleportPosition;

                }
                else
                {

                    playerTransform.position = tpTarget.transform.position;

                    Debug.Log("Gk bisa masuk");
                }
            }
            else if (dialogueInt == 50)
            {
                damage = 25f;
                lifeController.LifeGain(damage);
                if(checkINT == 0)
                {
                    Vector3 teleportPosition = new Vector3(-42.83f, -3.04f, playerTransform.position.z);
                    playerTransform.position = teleportPosition;
                    Debug.Log("yabalek");
                }else if(checkINT == 1)
                {
                Vector3 teleportPosition = new Vector3(-43.26f, 20.27f, playerTransform.position.z);
                playerTransform.position = teleportPosition;
                }else if( checkINT == 2)
                {
                 Vector3 teleportPosition = new Vector3(-42.35f, 42f, playerTransform.position.z);
                 playerTransform.position = teleportPosition;
                }


            }
            else if (dialogueInt == 10)
            {
                damage = 5f;
                lifeController.LifeGone(damage);
            }
            else if (dialogueInt == 11)
            {

            }
            else if (dialogueInt == 12)
            {

            }
            else if (dialogueInt == 13)
            {
                SceneManager.LoadScene(0);
            }
            else if (dialogueInt == 14)
            {
                damage = 50f;
                lifeController.LifeGone(damage);
            }

        }



        }
    /*===================================================================================================================================*/
    public void ButtonB()
        {

            if (penentuanDialogue != null)
            {
                int dialogueInt = penentuanDialogue.dialogueInt;
            int checkINT = penentuanDialogue.checkpointInt;
            if (dialogueInt == 1)
                {

                }
                else if (dialogueInt == 2)
                {


                }
                else if (dialogueInt == 3)
                {
                    damage = 2.5f;
                    lifeController.LifeGone(damage);
                }
                else if (dialogueInt == 4)
                {

                }
                else if (dialogueInt == 5)
                {
                }
            else if (dialogueInt == 6)
            {

            }
            else if (dialogueInt == 7)
            {

            }
            else if (dialogueInt == 8)
            {

            }
            else if (dialogueInt == 9)
            {
                damage = 5f;
                lifeController.LifeGone(damage);
            }
            else if (dialogueInt == 50)
            {
                damage = 25f;
                lifeController.LifeGain(damage);
                if (checkINT == 0)
                {
                    Vector3 teleportPosition = new Vector3(-42.83f, -3.04f, playerTransform.position.z);
                    playerTransform.position = teleportPosition;
                    Debug.Log("yabalek");
                }
                else if (checkINT == 1)
                {
                    Vector3 teleportPosition = new Vector3(-43.26f, 20.27f, playerTransform.position.z);
                    playerTransform.position = teleportPosition;
                }
                else if (checkINT == 2)
                {
                    Vector3 teleportPosition = new Vector3(-42.35f, 42f, playerTransform.position.z);
                    playerTransform.position = teleportPosition;
                }
            }
            else if (dialogueInt == 10)
            {
                damage = 7.5f;
                lifeController.LifeGain(damage);
            }
            else if (dialogueInt == 11)
            {

            }
            else if (dialogueInt == 12)
            {
                damage = 15f;
                lifeController.LifeGone(damage);
            }
            else if (dialogueInt == 13)
            {
                SceneManager.LoadScene(0);
            }
            else if (dialogueInt == 14)
            {
                Vector3 teleportPosition = new Vector3(-42.4f, 95.09f, playerTransform.position.z);
                playerTransform.position = teleportPosition;
            }
        }

            /*===================================================================================================================================*/
        }
        public void ButtonC()
        {
            if (penentuanDialogue != null)
            {
            int dialogueInt = penentuanDialogue.dialogueInt;
            int checkINT = penentuanDialogue.checkpointInt;
            if (dialogueInt == 1)
                {

            }
                else if (dialogueInt == 2)
                {
                damage = 2.5f;
                lifeController.LifeGone(damage);
                }
                else if (dialogueInt == 3)
                {
                    damage = 10f;
                    lifeController.LifeGone(damage);
                }
                else if (dialogueInt == 4)
                {
                damage = 2.5f;
                lifeController.LifeGone(damage);
            }
                else if (dialogueInt == 5)
                {
                }
            else if (dialogueInt == 6)
            {
                damage = 5f;
                lifeController.LifeGone(damage);
            }
            else if (dialogueInt == 7)
            {

            }
            else if (dialogueInt == 8)
            {

            }
            else if (dialogueInt == 9)
            {
                Vector3 teleportPosition = new Vector3(-42.35f, 42f, playerTransform.position.z);
                playerTransform.position = teleportPosition;
            }
            else if (dialogueInt == 50)
            {
                damage = 25f;
                lifeController.LifeGain(damage);
                if (checkINT == 0)
                {
                    Vector3 teleportPosition = new Vector3(-42.83f, -3.04f, playerTransform.position.z);
                    playerTransform.position = teleportPosition;
                    Debug.Log("yabalek");
                }
                else if (checkINT == 1)
                {
                    Vector3 teleportPosition = new Vector3(-43.26f, 20.27f, playerTransform.position.z);
                    playerTransform.position = teleportPosition;
                }
                else if (checkINT == 2)
                {
                    Vector3 teleportPosition = new Vector3(-42.35f, 42f, playerTransform.position.z);
                    playerTransform.position = teleportPosition;
                }
            }
            else if (dialogueInt == 10)
            {
                damage = 5f;
                lifeController.LifeGone(damage);
            }
            else if (dialogueInt == 11)
            {

            }
            else if (dialogueInt == 12)
            {
                damage = 5f;
                lifeController.LifeGain(damage);
            }
            else if (dialogueInt == 13)
            {
                SceneManager.LoadScene(0);
            }
            else if (dialogueInt == 14)
            {
                damage = 50f;
                lifeController.LifeGone(damage);
            }
        }

        }
    
}