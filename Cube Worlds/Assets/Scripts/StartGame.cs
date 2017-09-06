using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {


    public void LoadGame()
	{
		// SIMPLE = Load next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		LevelNumber otherScript = GetComponent<LevelNumber>();
		otherScript.add1();
    }

}

