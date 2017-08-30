using UnityEngine;

public class EndTrigger : MonoBehaviour {

    // Creates a reference to the "GameManager" object and script
    public GameManager gameManager;
    public GameObject Score;

    // Runs when the trigger is hit
    void OnTriggerEnter()
    {
		AudioManager.instance.Pause("ThemeMusic");
		AudioManager.instance.Play("CongratsMusic");
        gameManager.CompleteLevel();
        Score.SetActive(false);
    }
}
