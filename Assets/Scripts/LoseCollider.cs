using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

public void OnTriggerEnter2D (Collider2D trigger){
	print ("Trigger activated ");
	Application.LoadLevel ("Lose"); }

public void OnCollisionEnter2D (Collision2D collision)
	{
		Application.LoadLevel ("Lose");
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col) {
		Destroy(this.gameObject);
		Print("Hit a bogey");
	}
}
