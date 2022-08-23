using UnityEngine;
using System.Collections;

public class EnemyCarSpawner : MonoBehaviour {

	public GameObject[] cars;
	public float delay = 0.5f;
	float timer;
	public float minPos;
	public float maxPos;
	Vector3 carPos;

	// Use this for initialization
	void Start () {
		timer = delay;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			carPos = new Vector3(Random.Range (minPos,maxPos),transform.position.y,0);
			int carNo = Random.Range (0,cars.Length - 1);
			Instantiate (cars[carNo], carPos, transform.rotation);
			timer = delay;
		}

	}




}
