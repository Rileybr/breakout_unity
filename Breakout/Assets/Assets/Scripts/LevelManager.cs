/* Brandon Riley
 * 4/2/2018
 * Loads main scene, and quits if the quit button is pressed
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// loads the main scene
	public void StartGame (){
		SceneManager.LoadScene ("Main");
	}

	// quits game if button is pressed
	public void QuitGame (){
		Application.Quit ();
	}
}
