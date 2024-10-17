using UnityEngine;
using UnityEngine.UI; 

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;
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
    }

    // Call this function whenever the score changes, instead of every frame
}