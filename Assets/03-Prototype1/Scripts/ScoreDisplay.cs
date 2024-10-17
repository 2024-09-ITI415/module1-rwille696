using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class ScoreDisplay : MonoBehaviour{
    public TMP_Text scoreText;  // TextMeshPro field to display score
    public Bunny_Collision bunnyCollision;  // Reference to the Bunny_Collision script

    void Start()
    {
        if (bunnyCollision != null && scoreText != null)
        {
            // Initialize the score display when the game starts
            UpdateScoreDisplay();
        }
        else
        {
            Debug.LogError("bunnyCollision or scoreText is not assigned in the Inspector.");
        }
    }

    public void UpdateScoreDisplay()
    {
        // Ensure bunnyCollision and scoreText are not null before updating
        if (bunnyCollision != null && scoreText != null)
        {
            scoreText.text = "Score: " + bunnyCollision.score.ToString();  // Update the score display
            Debug.Log("Score updated: " + bunnyCollision.score);  // For debugging, to check if the score is updating
        }
        else
        {
            Debug.LogError("Cannot update score display: Either bunnyCollision or scoreText is null.");
        }
    }
}
