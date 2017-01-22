using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour {

	public delegate void destroyEvent();
	public  event destroyEvent destroyed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDestroy(){
		if (destroyed != null)
			destroyed();
	}
}
