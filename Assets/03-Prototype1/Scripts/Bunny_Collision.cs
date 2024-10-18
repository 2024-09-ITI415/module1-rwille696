//using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;
public class Bunny_Collision : MonoBehaviour
{
    // Public score variable to keep track of the score
    public int score = 0;
void OnCollisionEnter(Collision collision)
    {
        // Example collision detection logic
        if (collision.gameObject.CompareTag("Cookie"))
        {
            score += 5;  // Increase score by 5 for a cookie
            Debug.Log("Collided with Cookie. Score: " + score);  // Debug log to verify the score is changing
        }
        else if (collision.gameObject.CompareTag("Poop"))
        {
            score -= 5;  // Decrease score by 5 for poop
            Debug.Log("Collided with Poop. Score: " + score);  // Debug log to verify the score is changing
        }

        // Find and update the ScoreDisplay
        FindObjectOfType<ScoreDisplay>().UpdateScoreDisplay();  // Call UpdateScoreDisplay() after collision
    }
}