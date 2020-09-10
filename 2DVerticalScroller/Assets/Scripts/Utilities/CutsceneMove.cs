using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneMove : MonoBehaviour {

	public GameObject target;
	public float speed;

	void Update () 
	{
		transform.position = Vector2.MoveTowards(transform.position,target.transform.position, speed*Time.deltaTime);
	}
}
