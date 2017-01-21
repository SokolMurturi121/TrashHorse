using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 s = gameObject.transform.localScale;

		gameObject.transform.localScale = new Vector3 (s.x * 1.02f, s.x * 1.02f, s.z * 1.02f);
	}
}
