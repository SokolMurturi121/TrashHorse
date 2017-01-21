using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

	public float force;
	public int timetolive;

	private int frames;

	// Use this for initialization
	void Start () {
		frames = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 s = gameObject.transform.localScale;

		gameObject.transform.localScale = new Vector3 (s.x * 1.02f, s.x * 1.02f, s.z * 1.02f);
		force = force * 0.980392f;

		frames++;
		if (frames >= timetolive)
			Destroy (this.gameObject);
	}

	void OnTriggerStay2D(Collider2D col){
		GameObject other = col.gameObject;
		Vector3 f =  other.transform.position - transform.position;
		f.Normalize ();
		f = f * force;

		other.GetComponent<Rigidbody2D> ().AddForce (f);

	}
}
