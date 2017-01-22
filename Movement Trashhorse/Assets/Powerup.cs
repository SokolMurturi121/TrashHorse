using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Powerup : Destroyable {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.layer == 8) {
			
			PowerEffect (col);
			Destroy (gameObject);
		}
	}

	protected abstract void PowerEffect (Collision2D col);
}
