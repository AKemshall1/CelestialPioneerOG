using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int score;
	public Text scoreCount;


	// Use this for initialization
	void Start () 
	{
		score = 0;
		SetScoreText ();
	}

	void Update()
	{
		
	}



	public void SetScoreText()
	{
		scoreCount.text = "Score: " + score.ToString ();

	}





}
