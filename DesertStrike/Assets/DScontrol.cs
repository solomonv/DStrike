using UnityEngine;
using System.Collections;

public class DScontrol : MonoBehaviour {
	float speed = 10;
	
	public GameObject projectilePrefab;
	
	// Update is called once per frame
	void Update () {
		float xaxis = Input.GetAxis("Horizontal");		
		transform.Translate(new Vector3(xaxis * Time.deltaTime * speed, 0, 0));
		if (Input.GetKeyDown(KeyCode.Space)){
			Instantiate(projectilePrefab,transform.position,Quaternion.identity);
		}
	
	}
}
