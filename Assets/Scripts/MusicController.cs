using UnityEngine;
using System.Collections;

public class MusicController : MonoBehaviour {
	static MusicController happyday = null; 

	void Awake ()
	{
		if (happyday != null) {
			Destroy (gameObject);
			print ("Duplicate MusicPlayer destroyed!");
		}
		else {
			happyday = this;
			GameObject.DontDestroyOnLoad (gameObject);}
	}
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		
	}
}
