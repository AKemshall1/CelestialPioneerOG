using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {


	public GameObject player;
	public float speed = 0.5f;


	void Start () {
		player = GameObject.Find("PlayerPrefab");
	}

	void Update () {
		transform.position = Vector2.MoveTowards(transform.position,player.transform.position, speed*Time.deltaTime);
	}
}