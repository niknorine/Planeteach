using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class textControl : MonoBehaviour {

	public GameObject[] qAndAText; // an array for the question and answers so we can hide them when quetion is answered

	public GameObject nextQuestion;

	public static int listLength;

	public GameObject endScreen;

	public float score;

	public float correctAnswers;

	public float wrongAnswers;

	public Transform corAnswer;

	public Transform wroAnswer;

	public static List<string> questions = new List<string> {"the answer to this question is the first choice", "Which one of these is a planet?", "What is the capital of England", "What is 1+1?", "Cash me outside"}; // This is where all the questions should be. questions will be picked at random.

	public static List<string> correctAnswer = new List<string> {"1", "2", "1", "3", "4"}; // this corisponds to the list ABOVE. these are the NAMES of the GAMEOBJECTS which contain the correct answer. FOR EXAMPLE the first question in the ABOVE list, the answer is in the GAMEOBJECT in the first list.
	/// Questions/Answers that need to be added
	/// If any of the QUESTIONS need to be changed or added, do so in the QUESTIONS list in this script. Remember the placement of the question and see if there is a number in the CORRECTANSWER list in the same placement.
	/// FOR EXAMPLE if you changed the question in the 2ND position in the list then the number that is in the 2nd position in the CORRECTANSWER list will be which GAMEOBJECT the answer will be. So in this case "2" You would want to type the correct answer in the script attached to the game object called 2 and put the answer in the 2nd position in the list.
	/// Questions/Answers that need to be changed

	public static string selectedAnswer; // this variable is for the answer that the user selected. A value for this is set in other scripts.

	public static bool choiceSelected = false; // has the user seleced an answer?

	public static int randQuestion = -1; // Variable for a random number which will be used to randomize the question order. It's equal to -1 for the IF STATMENT in the update, otherwise it would constantly genrate random numbers.

	public Transform resultOBJ; // this is so that we can modify the text of the GAMEOBJECT that is dragged into here.


	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {

		if (randQuestion == -1) { // will generate a random number ONLY when RANQUESTION = -1
			listLength = questions.Count;
			randQuestion = Random.Range (0, listLength); // creates a random number
			resultOBJ.GetComponent<TextMesh> ().text = " "; //every time a new question is selected it clears the value of resultOBJ
			gameObject.GetComponent<MeshRenderer> ().enabled = true; //unhides the question
			foreach (GameObject gameobject in qAndAText) {
			gameobject.gameObject.SetActive (true); // unhides the answers
			}
			nextQuestion.gameObject.SetActive(false); // hides the Next button

				if (listLength == 0) {
				gameover();
				}
			
				
		
			}



	
		if (randQuestion > -1){ // once a random number is generated and a question is present
		GetComponent<TextMesh> ().text = questions [randQuestion]; // the value from the list will be outputted to the text field in the game
			}


		if (choiceSelected == true) { // once the user chooses an answer this will run



			gameObject.GetComponent<MeshRenderer> ().enabled = false; //hides the question until NEXT is pressed
			nextQuestion.gameObject.SetActive(true); // unhides the NEXT button

			foreach (GameObject gameobject in qAndAText){
			gameobject.gameObject.SetActive (false); //hides all the answers until NEXT is pressed
				}

			choiceSelected = false; // we set it false so that there can be another question after

			if (correctAnswer [randQuestion] == selectedAnswer) { // THIS IS WHAT HAPPENS WHEN THE CORRECT ANSWER HAS BEEN SELECTED
				resultOBJ.GetComponent<TextMesh>().text = "Correct"; // if its true
				correctAnswers += 1;



			}

			if (correctAnswer [randQuestion] != selectedAnswer) { // THIS IS WHAT HAPPENS WHEN THE WRONG ASNWER HAS BEEN SELECTED
				resultOBJ.GetComponent<TextMesh>().text = "Wrong answer"; //if answer incorrect
				wrongAnswers += 1;

			}


				
		}
	
	}


	public void gameover() {

		endScreen.gameObject.SetActive (true);
		foreach (GameObject gameobject in qAndAText){
			gameobject.gameObject.SetActive (false); //hides all the answers until NEXT is pressed
		}
		gameObject.GetComponent<MeshRenderer> ().enabled = false; 
		questions.RemoveAt (randQuestion);
		nextQuestion.gameObject.SetActive(false);
		corAnswer.GetComponent<TextMesh> ().text = correctAnswers.ToString();
		wroAnswer.GetComponent<TextMesh> ().text = wrongAnswers.ToString();




	}

}
