using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
   // public Text scoreText;

    public TMP_Text scoreText;
    public Bunny_Collision bunnyCollision;

    void Start()
    {
        // Initialize the score display when the game starts
        UpdateScoreDisplay();
    }

    public void UpdateScoreDisplay()
    {
        // Update the score text based on the current score
        scoreText.text = "Score: " + bunnyCollision.score.ToString();
//delete
        if (bunnyCollision != null && scoreText != null)
    {
        scoreText.text = "Score: " + bunnyCollision.score.ToString();
        Debug.Log("Score updated: " + bunnyCollision.score); // Check if the score updates
    }
    else
    {
        Debug.LogError("Cannot update score display: Either bunnyCollision or scoreText is null.");
    } //delete
    }

    // Call this function whenever the score changes, instead of every frame

// delete below if problem
    
}