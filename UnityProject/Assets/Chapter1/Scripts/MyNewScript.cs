﻿using UnityEngine;
using System.Collections;

public class MyNewScript : MonoBehaviour {

	public string PlayerName = "";
	public int PlayerHealth = 100;
	public Vector3 Position = Vector3.zero;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerHealth == 100) {
			Debug.Log("Player has full health");
		}
	}
}