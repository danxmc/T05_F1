using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public Transform player;
    public PlayerMovement movement;

    // This function runs when we hit another object.
    // We get information about the collision in the "collision" variable.
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has a tag named "Obstacle"
        if (collision.collider.tag == "Obstacle")
        {
            // Disbale the players movement.
            movement.enabled = false;
            ScoreKeeper.score += (int)player.position.z;
            GameObject.Find("LevelManager").GetComponent<LevelManager>().LoadLevel("Questions");
        }
    }
}
