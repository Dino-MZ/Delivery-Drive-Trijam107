using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool gameWon = false;

    public AudioSource DeathSFX;
    public AudioSource WinSFX;

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            gameObject.GetComponent<PlayerMovement>().canMove = false;

            DeathSFX.Play();

            gameOver = true;

            Debug.Log("Player Hit A Car!");
        }
        else if (collision.collider.CompareTag("Target"))
        {
            gameObject.GetComponent<PlayerMovement>().canMove = false;

            gameWon = true;

            WinSFX.Play();

            Debug.Log("Player Reached The Target");
        }
    }
}
