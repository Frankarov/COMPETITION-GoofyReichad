using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPatrolNew : MonoBehaviour
{

    public float speed = 2f;
    public Transform leftBoundary;
    public Transform rightBoundary;


    private bool movingRight = true;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private GameObject triggerObject;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (movingRight)
        {
            if (DialogueManager.GetInstance().dialogueIsPlaying)
            {
                return;
            }

            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (transform.position.x >= rightBoundary.position.x)
            {
                Flip();
                movingRight = false;
            }
        }
        else
        {
            if (DialogueManager.GetInstance().dialogueIsPlaying)
            {
                return;
            }

            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= leftBoundary.position.x)
            {
                Flip();
                movingRight = true;
            }
        }
    }

    private void Flip()
    {
        spriteRenderer.flipX = !spriteRenderer.flipX;

    }

}
