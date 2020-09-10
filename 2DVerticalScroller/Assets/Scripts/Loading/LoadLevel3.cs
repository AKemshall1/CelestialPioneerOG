using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel3 : MonoBehaviour {

	public int EnemyCountLevel2;


	void Start()
	{
		EnemyCountLevel2 = 10;
	}

	// Update is called once per frame
	void Update () 
	{
		if (EnemyCountLevel2 == 0)
		{
			SceneManager.LoadScene ("Level2to3");
		}
	}
}
