using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOff : MonoBehaviour {

	public GameObject movement;
	public GameObject score;

	public void TotalSystemOff()
	{
		score.SetActive (false);
		movement.SetActive(false);
	}

	public void TotalSystemOn()
	{
		score.SetActive (true);
		movement.SetActive(true);
	}
}
		