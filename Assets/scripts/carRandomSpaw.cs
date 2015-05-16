using UnityEngine;
using System.Collections;

public class carRandomSpaw : MonoBehaviour {

	public GameObject EnimycarObject;
	public float delayTime=2f;
	float timer;

	void Start () {
	
		timer = delayTime;
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if(timer<=0){
			Vector3 carPos = new Vector3 (Random.Range(-1.8f,1.8f),transform.position.y,transform.position.z);
			Instantiate (EnimycarObject,carPos,transform.rotation);
			timer = delayTime;


		}


	
	}
}
