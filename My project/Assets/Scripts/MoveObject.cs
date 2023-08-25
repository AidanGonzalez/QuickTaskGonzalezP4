using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float  moveSpeed = 5.0f;

    private void Update()
    {
        // Check if the space bar is held down
        if (Input.GetKey(KeyCode.Space))
        {
            // Calculate the new position
            Vector3 newPosition = transform.position + Vector3.right * moveSpeed * Time.deltaTime;

            // Move the object
            transform.position = newPosition;
        }

    }
}