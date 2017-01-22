using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : Hazard {


	public int timetolive;
	private int time;

	// Use this for initialization
	void Start () {
		time = 0;	
	}
	
	// Update is called once per frame
	void Update () {
		time++;
		if (time > timetolive) {
			Destroy (gameObject);
		}
	}

	new protected void OnTriggerEnter2D(Collider2D col){
		base.OnTriggerEnter2D(col);
		if(col.gameObject.tag == "Player") Destroy (gameObject);


	}
}
