using UnityEngine;
using System.Collections;

public class FruitScript : MonoBehaviour {

	public GameObject cut1;
	public GameObject cut2;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Line") {

			GameObject c1 = Instantiate (cut1, transform.position, Quaternion.identity) as GameObject;

			GameObject c2 = Instantiate (cut2, new Vector3(transform.position.x - 2f, transform.position.y,0), cut2.transform.rotation) as GameObject;

			c1.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (2f, 2f),ForceMode2D.Impulse);
			c1.GetComponent<Rigidbody2D> ().AddTorque (Random.Range (-2f, 2f), ForceMode2D.Impulse);

			c2.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-2f, 2f),ForceMode2D.Impulse);
			c2.GetComponent<Rigidbody2D> ().AddTorque (Random.Range (-2f, 2f), ForceMode2D.Impulse);


			Destroy (gameObject);
		
		}
	
	}
}
