using UnityEngine;

public class PreventPassThrough : MonoBehaviour
{
    private Rigidbody rb;

    // Initialize the Rigidbody component
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component missing from game object.");
        }
        else
        {
            // Set Rigidbody parameters to prevent passing through
            rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
            rb.interpolation = RigidbodyInterpolation.Interpolate; // Smooths movement
        }
    }

    // This method is called when this object collides with another object
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + " has collided with " + collision.gameObject.name);
        // Prevent objects from moving through each other by applying additional logic or force here if needed
    }
}