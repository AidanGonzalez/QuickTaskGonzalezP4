using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("O")) // Replace "Player" with the appropriate tag of the object that triggers the collider
        {
            Debug.Log("GAME OVER"); // Log "GAME OVER" to the console
        }
    }
}
