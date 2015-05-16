using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public float speed;
	Vector2 ofset;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		ofset = new Vector2 (0,Time.time*speed);

		GetComponent<Renderer> ().material.mainTextureOffset = ofset;
	
	
	}
}
