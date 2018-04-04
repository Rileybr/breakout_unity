/* Brandon Riley
 * 4/2/2018
 * destroys brick once the ball has collided with it
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {

	public GameObject brickParticle;

	// destroys brick once the ball has collided with it
	void OnCollisionEnter (Collision other){
		Instantiate (brickParticle, transform.position, Quaternion.identity);
		GM.instance.DestroyBrick ();
		Destroy(gameObject);
	}
}
