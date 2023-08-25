using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the space bar is held down
        if (Input.GetKey(KeyCode.Space))
        {
            // Calculate the new position
            Vector3 newPosition = transform.position - Vector3.up * moveSpeed * Time.deltaTime;

            // Move the object
            transform.position = newPosition;
        }
    }
}
