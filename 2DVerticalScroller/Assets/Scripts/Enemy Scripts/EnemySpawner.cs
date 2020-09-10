using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {


	public Transform Spawner;
	public GameObject Enemy;
	private int count = 0;

	// Use this for initialization
	void Start ()

	{
		while (count <= 6) 
		{
			
			GameObject x = Instantiate (Enemy);
			Rigidbody2D rbNew = x.GetComponent<Rigidbody2D> ();
			Rigidbody2D rbThis = GetComponent<Rigidbody2D> ();

			rbNew.velocity = new Vector2 (0, -1);
			rbNew.position = rbThis.position;
			x.transform.position = gameObject.transform.position; 
			count++;
		}
			
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
