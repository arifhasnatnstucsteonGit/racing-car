using UnityEngine;
using System.Collections;

public class enimyCarControl : MonoBehaviour {

	public float enimyspeed=5.0f;
	void Start () {
	
	}
	

	void Update () {

		transform.Translate (new Vector3(0,-1,0)*enimyspeed*Time.deltaTime);
	
	}
}
