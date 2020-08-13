using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	bool gameOver;


	void Awake(){
		DontDestroyOnLoad (this.gameObject);

		if (instance == null) {
			instance = this;
		} 
		else {
			Destroy (this.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		gameOver = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GameStart(){
		UiManager.instance.GameStart ();
		GameObject.Find ("PipeSpawner").GetComponent<PipeSpawner> ().StartSpawingPipes ();

	}

	public void GameOver(){
		gameOver = false;
		GameObject.Find ("PipeSpawner").GetComponent<PipeSpawner> ().StopSpawningPipes ();
		ScoreManager.instance.StopScore ();
		UiManager.instance.GameOver ();
		UnityAdManager.instance.ShowAd ();
	}
}
