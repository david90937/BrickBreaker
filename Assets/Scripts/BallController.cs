using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	public MouseMovement Paddle;
	private Vector3 PaddletoBallVector;
	private bool hasStarted = false;
	public GameObject Ball;


	// Use this for initialization
	void Start () {
		
		PaddletoBallVector = this.transform.position - Paddle.transform.position;
		print(PaddletoBallVector);
		Ball = this.gameObject;
	}

	 void OnCollisionEnter2D (Collision2D col)
	{
		Vector2 tweak = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));
		if (hasStarted) {
			Ball.GetComponent<AudioSource> ().Play ();
			Ball.GetComponent<Rigidbody2D>().velocity += tweak;
			print(tweak);

		}
	}

	// Update is called once per frame
	void Update ()
	{
		if (!hasStarted) {
			this.transform.position = Paddle.transform.position + PaddletoBallVector; }

			if (Input.GetMouseButtonDown (0)) {
				print ("Mouse clicked");
				hasStarted = true;
				this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, 10f);  
		} 
	}



}
