﻿using UnityEngine;
using System.Collections;

public class Intro3 : MonoBehaviour {
	
	bool playScene;
	
	// Use this for initialization
	void Start () {
		
		playScene = true;
		StartCoroutine (WaitScene ());
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) {
			Application.LoadLevel("One");
		}

		if (!playScene) {
			Application.LoadLevel("One");
		}
	}
	
	IEnumerator WaitScene(){
		
		yield return new WaitForSeconds (10);
		playScene = false;
	}
}