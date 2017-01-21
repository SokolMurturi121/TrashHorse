using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float x = gameObject.GetComponent<Rigidbody2D> ().velocity.x;
		float y = gameObject.GetComponent<Rigidbody2D> ().velocity.y;
		//if (x ^ 2 + y ^ 2 > 10) {
		//GameObject w = Instantiate(Resources.Load("waves")) as GameObject;
		//w.transform.position = gameObject.transform.position;
		//}

		if (Input.GetKeyDown (KeyCode.W)) {
			this.gameObject.GetComponent<Rigidbody2D> ().AddForce (gameObject.transform.right * 60);
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			gameObject.GetComponent<Rigidbody2D> ().AddTorque (1f);
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			gameObject.GetComponent<Rigidbody2D> ().AddTorque (-1f);

		}

		//gameObject.GetComponent<Rigidbody2D>().velocity


	}

}
