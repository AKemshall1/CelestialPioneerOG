using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Formation : MonoBehaviour {

	//Circle movement based on https://answers.unity.com/questions/1164022/move-a-2d-item-in-a-circle-around-a-fixed-point.html (last accessed 28/11/2017)



	public float RotationSpeed = 2f;
	public float Radius = 1f;
	private Vector2 Centre;
	private float Angle;


	// Use this for initialization
	void Start () {

		Centre = this.transform.position;


	}
	
	// Update is called once per frame
	void Update () {

		Angle += RotationSpeed * Time.deltaTime;

		var offset = new Vector2 (Mathf.Sin (Angle), Mathf.Cos (Angle)) * Radius;
		transform.position = Centre + offset;
	}
}
