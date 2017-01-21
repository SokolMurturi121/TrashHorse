using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wake : MonoBehaviour {

	public string string_dir;
	public float force;
	private Vector2 vector_dir;

	// Use this for initialization
	void Start () {
	


	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D col){

		switch (string_dir) {
		case "up":
			vector_dir = transform.up;
			break;
		case "down":
			vector_dir = -transform.up;
			break;
		case "back":
			vector_dir = -transform.right;
			break;
		default:
			vector_dir = transform.up;
			break;
		}

		Vector2 dir = (col.gameObject.transform.position - gameObject.transform.position);
		float dist = Mathf.Sqrt(dir.x*dir.x + dir.y*dir.y);

		if(dist>0) col.gameObject.GetComponent<Rigidbody2D> ().AddForce(vector_dir*force*1/dist);

			//(new Vector2(dir.x*2*1/dist,dir.y*2*1/dist));

	}


}
