using UnityEngine;

public class Movement : MonoBehaviour {

    //  
    public Rigidbody rb;

    // Creates a new float variable
    public float PlayerForce = 2000f;
    public float SideMovement = 200f;

	// Update is called once per frame 
	void FixedUpdate ()
    {
        // Adds a constant force "PlayerForce" in the Z direction every frame
        rb.AddForce(0, 0, PlayerForce * Time.deltaTime); 

        // Checks for when the "d" or "a" keys are pressed to add a force in that direction

        if(Input.GetKey("d"))
        {
            rb.AddForce(SideMovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideMovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();  
        }

        else if (rb.position.y < -1f)
        {
            AudioManager.instance.Pause("ThemeMusic");
            AudioManager.instance.Play("Falling");
        }
    }
}
