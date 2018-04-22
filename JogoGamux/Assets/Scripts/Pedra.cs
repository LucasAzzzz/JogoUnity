using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedra : MonoBehaviour {

	public Rigidbody2D pedra;
	public Rigidbody2D estilingue;


	public float ReleaseTime = .15f;
	public float MaxDragDistance;

	private bool IsPressed = false;

	void Update()
	{
		if (IsPressed) {
			
			Vector2 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

			if (Vector3.Distance (mousePos, estilingue.position) > MaxDragDistance) {
				pedra.position = estilingue.position + (mousePos - estilingue.position).normalized * MaxDragDistance;
			} else {
				pedra.position = mousePos;
			}
		}
	}

	void OnMouseDown ()
	{

		IsPressed = true;
	
	}

	void OnMouseUp()
	{
		pedra.isKinematic = false;
		IsPressed = false;
		pedra.velocity = new Vector2 (pedra.velocity.x * 1000, pedra.velocity.y * 1000);
		StartCoroutine (Release ());
	}

	IEnumerator Release()
	{
		yield return new WaitForSeconds (ReleaseTime);

		GetComponent<SpringJoint2D> ().enabled = false;
	}


}
