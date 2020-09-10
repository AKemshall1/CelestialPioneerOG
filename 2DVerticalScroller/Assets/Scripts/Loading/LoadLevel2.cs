using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel2 : MonoBehaviour {

	public int EnemyCountLevel1;

	void Start()
	{
		EnemyCountLevel1 = 8;
	}

	// Update is called once per frame
	void Update () 
	{
		if (EnemyCountLevel1 == 0)
		{
			SceneManager.LoadScene ("Level1to2");
		}
	}
}
