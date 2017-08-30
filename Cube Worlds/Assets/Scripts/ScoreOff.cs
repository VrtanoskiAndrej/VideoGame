using UnityEngine;


public class ScoreOff : MonoBehaviour {

    public GameObject Score;
    public GameObject CompleteTutorialUI;
    public GameObject Player;

    public static ScoreOff instance;

 /*   void Awake()
    {

        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != instance)
        {
            Destroy(this.gameObject);
        }
    

        DontDestroyOnLoad(this.gameObject); 

    } 
    */
        public void TotalSystemOff()
    {
        Score.SetActive(false);
        Player.GetComponent<Movement>().enabled = false;
    }

    public void TotalSystemOn()
    {
        Score.SetActive(true);
        Player.GetComponent<Movement>().enabled = true;
    }

    public void StartTutorial()
    {
        CompleteTutorialUI.SetActive(false);
    }
}

