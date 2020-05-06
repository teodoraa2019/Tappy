﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Vector2 jumpForce = new Vector2 (0, 300);
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
			GetComponent<Rigidbody2D> ().AddForce (jumpForce);
		}
		Vector2 screenPoints = Camera.main.WorldToScreenPoint (transform.position);

		if (screenPoints.y > Screen.height || screenPoints.y < 0) {
			Die ();
		}
	}

	void OnColliderEnter2D(Collision2D other) {
		Die ();
	}
	void Die() {
		Application.LoadLevel (Application.loadedLevel);
	}
}