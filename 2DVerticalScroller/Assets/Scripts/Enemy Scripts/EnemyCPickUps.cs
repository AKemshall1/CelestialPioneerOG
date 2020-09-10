using UnityEngine;
using System.Collections;

public class EnemyCPickUps : MonoBehaviour
{
	public GameObject HealthPrefab;
	public GameObject DamagePrefab;
	public GameObject LivesPrefab;
	public GameObject FirePrefab;
	public GameObject SpeedPrefab;

	public float DropRate = 50; // Percentage that drop occurs from enemy

	void Spawn ()
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

