using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float moveSpeed = 12f; // Speed of movement

    void Update()
    {
        // Get input from the arrow keys or WASD
        float horizontalInput = Input.GetAxis("Horizontal"); // A/D or Left/Right Arrow
        float verticalInput = Input.GetAxis("Vertical"); // W/S or Up/Down Arrow

        // Create a movement vector
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;

        // Move the object
        transform.Translate(movement);
    }
}
    
