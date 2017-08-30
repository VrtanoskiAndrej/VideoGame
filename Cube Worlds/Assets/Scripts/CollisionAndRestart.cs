using UnityEngine;

public class CollisionAndRestart : MonoBehaviour
{
    public Movement movement;
    public GameObject Player;
    public Transform PlayerTrans;

    public void Update()
    {
       Debug.Log(new Vector3(PlayerTrans.position.x, PlayerTrans.position.y, PlayerTrans.position.z));
    }
    // Update is called only the object collides with another
    void OnCollisionEnter(Collision collisionInfo)
    {
        // If the player comes in contact with an obsticle, turn off movement
        if (collisionInfo.collider.tag == "Obstacle")
        { 
            movement.enabled = false;
            Invoke("PlayerPositionReset", 2);
        }

    }

    public void PlayerPositionReset()
    {
        transform.Translate(new Vector3(PlayerTrans.position.x, 0 , PlayerTrans.position.z));
    }

    
}
