using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

    public Movement movement;

    // Update is called only the object collides with another
    void OnCollisionEnter(Collision collisionInfo)
    {
        // If the player comes in contact with an obsticle, turn off movement
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<AudioManager>().Pause("ThemeMusic");
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
 