using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel1 : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Return)) 
		{
			SceneManager.LoadScene ("Level1");
		}

		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			SceneManager.LoadScene ("Options");
		}

		if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			SceneManager.LoadScene ("Credits");
		}


	}
}
