using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Spaceship : MonoBehaviour {
	// Moving speed
	public float speed;

	// Frequency of shooting
	public float shotDelay;

	// Prefab of bullet
	public GameObject bullet;

	// Create bullet
	public void Shot(Transform origin) {
		Instantiate (bullet, origin.position, origin.rotation);
	}

	// Machine moving
	public void Move (Vector2 direction) {
		GetComponent<Rigidbody2D> ().velocity = direction * speed;
	}

	/*
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	*/
}
