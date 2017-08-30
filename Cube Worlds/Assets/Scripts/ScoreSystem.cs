using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour {

    // Creates references to the Player and the Text
    public Transform player;
    public Text scoreText;

	// Update is called once per frame
	void Update ()
    {
        // The text becomes the players position on the Z axi
        scoreText.text = player.position.z.ToString("0" );	
	}
}
