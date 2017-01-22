using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMove : MonoBehaviour {

	public float torque;
	public float speed;
	public float topspeed;
	public float toptorque;

	public GhostShip gs;
	private Vector2 myvel;
	private float myang;
	private Vector2 ghostvel;
	private float ghostang;

	public int maxHP;
	private int HP;

	private bool bubble;
	private int mercy;

	// Use this for initialization
	void Start () {
		HP = maxHP;
		bubble = false;
		mercy = 0;


		ghostvel = gs.GetComponent<Rigidbody2D> ().velocity;
		ghostang = gs.GetComponent<Rigidbody2D> ().angularVelocity;
	}

	public void Hit(){

		Debug.Log (HP);
		if (mercy > 0) {
		}
		else if (bubble) {
			bubble = false;
			GameObject image = gameObject.transform.FindChild ("Bubble(Clone)").gameObject;
			Destroy (image);
		} else {
			HP--;
			mercy = 100;
		}

		if (HP <= 0) {
			Lose ();
		}
	}

	void Lose(){
		Debug.Log ("You suck!");
	}


	public void Bubble(){
		bubble = true;
		GameObject image = Instantiate (Resources.Load ("bubble")) as GameObject;


		image.transform.parent = gameObject.transform;
		image.transform.localRotation = Quaternion.identity;
		image.transform.localPosition = Vector2.zero;
		image.transform.localScale = Vector2.one;


	}
	// Update is called once per frame
	void Update () {

		myvel = GetComponent<Rigidbody2D>().velocity - ghostvel;
		myang = GetComponent<Rigidbody2D> ().angularVelocity - ghostang;

		ghostvel = gs.GetComponent<Rigidbody2D> ().velocity;
		ghostang = gs.GetComponent<Rigidbody2D> ().angularVelocity;



		if (mercy > 0){
			mercy--;
	}

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

		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (transform.right.x * speed, transform.right.y * speed);// + gs.GetComponent<Rigidbody2D>().velocity;
		if (speed > topspeed) {
			Vector2 newvel = new Vector2 (topspeed * vel.x, topspeed * vel.y);
			gameObject.GetComponent<Rigidbody2D> ().velocity = newvel;


		}
		//gameObject.GetComponent<Rigidbody2D>().velocity


	}

}
