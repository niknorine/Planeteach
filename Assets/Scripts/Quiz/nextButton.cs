using UnityEngine;
using System.Collections;

public class nextButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void OnMouseDown () {

		textControl.questions.RemoveAt (textControl.randQuestion); //removes the question being asked from the list
		textControl.correctAnswer.RemoveAt (textControl.randQuestion); //removes the answer from the list
		text1.firstchoice.RemoveAt (textControl.randQuestion);
		text2.secondchoice.RemoveAt (textControl.randQuestion);
		text3.thirdchoice.RemoveAt (textControl.randQuestion);
		text4.fourthchoice.RemoveAt (textControl.randQuestion);
		textControl.randQuestion = -1;



	}
}
