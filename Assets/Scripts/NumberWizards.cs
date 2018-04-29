using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

	int max;
	int min;
	int quess;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame ()
	{
		max = 1000;
		min = 1;
		quess = 500;

		print ("==========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print  ("Is the number giher or lower than " + quess +"?");
		print  ("Up = higher, down = lower, return = equal");

		max = max + 1;

	}

	void NextGuess ()
	{
		quess = (max + min) /2;
		print ("Higher or lower than" + quess);
		print  ("Up = higher, down = lower, return = equal");
	}


	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//print("Up arrow pressed");
			min = quess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//print("Down arrow pressed");
			max = quess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print("I won!");
			StartGame();
		}
	}
}
