﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	Spaceship spaceship;

	// Use this for initialization
	IEnumerator Start () {
		spaceship = GetComponent<Spaceship> ();

		spaceship.Move (transform.up * -1);

		while (true) {
			for (int i = 0; i < transform.childCount; i++) {
				Transform shotPosition = transform.GetChild (i);

				spaceship.Shot (shotPosition);
			}

			yield return new WaitForSeconds (spaceship.shotDelay);
		}
	}
	
	// Update is called once per frame
	/*
	void Update () {
	
	}
	*/
}
