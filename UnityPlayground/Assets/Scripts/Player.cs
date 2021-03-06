using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float playerSpeed = 30.0f;
	public float turnSpeed = 5.0F;
	public GameObject Projectile;

	public Transform LaunchP1;
	public Transform LaunchP2;
	public Light lightMode;
	private Transform myTransform;
	// Use this for initialization
	void Start () {
		lightMode.enabled = false;
		
		myTransform = transform;
		//Player Spawn Point
		
		//This is where our player will start when the game is played
		
		//player == game object game object == transform
		myTransform.position = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		// player (gameobject) aka transform to move when I press arrow keys
		
		myTransform.Translate(Vector3.up * Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime);
		
		//Turn player
		float h = turnSpeed * Input.GetAxis("Horizontal");
        myTransform.Rotate(0, 0, -h);
		
		//if player goes off the edge of screen it returns on the opposite side
		if (myTransform.position.x > 75){
			myTransform.position = new Vector3(-75, myTransform.position.y, myTransform.position.z);
		}
		else if (myTransform.position.x < -75){
			myTransform.position = new Vector3(75, myTransform.position.y, myTransform.position.z);
		}
		else if (myTransform.position.y > 35){
			myTransform.position = new Vector3(myTransform.position.x, -35, myTransform.position.z);
		}
		else if (myTransform.position.y < -35){
			myTransform.position = new Vector3(myTransform.position.x, 35, myTransform.position.z);
		}
		//press space bar to fire laser
		//if the player presses space bar a laser will shoot
		if (Input.GetKeyDown("space")){
			Instantiate(Projectile, LaunchP1.position, myTransform.rotation);
			Instantiate(Projectile, LaunchP2.position, myTransform.rotation);
		}
		if (Input.GetKeyUp(KeyCode.L)){
			lightMode.enabled = !lightMode.enabled;
		}
		
	}
}
