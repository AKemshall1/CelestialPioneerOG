using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadWinScreen: MonoBehaviour {


	public int EnemyCountLevel3;


	void Start()
	{
		EnemyCountLevel3 = 11;
	}

	void Update()
	{

		if (EnemyCountLevel3 == 0) 
		{
			SceneManager.LoadScene ("Win");
		}


	}

}
