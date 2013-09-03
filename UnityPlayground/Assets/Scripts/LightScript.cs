using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour {
	public Light lightsource;
	
	void Update(){
	}

	void OnEnabled () {
		lightsource.enabled = true;
	}
	

	void OnDisabled () {
		lightsource.enabled= false;
	}
}
