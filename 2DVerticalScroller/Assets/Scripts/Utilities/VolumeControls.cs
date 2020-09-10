using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControls : MonoBehaviour {

	public Text music;
	private int count = 1;


	
	// Update is called once per frame
	void Update () 
	{
		if ((Input.GetKeyDown(KeyCode.Space)) && (count % 2 !=0))
		{
			AudioListener.volume = 0.0f;
			count++;
			MusicOff ();
		}

		else if ((Input.GetKeyDown(KeyCode.Space)) && (count % 2 == 0))
		{
			AudioListener.volume = 1.0f;
			count++;
			MusicOn ();
		}


	
	}

	void MusicOn()
	{
		music.text = ("Music: On");
	}

	void MusicOff()
	{
		music.text = ("Music: Off");
	}
}


