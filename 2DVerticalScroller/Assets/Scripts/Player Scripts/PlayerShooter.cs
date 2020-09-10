using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour 

{
	public GameObject BulletPlayer;
	public float delay = 0.3333f;	//shots per second
	public AudioClip ShootSound;

	private float volume = 1.0f;
	private AudioSource ShootSoundSource;
	private float timestamp;

	void Awake()
	{
		
		ShootSoundSource = GetComponent<AudioSource> ();
		ShootSoundSource.ignoreListenerVolume = true;
	}




	// Update is called once per frame
	void Update () 
	{
		if (Time.time >= timestamp && (Input.GetButton("shoot")))
		{
			GameObject x = Instantiate(BulletPlayer);
			Rigidbody2D rbNew = x.GetComponent<Rigidbody2D>();
			Rigidbody2D rbThis = GetComponent<Rigidbody2D>();

			rbNew.velocity = new Vector2(0,1);
			rbNew.position = rbThis.position;
			x.transform.position = gameObject.transform.position;

			timestamp = Time.time + delay;


			ShootSoundSource.PlayOneShot (ShootSound, volume);

		}
	}

}







