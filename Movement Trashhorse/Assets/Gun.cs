using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Hazard {

	public int firedelay;
	public int firerandom;
	public float firespeed;
	public int shottimetolive;





	private int count;
	private int tcount;

	// Use this for initialization
	void Start () {
		Reload ();
	}

	void Reload(){
		count = 0;
		tcount = firedelay + Random.Range (0, firerandom);
	}

	// Update is called once per frame
	void Update () {
		count++;
		if (count >= tcount) {
			Fire ();
		}
	}



	void Fire(){

		GameObject target = GameObject.Find ("Boat");

		Vector2 dir = (target.transform.position - gameObject.transform.position).normalized;

		GameObject shot = Instantiate (Resources.Load ("Shot")) as GameObject;
		shot.GetComponent<Shot> ().timetolive = shottimetolive;
		shot.transform.position = gameObject.transform.position;
		shot.GetComponent<Rigidbody2D> ().AddForce (dir * firespeed,ForceMode2D.Impulse);

		Reload ();
	}
}
