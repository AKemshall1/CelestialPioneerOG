using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCredits : MonoBehaviour {

	private float WinScreenTime = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		WinScreenTime -= Time.deltaTime;

		if (WinScreenTime <= 0)
		{
			SceneManager.LoadScene ("Credits");
		}
	}
}
