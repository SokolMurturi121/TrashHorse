using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour {


	public float knockback;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	protected void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			col.gameObject.GetComponent<BoatMove> ().Hit ();


			/**Vector2 dir = (col.gameObject.transform.position - gameObject.transform.position).normalized;
			Vector2 force = new Vector2 (dir.x * knockback, dir.y * knockback);

			Debug.Log (force.x + "    " + force.y);

			//col.gameObject.
			GameObject.Find("BoatControl").GetComponent<Rigidbody2D> ().AddForce (force, ForceMode2D.Impulse);*/


		}


	}
}
