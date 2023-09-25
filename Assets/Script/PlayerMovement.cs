using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private AudioSource audioSource;
    public AudioClip walkClip;
    public AudioClip jumpClip;



    public float speed;
    public float jumpForce;
    private Animator animator;

    public float KBForce;
    public float KBCounter;
    public float KBTotalTime;

    public bool KnockFromRight;

    //component
    private Rigidbody2D rigidBody2D;
    private SpriteRenderer spriteRenderer;

    public bool isGrounded;

    private void Start()
    {



        rigidBody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        isGrounded = true;
        audioSource = GetComponent<AudioSource>();
    }

    private void PlayWalk()
    {
        animator.SetBool("GoWalk",true);
    }

    private void StopWalk()
    {
        animator.SetBool("GoWalk", false);
    }

    private void PlayJump()
    {
        Debug.Log("Jumped!");
        animator.SetBool("GoJump",true);
    }

    private void StopJump()
    {
        animator.SetBool("GoJump", false);
    }

    private void SpriteFlip(float InputHorizontal)
    {
        if(InputHorizontal < 0)
        {
            spriteRenderer.flipX = true;

        }else if(InputHorizontal > 0)
        {
            spriteRenderer.flipX = false;

        }
    }

    private void Update()
    {

        if(DialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }

        float InputHorizontal = Input.GetAxis("Horizontal");
        
        if(InputHorizontal == 0)
        {
            StopWalk();

        }
        else
        {

            PlayWalk();
            
            PlaySFX(walkClip);
        }

        if (KBCounter <= 0)
        {
        transform.Translate(new Vector3(InputHorizontal * speed * Time.deltaTime, 0f, 0f));

        }
        else
        {
            if (KnockFromRight == true)
            {
                transform.Translate(new Vector3(-KBForce, KBForce, 0f));
            }
            if (KnockFromRight == false)
            {
                transform.Translate(new Vector3(KBForce, KBForce, 0f));
            }

            KBCounter -= Time.deltaTime;

        }


        SpriteFlip(InputHorizontal);

        if(Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rigidBody2D.velocity.y) < 0.001f && isGrounded)
        {
            rigidBody2D.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

            StopWalk();

        }

        if(isGrounded)
        {
            StopJump();
        }
        else
        {
            PlaySFX(jumpClip);
            PlayJump();
        }

    }

   private void PlaySFX(AudioClip SFXCLIP)
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = SFXCLIP;
            audioSource.Play();
        }
    }

}
