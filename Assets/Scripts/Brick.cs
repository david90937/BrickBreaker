using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public int MaxHits;
	public int TimesHit; 
	public AudioClip Machete;
	public Sprite [] HitSprites;
	public static int BrickCount;
	private bool isBreakable;
	private LevelManager levelManager;
	public GameObject Smoke;

	// Use this for initialization
	void Start () {
		TimesHit = 0;
		isBreakable = (this.tag == "Breakable");
		BrickCount = GameObject.FindGameObjectsWithTag ("Breakable").Length;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}

	// Update is called once per frame
	void Update ()
	{
		
	}
	public void OnCollisionEnter2D (Collision2D col)
	{
		AudioSource.PlayClipAtPoint(Machete, transform.position);
		if (isBreakable) {
		HandleHits(); }
	}
	void HandleHits ()
	{
		TimesHit = TimesHit + 1;
		MaxHits = MaxHits - 1; 
		if (MaxHits < 1) {
			Destroy (gameObject);
			BrickCount = GameObject.FindGameObjectsWithTag ("Breakable").Length -1;
			print(BrickCount);
			CreateSmoke();
			if (BrickCount <= 0) {
				print("I ran");
				levelManager.LoadNextLevel();
			}

		} else { 
			LoadSprite (); 
		}
	}
	void CreateSmoke ()
	{
		GameObject smokePuff = Instantiate (Smoke, gameObject.transform.position, Quaternion.identity) as GameObject;
		smokePuff.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
	}

	 void LoadSprite ()
	{  
		int SpriteIndex = TimesHit - 1;
		if (HitSprites[SpriteIndex]) {
			this.GetComponent<SpriteRenderer>().sprite = HitSprites[SpriteIndex]; }
	}

		


	
}
