using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuController : MonoBehaviour {

	public Text topScore;
	public Text lastScore;
	
	// Use this for initialization
	void Start () {
		int savedTopScore = PlayerPrefs.GetInt("Score",0);
		int savedLastScore = PlayerPrefs.GetInt("LastScore",0);	

		topScore.text = "High Score: " + savedTopScore;
		lastScore.text = "You Scored: " + savedLastScore;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startGame() {
		Debug.Log("StartGame");
		SceneManager.LoadScene("Main", LoadSceneMode.Single);
	}
}
