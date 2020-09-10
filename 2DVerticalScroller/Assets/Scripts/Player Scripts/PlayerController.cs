using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
	public float Speed;

	public Text healthCount, lifeCount, winText, damageUpText, speedUpText, fireRateUpText;
	public int damage;
	public GameObject Player;
	public AudioClip PlayerExplosion;
	public AudioClip PlayerDamage;
	public AudioClip PickUp;

	private int lives, health;
	private Rigidbody2D rb;
	private AudioSource PlayerExplosionSource;
	private AudioSource PlayerDamageSource;
	private AudioSource PickUpSource;
	private float volume = 1.0f;

	public Transform Respawn;




	void Awake()
	{
		PlayerExplosionSource = GetComponent<AudioSource> ();
		PlayerExplosionSource.ignoreListenerVolume = true;
		PlayerDamageSource = GetComponent<AudioSource> ();
		PlayerDamageSource.ignoreListenerVolume = true;
		PickUpSource = GetComponent<AudioSource> ();
		PickUpSource.ignoreListenerVolume = true;
	}



	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
		
		health = 100;
		SetHealthText ();
		lives = 3;
		SetLifeText ();
		damage = 5;

	

	}

	void Update ()
	{
		if (GameObject.Find ("PlayerPrefab").GetComponent<PlayerShooter> ().delay <= 0) 
		{
			GameObject.Find ("PlayerPrefab").GetComponent<PlayerShooter> ().delay = 0.2f;
		}

		if (Speed >= 7)
		{
			Speed = 6;
		}
	}









	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxisRaw ("Horizontal"); 
		float moveVertical = Input.GetAxisRaw ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb.velocity = movement * Speed;
			
	}
	


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("enemyAbullet")) {
			health -= 10;
			SetHealthText ();
			PlayerDamageSource.PlayOneShot (PlayerDamage, volume);
		}
	
		if (other.gameObject.CompareTag ("enemyBbullet")) {
			health -= 20;
			SetHealthText ();
			PlayerDamageSource.PlayOneShot (PlayerDamage, volume);
		}
	
		if (other.gameObject.CompareTag ("enemyCbullet")) {
			health -= 30;
			SetHealthText ();
			PlayerDamageSource.PlayOneShot (PlayerDamage, volume);
		}
			
		if (other.gameObject.CompareTag ("EnemyA"))
		{
			health -= 10;
			SetHealthText ();
			PlayerDamageSource.PlayOneShot (PlayerDamage, volume);
		}

		if (other.gameObject.CompareTag ("EnemyB"))
		{
			health -= 20;
			SetHealthText ();
			PlayerDamageSource.PlayOneShot (PlayerDamage, volume);
		}

		if (other.gameObject.CompareTag ("EnemyC"))
		{
			health -= 30;
			SetHealthText ();
			PlayerDamageSource.PlayOneShot (PlayerDamage, volume);
		}

		if (other.gameObject.CompareTag ("EnemyD"))
		{
			health -= 60;
			SetHealthText ();
			PlayerDamageSource.PlayOneShot (PlayerDamage, volume);
		}

		if (health <= 0)
		{
			damage =5;
			damageUpText.color = new Color (0, 0, 0);

			GameObject.Find("PlayerPrefab").GetComponent<PlayerShooter>().delay =1f;
			fireRateUpText.color = new Color (0, 0, 0);

			Speed = 3;
			speedUpText.color = new Color (0, 0, 0);

			health = 100;
			lives = lives - 1;

			this.transform.position = Respawn.transform.position;

			PlayerExplosionSource.PlayOneShot (PlayerExplosion, volume);

			SetHealthText ();
			SetLifeText ();


		}


		if (lives == 0)
		{
			SceneManager.LoadScene ("Game Over");
		}


		if (other.gameObject.CompareTag ("HealthUp"))
		{
			PickUpSource.PlayOneShot (PickUp, volume);
			health = 100;
			SetHealthText ();
			Destroy (other.gameObject);
		}

		if (other.gameObject.CompareTag ("LifeUp"))
		{
			PickUpSource.PlayOneShot (PickUp, volume);
			lives += 1;
			SetLifeText ();
			Destroy (other.gameObject);
		}

		if (other.gameObject.CompareTag ("DamageUp"))
		{
			PickUpSource.PlayOneShot (PickUp, volume);
			damage += 10;
			damageUpText.color = new Color (255, 255, 255);

			Destroy (other.gameObject);
		}

		if (other.gameObject.CompareTag ("MovementUp")) 
		{
			PickUpSource.PlayOneShot (PickUp, volume);
			Speed += 2;
			speedUpText.color = new Color (255, 255, 255);
			Destroy (other.gameObject);
		}

		if (other.gameObject.CompareTag ("ShotSpeedUp"))
		{
			PickUpSource.PlayOneShot (PickUp, volume);
			GameObject.Find("PlayerPrefab").GetComponent<PlayerShooter>().delay -=0.5f;
			fireRateUpText.color = new Color (255, 255, 255);
			Destroy (other.gameObject);
		}
			

	}




		
	public void SetHealthText()
	{
		healthCount.text = "Health: " + health.ToString ();
	}

	public void SetLifeText()
	{
		lifeCount.text = "Lives: " + lives.ToString ();
	}


}




