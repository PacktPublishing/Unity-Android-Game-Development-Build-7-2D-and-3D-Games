using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class manager : MonoBehaviour {

	public Text scoreText;
	public int score = 0;
	float scoreUpdater = 0.2f;

	// Use this for initialization
	void Start () {
		scoreText.text = "Score: ";

	}

	void Update(){

		//int val = (int)Time.time * 5;
		scoreUpdater -= Time.deltaTime;

		if (scoreUpdater <= 0) {
			score ++;
			scoreUpdater = 0.2f;
		}

		scoreText.text = "Score:" + score;
	}

}
