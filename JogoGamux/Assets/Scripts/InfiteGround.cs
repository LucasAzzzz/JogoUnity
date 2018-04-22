using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiteGround : MonoBehaviour {

	public GameObject Ground;
	public Transform GenerationPoint;

	private float GroundWidht;

	// Use this for initialization
	void Start () {

		GroundWidht = Ground.GetComponent<BoxCollider2D> ().size.x;

	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.x < GenerationPoint.position.x) {
		
			transform.position = new Vector3 (transform.position.x + GroundWidht, transform.position.y, transform.position.z);

			Instantiate (Ground, transform.position, transform.rotation);
		
		}

	}
}
