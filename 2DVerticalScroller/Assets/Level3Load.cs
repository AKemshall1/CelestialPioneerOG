using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Load : MonoBehaviour {


	private float TransitionTime = 3f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		TransitionTime -= Time.deltaTime;

		if (TransitionTime <= 0)
		{
			SceneManager.LoadScene ("Level 3");
		}
	}
}