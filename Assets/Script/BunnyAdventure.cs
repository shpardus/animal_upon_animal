using UnityEngine;
using System.Collections;

public class BunnyAdventure : MonoBehaviour {

	string currentStatus = "Intro";

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello!");
	}
	
	// Update is called once per frame
	void Update () {
		string textBuffer = "Bunny Adventure!";

		if (currentStatus == "Intro") {
			textBuffer += "\nYou find a friendly bunny.";
			textBuffer += "\nWhat do you do?";
			textBuffer += "\nPress [P] to pet it";
			textBuffer += "\nPress [F] to feed it";
			if ( Input.GetKeyDown (KeyCode.P) ) {
				currentStatus = "Pet";
			}
			else if ( Input.GetKeyDown (KeyCode.F) ) {
				currentStatus = "Feed";
			}
		}
		else if (currentStatus == "Pet") {
			textBuffer += "\nWhere should you pet it?";
			textBuffer += "\nPress [H] for head";
			textBuffer += "\nPress [B] for back";
			if ( Input.GetKeyDown (KeyCode.H) ) {
				currentStatus = "Hungry";
			}
			else if ( Input.GetKeyDown (KeyCode.B) ) {
				currentStatus = "Hungry";
			}
		}
		else if (currentStatus == "Feed") {
			textBuffer += "\nWhat should you feed it?";
			textBuffer += "\nPress [C] for carrot";
			textBuffer += "\nPress [L] for lettuce";
			if (Input.GetKeyDown (KeyCode.C) ) {
				currentStatus = "Full";
			}
			else if ( Input.GetKeyDown (KeyCode.L) ) {
				currentStatus = "Full";
			}
		}
		else if (currentStatus == "Hungry") {
			textBuffer += "\nThe bunny loved the rub.";
			textBuffer += "\nNow its looking hungry.";
			textBuffer += "\nWhat should you feed it?";
			textBuffer += "\nPress [C] for carrot";
			textBuffer += "\nPress [L] for lettuce";
			if ( Input.GetKeyDown (KeyCode.C) ) {
				currentStatus = "Happy";
			}
			else if ( Input.GetKeyDown (KeyCode.L) ) {
				currentStatus = "Happy";
			}
		}
		else if (currentStatus == "Full") {
			textBuffer += "\nThe bunny loved the food.";
			textBuffer += "\nNow its full and looks at you for a rub.";
			textBuffer += "\nWhere should you pet it?";
			textBuffer += "\nPress [H] for head";
			textBuffer += "\nPress [B] for back";
			if ( Input.GetKeyDown (KeyCode.H) ) {
				currentStatus = "Happy";
			}
			else if ( Input.GetKeyDown (KeyCode.B) ) {
				currentStatus = "Happy";
			}
		}
		else if (currentStatus == "Happy") {
			textBuffer += "\nThe bunny is happy.";
			textBuffer += "\nHow does it express its joy?";
			textBuffer += "\nPress [J] for jump";
			textBuffer += "\nPress [R] for roll";
			if ( Input.GetKeyDown (KeyCode.J) ) {
				currentStatus = "Friends";
			}
			else if ( Input.GetKeyDown (KeyCode.R) ) {
				currentStatus = "Friends";
			}
		}
		else if (currentStatus == "Friends") {
			textBuffer += "\nThe bunny sees its friends.";
			textBuffer += "\nWhat does it do?";
			textBuffer += "\nPress [S] to stay";
			textBuffer += "\nPress [F] to go to its friends";
			if (Input.GetKeyDown (KeyCode.S) ) {
				currentStatus = "Stay";
			}
			else if (Input.GetKeyDown (KeyCode.F) ) {
				currentStatus = "GoToFriends";
			}
		}
		else if (currentStatus == "Stay") {
			textBuffer += "\nThe bunny stayed for a second,";
			textBuffer += "\nthen went back to its friends.";
			textBuffer += "\nThe end of Bunny Adventure.";
		}
		else if (currentStatus == "GoToFriends") {
			textBuffer += "\nThe bunny jumped over to his friends.";
			textBuffer += "\nThe end of Bunny Adventure.";
		}
		GetComponent<TextMesh> ().text = textBuffer;
	}
}
