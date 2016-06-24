using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Moving speed
	//public float speed = 5;

	// PlayerBullet Prefab
	//public GameObject bullet;

	Spaceship spaceship;

	// Use this for initialization
	IEnumerator Start () {
		// Get componenet of Spaceship
		spaceship = GetComponent<Spaceship> ();

		while (true) {
			// Create bullet
			spaceship.Shot (transform);

			// Wait
			yield return new WaitForSeconds(spaceship.shotDelay);

			/*
			// Create bullet
			Instantiate (bullet, transform.position, transform.rotation);

			// Wait 0.05s
			yield return new WaitForSeconds (0.05f);
			*/
		}
	}
	
	// Update is called once per frame
	void Update () {
		// Right and Left
		float x = Input.GetAxisRaw ("Horizontal");

		// Up and Down
		float y = Input.GetAxisRaw("Vertical");

		// Moving direction
		Vector2 direction = new Vector2(x, y).normalized;

		// Moving speed
		//GetComponent<Rigidbody2D>().velocity = direction * speed;

		spaceship.Move (direction);
	}
}
