using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
	//Basis for delay on shooting from https://answers.unity.com/questions/665352/shot-delay-between-button-press-c.html, last accessed 20/11/2017

	public GameObject enemyBulletprefab;
	public float delay = 0.3333f;	//3 shots per second
	public AudioClip EnemyShoot;

	private AudioSource EnemyShootSource;
	private float timestamp;
	private float volume = 1.0f;

	void Awake ()
	{
		EnemyShootSource = GetComponent<AudioSource> ();
		EnemyShootSource.ignoreListenerVolume = true;
	

	}


	// Update is called once per frame
	void Update () 
	{
		if (Time.time >= timestamp) 
		{
			GameObject x = Instantiate (enemyBulletprefab);
			Rigidbody2D rbNew = x.GetComponent<Rigidbody2D> ();
			Rigidbody2D rbThis = GetComponent<Rigidbody2D> ();

			rbNew.velocity = new Vector2 (0, -1);
			rbNew.position = rbThis.position;
			x.transform.position = gameObject.transform.position; 

			timestamp = Time.time + delay;
			EnemyShootSource.PlayOneShot (EnemyShoot, volume);
		}
	}
}
