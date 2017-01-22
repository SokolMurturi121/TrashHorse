using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubbler : Powerup {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	protected override void PowerEffect(Collision2D col){
		if (col.gameObject.tag == "Player") {
			BoatMove boat = col.gameObject.GetComponent<BoatMove> ();
			boat.Bubble ();
			}
		}
	}

