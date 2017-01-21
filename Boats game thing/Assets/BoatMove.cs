using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.W)) {
			this.gameObject.GetComponent<Rigidbody2D> ().AddForce (gameObject.transform.right * 60);
			Debug.Log ("hi");
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			gameObject.GetComponent<Rigidbody2D> ().AddTorque (1f);
		}

		if (Input.GetKeyDown (KeyCode.E)) {
			gameObject.GetComponent<Rigidbody2D> ().AddTorque (-1f);

		}

		//gameObject.GetComponent<Rigidbody2D>().velocity


	}

}
