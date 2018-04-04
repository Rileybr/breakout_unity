/* Brandon Riley
 * 4/2/2018
 * Controlls the game, starts the game, sets up bricks and paddle, checks if you have enough lives left and shows gameover or you win screens
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {

	public int lives = 3;
	public int bricks = 20;
	public float resetDelay = 1f;
	public Text livesText;
	public GameObject gameOver;
	public GameObject youWon;
	public GameObject bricksPrefab;
	public GameObject paddle;
	public GameObject deathParticles;
	public static GM instance = null;

	private GameObject clonePaddle;

	// Use this for initialization
	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != null)
			Destroy (gameObject);

		SetUp ();
	}

	// sets up paddle and bricks for the game
	public void SetUp (){
		clonePaddle = Instantiate (paddle, transform.position, Quaternion.identity) as GameObject;
		Instantiate (bricksPrefab, transform.position, Quaternion.identity);
	}

	// checks if all the bricks are gone
	void CheckGameOver (){
		if (bricks < 1) {
			// youWon.SetActive(true); 
			// Time.timeScale = .25f;
			// Invoke ("Reset", resetDelay);
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
		}
		// if you run out of lives it changes scene to game over scene
		if (lives < 1) {
			// gameOver.SetActive(true);
			// Time.timeScale = .25f;
			// Invoke ("Reset", resetDelay);
			SceneManager.LoadScene ("GameOver");
		}
	}

	void Reset (){
		Time.timeScale = 1f;
		Application.LoadLevel (Application.loadedLevel);
	}

	// takes away one life if the ball goes beneath the paddle
	public void LoseLife (){
		lives--;
		livesText.text = "Lives: " + lives;
		Instantiate (deathParticles, clonePaddle.transform.position, Quaternion.identity);
		Destroy (clonePaddle);
		Invoke ("SetupPaddle", resetDelay);
		CheckGameOver ();
	}

	// spawns in the paddle and ball in the center of the bottom of the screen
	void SetupPaddle (){
		clonePaddle = Instantiate (paddle, transform.position, Quaternion.identity) as GameObject;
	}

	// destroys brick when hit by ball
	public void DestroyBrick (){
		bricks--;
		CheckGameOver ();
	}
}
