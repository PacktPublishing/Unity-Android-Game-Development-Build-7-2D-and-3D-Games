using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UiManager : MonoBehaviour {

	int score = 0;
	public Text scoreText;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void IncrementScore(){
		score++;
		scoreText.text = "Score: " + score;
	}
}
