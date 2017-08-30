using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    // Creates a new boolean variable
    bool gameHasEnded = false;

    public float restartTime = 2f;

    // Creates a reference to the "Complete Level" text
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        // Sets the animation active
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        // If statment allows the function Restart to only run once
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            // Invoke is like a timer, it waits 2 seconds before it runs the "Restart" function
            Invoke("Restart", restartTime);   
        } 
    }

    // Creates a new function called "Restart"
    void Restart()
    {
        // Gets the name of the active scene and loads it from the beginning
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
