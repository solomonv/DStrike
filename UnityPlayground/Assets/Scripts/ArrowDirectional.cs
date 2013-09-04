using UnityEngine;
using System.Collections;

public class ArrowDirectional : MonoBehaviour {
	
	public float playerSpeed = 50.0f;
	public GameObject Projectile;
	public Transform LaunchP1;
	public Transform LaunchP2;
	public GameObject Ship;
	private Transform myTransform;
	
	// Use this for initialization
	void Start () {
		myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		myTransform.Translate(Vector3.up * Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime);
		myTransform.Translate(Vector3.right * Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime);
		
		int xAxis = Mathf.RoundToInt(Input.GetAxisRaw("Horizontal"));
		int yAxis = Mathf.RoundToInt(Input.GetAxisRaw("Vertical"));
		
		if (Input.GetKeyDown("space")){
			Instantiate(Projectile, LaunchP1.position, Ship.transform.rotation);
			Instantiate(Projectile, LaunchP2.position, Ship.transform.rotation);
		}
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
		if (Input.GetKeyDown(KeyCode.LeftArrow)){
			Ship.transform.eulerAngles = new Vector3(0,0,90);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow)){
			Ship.transform.eulerAngles = new Vector3(0,0,270);
		}
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			Ship.transform.eulerAngles = new Vector3(0,0,0);
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)){
			Ship.transform.eulerAngles = new Vector3(0,0,180);
		}		
	}
}
