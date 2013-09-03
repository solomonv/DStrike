using UnityEngine;
using System.Collections;

public class SpaceInvaderMovement : MonoBehaviour {
	
	private Transform myTransform;
	public static int playerLives = 5;
	public float playerSpeed = 30.0f;
	public static int score = 0;
	float timer = 0f;
	//variable reference to prefab(reusable gameobject)
	public GameObject Projectile;
	
	// Use this for initialization
	void Start () {
		
		myTransform = transform;
		//Player Spawn Point
		
		//This is where our player will start when the game is played
		
		//player == game object game object == transform
		myTransform.position = new Vector3(0, -26, 0);
	}
	
	// Update is called once per frame
	void Update () {
		// player (gameobject) aka transform to move when I press arrow keys
		
		myTransform.Translate(Vector3.right * Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime);
		
		
		//if player goes off the edge of screen it returns on the opposite side
		if (myTransform.position.x > 56){
			myTransform.position = new Vector3(56, myTransform.position.y, myTransform.position.z);
		}
		else if (myTransform.position.x < -56){
			myTransform.position = new Vector3(-56, myTransform.position.y, myTransform.position.z);
		}
		
		if (Input.GetKeyDown("space")){
			Vector3 position = new Vector3(myTransform.position.x, myTransform.position.y + 3, myTransform.position.z);
			Instantiate(Projectile, position, myTransform.rotation);			
		}
		
		if (Time.time - timer > 1){
			renderer.enabled = true;
		}
		
		print ("Lives:  " + playerLives + "  Score:  " + score + "   Current Time:   " + Time.time + "  timer time  " + timer);
	}	
	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.CompareTag("Enemy")){
			playerLives --;
			renderer.enabled = false;
			timer = Time.time;
			if (playerLives < 1){
				Destroy(this.gameObject);
			}
		}
	}
}