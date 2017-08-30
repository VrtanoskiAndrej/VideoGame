using UnityEngine;

public class MovementOff : MonoBehaviour {

    public GameObject Score;
    public GameObject CompleteScene;
    public GameObject Player;

    public void TotalSystemOff()
    { 
        Player.GetComponent<Movement>().enabled = false;
    }

    public void TotalSystemOn()
    {
        Player.GetComponent<Movement>().enabled = true;
        Score.SetActive(true);
    }

    public void StartTutorial()
    {
        CompleteScene.SetActive(false);
    }
}
