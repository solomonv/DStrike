using UnityEngine;
using System.Collections;

public class ArrowDirectional : MonoBehaviour {
	
	public float playerSpeed = 50.0f;
	public GameObject Projectile;
	public Transform LaunchP1;
	public Transform LaunchP2;
	public GameObject Ship;
	public GameObject mainCamera;
	public float fireRate = 0.1f;
	private Transform myTransform;
	private float nextFire = 0.0f;
	
	// Use this for initialization
	void Start () {
		myTransform = transform;
		mainCamera = (GameObject) GameObject.FindWithTag ("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		myTransform.Translate(Vector3.up * Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime);
		myTransform.Translate(Vector3.right * Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime);
	
		//Center camera on Ship
		mainCamera.transform.position = new Vector3(Ship.transform.position.x, Ship.transform.position.y,-75);
		
		
		//Fires blasters
		if (Input.GetKey("space") && Time.time > nextFire){
			nextFire = Time.time + fireRate;
			
			Instantiate(Projectile, LaunchP1.position, Ship.transform.rotation);
			Instantiate(Projectile, LaunchP2.position, Ship.transform.rotation);
		}
		
		//Checks the movement path and sets it to variables
		int xAxis = Mathf.RoundToInt(Input.GetAxisRaw("Horizontal"));
		int yAxis = Mathf.RoundToInt(Input.GetAxisRaw("Vertical"));
		
		// Ship faces the way it is moving
		if (xAxis == 1 && yAxis == -1){
			Ship.transform.eulerAngles = new Vector3(0,0,225);
		}
		if (xAxis == 1 && yAxis == 1){
			Ship.transform.eulerAngles = new Vector3(0,0,315);
		}
		if (xAxis == -1 && yAxis == -1){
			Ship.transform.eulerAngles = new Vector3(0,0,135);
		}
		if (xAxis == -1 && yAxis == 1){
			Ship.transform.eulerAngles = new Vector3(0,0,45);
		}
		if (xAxis == 1 && yAxis == 0){
			Ship.transform.eulerAngles = new Vector3(0,0,270);
		}
		if (xAxis == -1 && yAxis == 0){
			Ship.transform.eulerAngles = new Vector3(0,0,90);
		}
		if (xAxis == 0 && yAxis == -1){
			Ship.transform.eulerAngles = new Vector3(0,0,180);
		}
		if (xAxis == 0 && yAxis == 1){
			Ship.transform.eulerAngles = new Vector3(0,0,0);
		}	
	}
}
