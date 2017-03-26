using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


	public GameObject bulletPrefab;
	public GameObject targetPrefab;
	//public GameObject fireballPrefab;
	//public Impact impact;
	public Camera camMain;

	private GameObject newTarget;
	private GameObject newBullet;


	// Use this for initialization
	void Start () {


//		GameObject newTarget = Instantiate (targetPrefab);
//		GameObject newTarget = Instantiate(targetPrefab, new Vector3(0, 2.0f, 0), Quaternion.identity);
//
//		newTarget.transform.Rotate (0,90,0);

		//newTarget.SetActive (true);

		//Vector3 worldPosition;
//		Debug.Log ("position of " + newTarget.transform.position);
//		Debug.Log ("rotate of " + newTarget.transform.rotation);
//
//		Debug.Log("Start " + camMain.transform.position);

		//make new bullet
//		GameObject newBullet = Instantiate(bulletPrefab, new Vector3 (0,2.0f,-15), new Quaternion(0,90,90,1));

//		Debug.Log ("camera main rotate " + new Quaternion(0,90,90,1));

		//newBullet.transform.Rotate (-45,0,0);
		//newBullet.transform.position = new Vector3 (0,2.0f,-15);

//		newBullet.GetComponent<Rigidbody>().velocity = newBullet.transform.up * 5f;




//		camMain.transform.LookAt (newTarget.transform.position);




//		Debug.Log ("camMain"+ camMain.transform.position);
//		Debug.Log ("newTarget"+ newTarget.transform.position);

		for (int i = 0; i < 5; i++) {
			newTarget = Instantiate(targetPrefab, new Vector3(i * 2.0f, i * 2f, 0), Quaternion.identity);
			newTarget.transform.Rotate (0,90,0);
		}

	}






	
	// Update is called once per frame
	void Update () {
		//camMain.transform.position = camMain.transform.position;

		//Debug.Log("Update " + camMain.transform.position); 



//		if (!newTarget) {
//			newTarget = Instantiate(targetPrefab, new Vector3(0, 2.0f, 0), Quaternion.identity);
//			newTarget.transform.Rotate (0,90,0);
//		} 

//		if (!newBullet) {
////			newBullet = Instantiate (bulletPrefab, Camera.main.transform.position, new Quaternion (0, 90, 90, 1));
////			newBullet.GetComponent<Rigidbody> ().velocity = newBullet.transform.up * 5f;
//			GameObject newBullet = Instantiate (bulletPrefab);
//			newBullet.transform.position = transform.position;

			//Debug.Log ("position of canMain?" + Camera.main.transform.position);


//			Rigidbody rb = newBullet.GetComponent<Rigidbody>();
//			rb.velocity = Camera.main.transform.forward * 30;
//
//		}
//
		camMain.transform.LookAt (newTarget.transform.position);

		Debug.Log ("update canMain" + camMain.transform.position);

		//camMain.transform.position = camMain.transform.position;
		onMouseClick ();



	}

	void onMouseClick () {

		if (Input.GetMouseButtonDown (0)) {
			
			GameObject newBullet = Instantiate (bulletPrefab);
			newBullet.transform.position = Camera.main.transform.position;
			Rigidbody rb = newBullet.GetComponent<Rigidbody> ();
			rb.velocity = Camera.main.transform.forward * 30;
		}
	}







}
