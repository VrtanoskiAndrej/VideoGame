using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelNumber : MonoBehaviour {

	public Text levelNumberText;
	public int y;

	// Update is called once per frame
	void Awake()
	{	
		int y = SceneManager.GetActiveScene ().buildIndex;
		y = y - 1;
		levelNumberText.text = y.ToString();
	}

	public void add1()
	{
		y = y + 1;
		levelNumberText.text = y.ToString();
	}
}
