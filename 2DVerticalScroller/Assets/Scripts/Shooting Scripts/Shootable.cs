using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shootable : MonoBehaviour 
{



	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("bullet")) 
		{
			Destroy (other.gameObject);
			Destroy (gameObject);
		}


	}








}
