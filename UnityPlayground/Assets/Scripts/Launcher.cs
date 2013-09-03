using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

	// Use this for initialization
	void OnDrawGizmos(){
		Gizmos.DrawSphere(transform.position, 0.5f);
	}
}
