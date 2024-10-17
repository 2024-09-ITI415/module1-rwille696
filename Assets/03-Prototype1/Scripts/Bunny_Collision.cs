using UnityEngine;

public class Bunny_Collision : MonoBehaviour
{
    // Public score variable to keep track of the score
    public int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cookie"))
        {
            score += 5;
            Debug.Log("Bunny collected a Cookie! Score: " + score);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Poop"))
        {
            score -= 5;
            Debug.Log("Bunny stepped on Poop! Score: " + score);
            Destroy(other.gameObject);
        }
    }
}