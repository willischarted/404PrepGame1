using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardMovement : MonoBehaviour {
	//class controlling hazrds

	public Vector3 destinationVector;

	public float speed;

	public bool hasCollided;
	public bool hasEvaded;

	private GameObject scoreManager;
	private ScoreManager scoreManagerScript;

	private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		
		//speed = 1.0f;
		hasCollided = false;
		hasEvaded = false;

		rigidBody = GetComponent<Rigidbody>();
		if (rigidBody == null){
			Debug.Log("could not find rigidbody");
		}
		scoreManager = GameObject.Find("ScoreManager");
		if (scoreManager == null)
			Debug.Log("Could not find scoreManager");

		scoreManagerScript = scoreManager.GetComponent<ScoreManager>();
		if (scoreManagerScript == null)
			Debug.Log("Could not find scoreManagerScript");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Vector3.Distance(transform.position,destinationVector) > 0.5f)
		{
			//transform.localPosition = Vector3.MoveTowards(transform.position, destinationVector, speed * Time.deltaTime);
			
			rigidBody.MovePosition((transform.position) + (new Vector3(0f,0f,-1f)* speed * Time.deltaTime));
		}

		else
		{
			if (hasCollided){
				scoreManagerScript.endGame();
			}
			if (!hasCollided && hasEvaded)
			{
				//update score text with point value for dodging
				scoreManagerScript.updateScore(10);
			}

			// Cleanup: Destroy this gameobject
			Destroy(this.gameObject);

		}
		
		

	}


	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player"){
			hasCollided = true;
			Debug.Log("Player collider collision registered");
		}
		else if (other.tag == "LaneTrigger"){
			hasEvaded = true;
		}
		else {
			Debug.Log("Otherwise");
			return;
		}


	}

	
}
