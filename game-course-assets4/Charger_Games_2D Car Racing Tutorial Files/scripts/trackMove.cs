using UnityEngine;
using System.Collections;

public class trackMove : MonoBehaviour {

	public float speed = 1.5f;
	Vector2 offset;


	

	
	void Start () {
		#if UNITY_ANDROID
		speed = 0.5f;
		#endif

		#if UNITY_STANDALONE_WIN
		speed = 1.5f;
		#endif 
	}
	

	void Update () {
		offset = new Vector2 (0, Time.time * speed);

		GetComponent<Renderer> ().material.mainTextureOffset = offset;
	}
}
