using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour {

	//Adapted from: https://answers.unity.com/questions/754633/how-to-move-an-object-left-and-righ-looping.html, last accessed 05/12/2017.


	public float distance = 1.5f;
	public float speed = 1.0f;
	private Vector2 startPosition;

	// Use this for initialization
	void Start ()
	{
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector2 v = startPosition;
		v.x += distance * Mathf.Sin (Time.time * speed);
		transform.position = v;
	}
}
