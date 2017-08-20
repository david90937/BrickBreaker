using UnityEngine;
using System.Collections;

public class Level2Mouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePos = new Vector3(0f, this.transform.position.y, 0f); 
		float mousePosinBlocks = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp(mousePosinBlocks, 0f, 15.5f);
		this.transform.position = paddlePos; 

	}
}
