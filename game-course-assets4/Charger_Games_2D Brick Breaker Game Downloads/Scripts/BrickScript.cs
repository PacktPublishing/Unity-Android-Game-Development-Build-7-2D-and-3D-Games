using UnityEngine;
using System.Collections;

public class BrickScript : MonoBehaviour {

	public UiManager ui;
	// Use this for initialization
	void Start () {
		ui = GameObject.FindWithTag ("ui").GetComponent<UiManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Ball") {
			ui.IncrementScore ();
			Destroy (gameObject);

		}


	}
}
