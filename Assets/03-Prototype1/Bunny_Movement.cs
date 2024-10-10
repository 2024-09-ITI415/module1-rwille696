using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BunnyMovement : MonoBehaviour
{
    public float speed = 5f; // Speed of movement

    void Update()
    {
        // Get input from the left and right arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");

        // Create a movement vector
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * speed * Time.deltaTime;

        // Move the Bunny object
        transform.Translate(movement);
    }
}
