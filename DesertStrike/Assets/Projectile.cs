using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	float speed = 10;
	float startTime = 0;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(transform.up * speed * Time.deltaTime);
		
		if (Time.time - startTime > 2){
			Destroy(gameObject);
		}
		
		RaycastHit hit;
		if(Physics.Raycast(transform.position,-transform.up * Time.deltaTime, out hit,0.2f)){
			if(hit.transform.name != "Shup"){
			Destroy(gameObject);
			Destroy(hit.transform.gameObject);
			}
		}
	}
	

}
