using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {
	private Transform myTransform;
	
	public float speed = 55.0f;
	public GameObject Player;
	public float timer;

	// Use this for initialization
	void Start () {
		myTransform = transform;
		//myTransform.x = Player.transform.position.x;
		//myTransform.y = Player.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		myTransform.Translate(Vector3.up * speed * Time.deltaTime);
		timer += 1.0f * Time.deltaTime;
		if (timer > 2){
			DestroyObject(gameObject);
		}
		
	}
	
	/*void OnColliderEnter(Collider collider){
		if (collider.gameObject.CompareTag("Enemy")){
			Destroy(gameObject);
			print ("hit");
			SpaceInvaderMovement.score += 50;
		}
	}*/
}
