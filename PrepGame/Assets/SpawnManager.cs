using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

	public GameObject hazardRegular;
	public GameObject hazardHigh;
	public GameObject hazardLow;

	//public Vector3 startDestination;


	// Use this for initialization
	void Start () {
		StartCoroutine("spawnHazard");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator spawnHazard() {
		yield return new WaitForSeconds(Random.Range(2,10));
		//WaitForSeconds(Random.Range(0,3));
		int newHazard = Random.Range(1,4);
		switch(newHazard){
			case 1:
				// Instantiate the regular hazard
				Instantiate(hazardRegular,hazardRegular.transform.localPosition, hazardRegular.transform.localRotation);
				Debug.Log("Regular " + newHazard);
				break;
			case 2:
				// Instantiate the regular hazard
				Instantiate(hazardHigh,hazardHigh.transform.localPosition, hazardHigh.transform.rotation);
				Debug.Log("High " + newHazard);
				break;
			case 3:
				// Instatiate the regular hazard
				Instantiate(hazardLow, hazardLow.transform.localPosition, hazardLow.transform.localRotation);
				Debug.Log("Low " + newHazard);
				break;
			default:
				break;
		}

		StartCoroutine("spawnHazard");		

	}


}
