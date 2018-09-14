using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour {

	public GameObject backgroundLeft;
	public GameObject backgroundRight;


	// Use this for initialization
	void Start () {
		Instantiate(backgroundLeft, backgroundLeft.transform.position, backgroundRight.transform.rotation);
		Instantiate(backgroundRight, backgroundRight.transform.position, backgroundRight.transform.rotation);
		StartCoroutine("spawnBackground");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator spawnBackground() {
		yield return new WaitForSeconds(Random.Range(1,4));
		Instantiate(backgroundLeft, backgroundLeft.transform.position, backgroundRight.transform.rotation);
		Instantiate(backgroundRight, backgroundRight.transform.position, backgroundRight.transform.rotation);
		StartCoroutine("spawnBackground");
	}
}
