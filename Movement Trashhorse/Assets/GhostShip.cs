using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostShip : MonoBehaviour {

	public BoatMove bm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.transform.position = bm.transform.position;
		gameObject.transform.rotation = bm.transform.rotation;

	}
}
