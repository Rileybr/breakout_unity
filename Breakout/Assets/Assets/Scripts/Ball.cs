/* Brandon Riley
 * 4/2/2018
 * sets up ball and launches it with the click of a button
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float ballInitailVelocity = 600f;

	private Rigidbody rb;
	private bool ballInPlay;

	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	// starts moving the ball
	void Update () {
		if (Input.GetButtonDown ("Fire1") && ballInPlay == false) {
			transform.parent = null;
			ballInPlay = true;
			rb.isKinematic = false;
			rb.AddForce (new Vector3 (ballInitailVelocity, ballInitailVelocity, 0));
		}
	}
}
