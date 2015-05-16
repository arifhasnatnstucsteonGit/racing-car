using UnityEngine;
using System.Collections;

public class carControl : MonoBehaviour {

	public float carSpeed=10f;
	Vector3 position;
	public float maxPos=1.8f;

	void Start () {
		position = transform.position;
	


	}
	
	// Update is called once per frame
	void Update () {
	

		position.x+=Input.GetAxis("Horizontal")*carSpeed*Time.deltaTime;
		position.y += Input.GetAxis ("Vertical")*carSpeed*Time.deltaTime;

	   
		position.x = Mathf.Clamp (position.x,-1.8f,1.8f);
		position.y = Mathf.Clamp (position.y,-4.6f,4.3f);
		transform.position = position;
	}

	void OnCollisionEnter2D(Collision2D col){

		if(col.gameObject.tag=="enimyCarTaxi"){
			Destroy(gameObject);

		}


	}

}
