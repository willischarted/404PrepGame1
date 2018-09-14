using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

	public int currentScore;
	private int topScore;

	public Text scoreText;


	/* 
	public GameObject player;
	private PlayerController playerController;
	*/


	// Use this for initialization
	void Start () {
		getScore();
		currentScore = 0;
		updateScore(currentScore);

		/* 
		playerController = player.GetComponent<PlayerController>();
		if (playerController == null){
			Debug.Log("Could not find playerController");
		}
		*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void updateScore(int value) {
		currentScore += value;
		scoreText.text = "Score: " + currentScore;
	}

	void saveScore() {
		
		PlayerPrefs.SetInt("LastScore",currentScore);
		
		if (currentScore > topScore)
		{
			topScore = currentScore;
			PlayerPrefs.SetInt("Score",topScore);
		}
		else
			return;
	}

	void getScore(){
		topScore = PlayerPrefs.GetInt("Score",0);
	}

	public void endGame(){
		
		saveScore();

		
		SceneManager.LoadScene("Menu", LoadSceneMode.Single);
	}
}
