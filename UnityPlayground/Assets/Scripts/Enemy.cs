using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public float minSpeed = 20.0f;
	public float maxSpeed = 40.0f;
	int x, y, z;
	public float currentSpeed;
	Transform myTransform;
	
	// Use this for initialization
	void Start () {
		myTransform = transform;
		x = Random.Range(-50, 50);
		y = 29;
		z = 0;
		
		currentSpeed = Random.Range(minSpeed, maxSpeed);		
		myTransform.position = new Vector3(x, y, z);		
	}
	
	// Update is called once per frame
	void Update () {
		myTransform.Translate(Vector3.down * currentSpeed * Time.deltaTime);
		
		x = Random.Range(-50, 50);
		
		if (myTransform.position.y < -30){
			currentSpeed = Random.Range (minSpeed, maxSpeed);
			myTransform.position = new Vector3(x, y, z);
		}
	}
	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.CompareTag("Projectile")){
			Destroy(this.gameObject);
			print ("Object Hit");
			SpaceInvaderMovement.score += 50;
		}
		if (collider.gameObject.CompareTag("Player")){
			Destroy(this.gameObject);
		}
	}

			
	
}
