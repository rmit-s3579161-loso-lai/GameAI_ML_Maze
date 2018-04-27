﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This controller sets variables on every game object that are outside the scope of the State Controller
/// </summary>

public class ZombieController : MonoBehaviour {
	public GameController gameController;
	private Animator animator;
	GameObject[] waypoints;
	int currentWPIndex;

	void Awake () {
		animator = GetComponent<Animator> ();
		animator.SetBool ("run", true); // Always running
		waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
		currentWPIndex = 0;
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player")) {
			gameController.EndGame (false);
		}
	}
}
