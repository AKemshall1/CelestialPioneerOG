using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour 
{

	public int health;
	public int EnemyCHealth =  20;

	public GameObject HealthPrefab;
	public GameObject DamagePrefab;
	public GameObject LivesPrefab;
	public GameObject FirePrefab;
	public GameObject SpeedPrefab;

	public float DropRate; // Percentage that drop occurs from enemy




		

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("bullet")) 
		{
			Destroy (other.gameObject);
			health -= GameObject.Find ("PlayerPrefab").GetComponent<PlayerController> ().damage;
		}

		if ((health <= 0) && gameObject.CompareTag("EnemyA"))
		{
			
			Destroy (gameObject);
			GameObject.Find("PlayerPrefab").GetComponent<Score>().score +=50;
			GameObject.Find ("PlayerPrefab").GetComponent<Score> ().SetScoreText ();

			if (SceneManager.GetActiveScene().name == "Level1") {
				GameObject.FindWithTag ("Level2Loading").GetComponent<LoadLevel2> ().EnemyCountLevel1--;
			}

			if (SceneManager.GetActiveScene().name == "Level 2") {
				GameObject.FindWithTag ("Level3Loading").GetComponent<LoadLevel3> ().EnemyCountLevel2--;
			}

			if (SceneManager.GetActiveScene().name == "Level 3") {
				GameObject.FindWithTag ("WinLoading").GetComponent<LoadWinScreen> ().EnemyCountLevel3--;
			}

			SpawnPickUp ();


		
		}


		if ((health <= 0) && gameObject.CompareTag("EnemyB"))
		{

			Destroy (gameObject);
			GameObject.Find("PlayerPrefab").GetComponent<Score>().score +=100;
			GameObject.Find ("PlayerPrefab").GetComponent<Score> ().SetScoreText ();

			if (SceneManager.GetActiveScene().name == "Level 2") {
				GameObject.FindWithTag ("Level3Loading").GetComponent<LoadLevel3> ().EnemyCountLevel2--;
			}
			if (SceneManager.GetActiveScene().name == "Level 3") {
				GameObject.FindWithTag ("WinLoading").GetComponent<LoadWinScreen> ().EnemyCountLevel3--;
			}


		
			SpawnPickUp();

		}

		if ((EnemyCHealth <= 0) && gameObject.CompareTag("EnemyC"))
		{
			Destroy (gameObject);
			GameObject.Find ("PlayerPrefab").GetComponent<Score> ().score += 200;
			GameObject.Find ("PlayePrefab").GetComponent<Score> ().SetScoreText ();
			if (SceneManager.GetActiveScene().name == "Level 2") {
				GameObject.FindWithTag ("Level3Loading").GetComponent<LoadLevel3> ().EnemyCountLevel2--;
			}
			if (SceneManager.GetActiveScene().name == "Level 3") {
				GameObject.FindWithTag ("WinLoading").GetComponent<LoadWinScreen> ().EnemyCountLevel3--;
			}

		}

		if ((health <= 0) && gameObject.CompareTag("EnemyD"))
		{
			
			Destroy (gameObject);
			GameObject.Find("PlayerPrefab").GetComponent<Score>().score +=400;
			GameObject.Find ("PlayerPrefab").GetComponent<Score> ().SetScoreText ();
			if (SceneManager.GetActiveScene().name == "Level 3") {
				GameObject.FindWithTag ("WinLoading").GetComponent<LoadWinScreen> ().EnemyCountLevel3--;
			}


			SpawnPickUp ();
		}
	}


	void SpawnPickUp ()
	{

		float rand = Random.Range (0f, 100f); // Percentage
		if (rand <= DropRate && rand < 20)
		{
			GameObject x = Instantiate (HealthPrefab);
			Rigidbody2D rbNew = x.GetComponent<Rigidbody2D> ();
			Rigidbody2D rbThis = GetComponent<Rigidbody2D> ();
			rbNew.position = rbThis.position;
			x.transform.position = gameObject.transform.position;
		}

		if (rand <= DropRate && rand > 20 && rand < 40)
		{
			GameObject x = Instantiate (DamagePrefab);
			Rigidbody2D rbNew = x.GetComponent<Rigidbody2D> ();
			Rigidbody2D rbThis = GetComponent<Rigidbody2D> ();
			rbNew.position = rbThis.position;
			x.transform.position = gameObject.transform.position;
		}

		if (rand <= DropRate && rand > 40 && rand < 60)
		{
			GameObject x = Instantiate (LivesPrefab);
			Rigidbody2D rbNew = x.GetComponent<Rigidbody2D> ();
			Rigidbody2D rbThis = GetComponent<Rigidbody2D> ();
			rbNew.position = rbThis.position;
			x.transform.position = gameObject.transform.position;
		}	

		if (rand <= DropRate && rand > 60 && rand < 80)
		{
			GameObject x = Instantiate (FirePrefab);
			Rigidbody2D rbNew = x.GetComponent<Rigidbody2D> ();
			Rigidbody2D rbThis = GetComponent<Rigidbody2D> ();
			rbNew.position = rbThis.position;
			x.transform.position = gameObject.transform.position;
		}

		if (rand <= DropRate && rand > 80 && rand <= 100)
		{
			GameObject x = Instantiate (SpeedPrefab);
			Rigidbody2D rbNew = x.GetComponent<Rigidbody2D> ();
			Rigidbody2D rbThis = GetComponent<Rigidbody2D> ();
			rbNew.position = rbThis.position;
			x.transform.position = gameObject.transform.position;
		}
	}





}
