using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    // Creates a new reference to the position of the player
    public Transform player; 
    // Creates a new vector called offset
    public Vector3 offset;

	// Update is called once per frame
	void Update ()
    {
        // The camera will follow the player and be offsetted by a little bit
        transform.position = player.position + offset;
    }
}
