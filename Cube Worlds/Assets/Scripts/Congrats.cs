using UnityEngine;

public class Congrats : MonoBehaviour {

	void Awake()
    {
        AudioManager.instance.Stop("ThemeMusic");
        AudioManager.instance.Play("CongratsMusic");
        //FindObjectOfType<AudioManager>().Stop("ThemeMusic");
        //FindObjectOfType<AudioManager>().Play("CongratsMusic");
    }
}
