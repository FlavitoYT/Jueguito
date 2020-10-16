﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public bool alreadyPlayed = false;

    private void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

            if (!alreadyPlayed)
            {
                FindObjectOfType<AudioManager>().Play("PlayerDeath");
                alreadyPlayed = true;
            }
        }
    }
}
