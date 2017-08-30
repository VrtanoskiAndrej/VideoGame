using UnityEngine;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour {

    // How many lives a player has
    int Lives = 3;

    public int EndScene;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;



    // Creating a new function for LooseLife
    public void LooseLife()
    {
        Debug.Log(Lives);
        Lives = Lives - 1;
    }

    public void CheckLives()
    {
        if(Lives == 2)
        {
            Heart1.SetActive(false);
        }

        if (Lives == 1)
        {
            Heart2.SetActive(false);
        }

        if (Lives == 0)
        {
            Heart3.SetActive(false);
            SceneManager.LoadScene(EndScene);
        }
    }

}
