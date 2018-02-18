﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public Rigidbody2D rb;
	public float ballForce;

	bool gameStarted = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyUp(KeyCode.Space) && !gameStarted) {
			gameStarted = true;
			transform.SetParent(null);
			rb.isKinematic = false;
			rb.AddForce(new Vector2(ballForce, ballForce));
		}

	}
}
