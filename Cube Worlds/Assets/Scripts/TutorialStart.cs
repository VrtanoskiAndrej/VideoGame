using UnityEngine;

public class TutorialStart : MonoBehaviour {

	public static TutorialStart instanceTutorial;

	private void Awake()
	{
		// if the singleton hasn't been initialized yet
		if (instanceTutorial != null && instanceTutorial != this)
		{
			Destroy(this.gameObject);
			return;//Avoid doing anything else
		}

		instanceTutorial = this;
		DontDestroyOnLoad( this.gameObject );
	}
}
