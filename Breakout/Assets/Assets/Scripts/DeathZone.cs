/* Brandon Riley
 * 4/2/2018
 * starts the Lose Life comand when ball falls beneath given area
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

	// starts the Lose Life comand when ball falls beneath given area
	void OnTriggerEnter (Collider col) {
		GM.instance.LoseLife(); 
	}
}
