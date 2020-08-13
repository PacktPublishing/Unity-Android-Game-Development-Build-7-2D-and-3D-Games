using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager instance;
	public int score;

	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		score = 0;
		PlayerPrefs.SetInt ("Score", 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void IncrementScore(){
		score++;
	}

	public void StopScore(){
		
		PlayerPrefs.SetInt ("Score", score);

		if (PlayerPrefs.HasKey ("HighScore")) {
			if (score > PlayerPrefs.GetInt ("HighScore")) {
				PlayerPrefs.SetInt ("HighScore", score);
			}
		} else {
			PlayerPrefs.SetInt ("HighScore", score);
		}

	}
}
