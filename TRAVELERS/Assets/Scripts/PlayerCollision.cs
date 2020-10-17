using UnityEngine;

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
                //FindObjectOfType<AudioManager>().Stop("PlayerDeath");
                FindObjectOfType<AudioManager>().Play("PlayerDeath");
                FindObjectOfType<AudioManager>().StopPlaying("BackgroundMusic");
                alreadyPlayed = true;
            }
        }
    }
}
