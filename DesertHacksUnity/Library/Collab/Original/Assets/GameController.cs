using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public double difficulty;
	public GameController(){
		//we can use the gamecontroller object to save state, monobehaviors are not serializable so we must use a normal C# object
		difficulty = 1.5;
	}
	//function that takes any key press and prints it

	void Update() {
		if (Input.GetKey ("l"))
			Debug.Log ("l is pressed");
		if (Input.GetKey ("down"))
			Debug.Log ("Down pressed");
	}

}