using UnityEngine;
using System.Collections;

public class MyGui : MonoBehaviour {

	void OnGUI(){
		GUI.Box(new Rect(0, 0, 200, 25), "Score  "+ SpaceInvaderMovement.score + "  Player Lives  " + SpaceInvaderMovement.playerLives); 	
	}
}
