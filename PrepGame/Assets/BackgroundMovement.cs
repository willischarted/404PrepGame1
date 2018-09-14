using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour {

	private Rigidbody rigidBody;

	public Vector3 destinationVector;

	public float speed;
	

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		if (rigidBody == null){
			Debug.Log("could not find rigidbody");
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		if (Vector3.Distance(transform.position,destinationVector) > 0.5f)
		{
			//transform.localPosition = Vector3.MoveTowards(transform.position, destinationVector, speed * Time.deltaTime);
			
			rigidBody.MovePosition((transform.position) + (new Vector3(0f,0f,-1f)* speed * Time.deltaTime));
		}

		else
		{
		
			Destroy(this.gameObject);

		}
		
		

	}
}
