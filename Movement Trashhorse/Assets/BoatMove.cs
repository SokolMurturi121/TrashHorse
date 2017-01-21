using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMove : MonoBehaviour {

	public float torque;
	public float topspeed;
	public float toptorque;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 vel = gameObject.GetComponent<Rigidbody2D> ().velocity;
		float speed = Mathf.Sqrt (vel.x * vel.x + vel.y * vel.y);
		Vector3 pos = gameObject.transform.position;




	

		if (Input.GetKey (KeyCode.W)) {
			this.gameObject.GetComponent<Rigidbody2D> ().AddForce (gameObject.transform.right * 10);
		}

		if (Input.GetKey (KeyCode.A)) {
			gameObject.GetComponent<Rigidbody2D> ().AddTorque (torque);
		}

		if (Input.GetKey(KeyCode.D)) {
			gameObject.GetComponent<Rigidbody2D> ().AddTorque (-torque);

		}

		vel.Normalize ();

		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (transform.right.x * speed, transform.right.y * speed);
		if (speed > topspeed) {
			Vector2 newvel = new Vector2 (topspeed * vel.x, topspeed * vel.y);
			gameObject.GetComponent<Rigidbody2D> ().velocity = newvel;

		}
		//gameObject.GetComponent<Rigidbody2D>().velocity


	}

}
