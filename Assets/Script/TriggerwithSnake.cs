using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerwithSnake : MonoBehaviour
{
    public Animator snakeAnimator; // Reference to the Snake's Animator component

    private void Start()
    {
        // Get the Animator component from the Snake GameObject
        // Assuming this script is attached to the Player GameObject
        snakeAnimator = GameObject.FindGameObjectWithTag("SNAKE")?.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SNAKE"))
        {
            // Trigger the animation on the Snake GameObject
            if (snakeAnimator != null)
            {
                snakeAnimator.SetTrigger("SNAKEATTACK"); // Replace "TriggerAnimation" with the name of the animation parameter
            }
        }
    }




}
