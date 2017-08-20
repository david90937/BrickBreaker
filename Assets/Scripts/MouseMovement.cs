﻿using UnityEngine;
using System.Collections;

public class MouseMovement : MonoBehaviour {

	private GameObject ball; 
	public bool Autoplay = false;

	// Use this for initialization
	void Start () {
		ball = GameObject.Find("Ball");

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!Autoplay) {
			MoveWithMouse ();
		} else {
			AutoPlay ();

		}
	}

		
	void MoveWithMouse () {
		Vector3 paddlePos = new Vector3 (0f, this.transform.position.y, 0f); 
		float mousePosinBlocks = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp (mousePosinBlocks, 0.5f, 15.5f);
		this.transform.position = paddlePos; 
	}
	void AutoPlay ()
	{
		Vector3 paddlePos = new Vector3 (0f, this.transform.position.y, 0f); 
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp (ballPos.x, 0.5f, 15.5f);
		this.transform.position = paddlePos; 
		} 

}
