﻿using UnityEngine;
using System.Collections;

public class KillBoxRainy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Move the killbox up
		Vector3 temp = transform.position;
		temp.y += 0.05f;
		transform.position = temp;
	}

	void OnTriggerEnter2D(Collider2D obj){

		if (obj.name == "Player") {
			PlayerScript player = obj.gameObject.GetComponent<PlayerScript>();
			//Kill the player
			player.DamagePlayer(player.maxHealth);
			StopEnemiesAndCamera();

		}
	}

	void StopEnemiesAndCamera(){

		//Stop camera
		GameObject camera = GameObject.Find("Main Camera");
		CameraRainy cr = camera.gameObject.GetComponent<CameraRainy>();
		cr.enabled = false;

		//Stop every enemy at the bottom.
		GameObject[] arr = GameObject.FindGameObjectsWithTag("Enemy");
		for(int i = 0; i < arr.Length; i++){
			cr = arr[i].gameObject.GetComponent<CameraRainy>();
			cr.enabled = false;
		}
	}
}
