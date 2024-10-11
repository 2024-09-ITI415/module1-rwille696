using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSideToSideFollow : MonoBehaviour
{
    public Transform bunny;          // Reference to the Bunny object
    public float followSpeed = 3f;   // Speed at which the object follows the Bunny
    public float sideMovementSpeed = 20f; // Speed of side-to-side movement

    public GameObject Ltarget;

    public GameObject Rtarget;
    public float sideMovementRange = 20f; // Range of side-to-side movement
    private float randomOffset;      // Offset for random side movement

    void Start()
    {
        // Initialize the random offset for side movement
        randomOffset = Random.Range(-sideMovementRange, sideMovementRange);
    }

    void Update()
    {
        if (bunny != null)
        {
            // Follow the Bunny in the Z (forward) direction
            Vector3 targetPosition = new Vector3(bunny.position.x, transform.position.y, bunny.position.z);
           // transform.position = Vector3.MoveTowards(transform.position, targetPosition, followSpeed * Time.deltaTime);

            // Add random side-to-side movement
            float sideMovement = Mathf.PingPong(Time.time * sideMovementSpeed, sideMovementRange * 5) - sideMovementRange;
            Vector3 newPosition = new Vector3(bunny.position.x + sideMovement + randomOffset, transform.position.y, transform.position.z);
            
            // Update the position of the object
            transform.position = new Vector3(newPosition.x, transform.position.y, transform.position.z);
            //transform.position = targetPosition + newPosition;
        }
    }
}
