using UnityEngine;
using System.Collections;

public class tra : MonoBehaviour {

	public float speed=1f;
	Vector2 ofset;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ofset = new Vector2 (0,Time.time*speed);
		
		GetComponent<Renderer> ().material.mainTextureOffset = ofset;
	}
}
