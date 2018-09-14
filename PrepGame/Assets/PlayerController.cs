using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	[SerializeField]
	private int lane;
	// 0 == left lane, 1 = midlane, 2 == right lane

	//private Rigidbody playerRigidBody;

	private Animator playerAnimator;

	// Use this for initialization
	void Start () {


		lane = 1;

		//playerRigidBody = GetComponent<Rigidbody>();
		playerAnimator = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	    void Update () {

        // Go Left
        if (Input.GetKeyDown(KeyCode.A) && lane !=0)
        {
            //playerAnimator.applyRootMotion = true;
            //float newPosition = transform.position.x - 1.2f;
            //newPosition = Mathf.Clamp(newPosition, -1.2f,1.2f);
            //Vector3 newPositionVector = new Vector3(transform.position.x - 1.2)
            //transform.position = new Vector3(newPosition, transform.position.y,transform.position.z);
            //playerRigidBody.MovePosition(new Vector3(newPosition, transform.position.y,transform.position.z)* 1 * Time.deltaTime);
            playerAnimator.SetTrigger("GoLeft");
			lane -=1;
            Debug.Log("PressedA");
        }
       
		/* 
        if (Input.GetKeyUp(KeyCode.A))
        {
            playerAnimator.applyRootMotion = false;
			playerAnimator.SetTrigger("GoLeft");
			
        }
		*/

        // Go Right
        if (Input.GetKeyDown(KeyCode.D) && lane != 2)
        {
			playerAnimator.SetTrigger("GoRight");
			lane+=1;
           
        }

       
        // Vault 
        if (Input.GetKeyDown(KeyCode.W))
        {
			playerAnimator.SetTrigger("Vault");
			/* 
            playerAnimator.applyRootMotion = true;
            //transform.position = new Vector3(transform.position.x, .5f,transform.position.z);
            float newPosition = transform.position.y + 0.5f;
            newPosition = Mathf.Clamp(newPosition, transform.position.y, 1f);
            transform.position = new Vector3 (transform.position.x, newPosition, transform.position.z);
            //playerRigidBody.MovePosition(new Vector3(transform.position.x, newPosition,transform.position.z) * 1 * Time.deltaTime);
            transform.Rotate(20f,0f,0f);
			*/
            
        }

        // Slide
        if (Input.GetKeyDown(KeyCode.S))
        {
			playerAnimator.SetTrigger("Slide");

        }


    }




	
}
