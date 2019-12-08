using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 8;

	public Text text;
	void Start(){
		StartGame ();
	}
	// Use this for initialization
	public void StartGame(){
		max = 1000;
		min = 1;
		ChangeGuess();

	}
	// Update is called once per frame

	public void GuessHigher(){
		min = guess;
		ChangeGuess ();
	}

	public void GuessLower(){
		max = guess;
		ChangeGuess ();
	}
	public void ChangeGuess(){
        //Use the line under to have a random number in the range
        //guess = Random.Range(min, max + 1);
        guess = (max + min) / 2;
	   	text.text = guess.ToString() + "?";
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {
            SceneManager.LoadScene("Win");
		}
	}
	public void LoadLevel(){
        SceneManager.LoadScene("Lose");
	} 

}
