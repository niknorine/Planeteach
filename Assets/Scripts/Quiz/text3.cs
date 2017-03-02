using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class text3 : MonoBehaviour {

	public static List<string> thirdchoice = new List<string> {"incorret", "Steve", "The Sun", "2", "What?"}; // Look at TEXTCONTROL script to see how to use this LIST

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {

		if (textControl.randQuestion > -1) { // everytime a random number gets generated
			GetComponent<TextMesh> ().text = thirdchoice [textControl.randQuestion]; // this will output an answer thats conected to a question
		}
	
	}

	void OnMouseDown() {

		textControl.selectedAnswer = gameObject.name; // will make the SELECTEDANSWER varible set to the gameObject's name. IT'S IMPORTNAT THAT THE GAMEOBJECT'S NAME IS THE SAME AS IN THE LIST IN THE OTHER SCRIPT.
		textControl.choiceSelected = true; // sets the value to true


	}
}
