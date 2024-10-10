using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieDisappear : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of the rotation

    void Update()
    {
        // Rotate the Cookie around the Y axis (upward axis) over time
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object that collided is the Bunny
        if (other.gameObject.CompareTag("Bunny"))
        {
            // Destroy the Cookie GameObject
            Destroy(gameObject);
        }
    }
}
