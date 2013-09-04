using UnityEngine;
using System.Collections;

public class RotateShip : MonoBehaviour {
	private Transform  myTransform;
	// Use this for initialization
	void Start () {
		myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftArrow)){
			myTransform.eulerAngles = new Vector3(0,0,90);
		}
	
	}
}
