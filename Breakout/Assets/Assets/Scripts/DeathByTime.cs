/* Brandon Riley
 * 4/2/2018
 * destroys object after a set amount of time
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathByTime : MonoBehaviour {

	public float destroyTime = 1f;

	// Use this for initialization
	// destroys object after a set amount of time
	void Start () {

		Destroy (gameObject, destroyTime);

	}
	
}