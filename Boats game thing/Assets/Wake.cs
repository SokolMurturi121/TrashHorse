using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wake : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D col){


		Vector2 dir = (col.gameObject.transform.position - gameObject.transform.position);
		float dist = dir.x*dir.x + dir.y*dir.y;
		dir.Normalize ();

		if(dist>0) col.gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2(dir.x*2*1/dist,dir.y*2*1/dist));

	}


}
