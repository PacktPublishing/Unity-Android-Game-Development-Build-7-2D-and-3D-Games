using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

	public Button[] buttons;
	public Text scoreText;
	public int score = 0;
	float scoreUpdateValue = 0.2f;
	float scoreUpdater;
	public bool gameOver;

	void Start () {
		gameOver = false;
		scoreUpdater = scoreUpdateValue;
		scoreText.text = "Score: ";
		
	}
	
	void Update(){
		
		//int val = (int)Time.time * 5;
		if (!gameOver) {
			updateScore ();
		}
	}

	public void updateScore(){
		scoreUpdater -= Time.deltaTime;
		
		if (scoreUpdater <= 0) {
			score ++;
			scoreUpdater = scoreUpdateValue;
		}
		
		scoreText.text = "Score:" + score;
	}

	public void Play(){

		Application.LoadLevel ("level1");


		Debug.Log ("play");
	}

	public void Menu(){
		Application.LoadLevel ("menu");
		Debug.Log ("play");
	}

	public void Exit(){
		Application.Quit ();
	}

	public void Pause(){
		if (Time.timeScale == 1) {

			Time.timeScale = 0;

		} else if (Time.timeScale == 0) {

			Time.timeScale = 1;
		}
	}

	public void EnableButtons(){
		Debug.Log ("buttons");
		foreach (Button button in buttons) {
			button.gameObject.SetActive(true);
			Debug.Log ("enabled");
		}
	}



}



// Use this for initialization

