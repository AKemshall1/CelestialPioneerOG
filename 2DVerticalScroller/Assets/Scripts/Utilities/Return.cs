﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Backspace)) 
		{
			SceneManager.LoadScene ("Title Screen");
		}
	}
}
