using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapBack : MonoBehaviour {

	public bool x;
	public bool y;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.layer == 8 || col.gameObject.layer == 9) {
			Vector2 pos = col.gameObject.transform.position;
			col.gameObject.transform.position = new Vector2 (x ? (pos.x<0?9.1f:-9.1f) : pos.x, y ?  (pos.y<0?5.1f:-5.1f) : pos.y);


		}
	}
}
