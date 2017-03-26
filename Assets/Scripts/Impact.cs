using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour {

	public GameObject fireballPrefab;



	public void OnCollisionEnter (Collision col)
	{
//		Debug.Log (col.gameObject);


//		if(col.gameObject.name == true)
//		{
//			Debug.Log ("testing");

		Destroy(this.gameObject);
		Destroy(col.gameObject);


		//GameObject newFireball = Instantiate (fireballPrefab, col.transform.position, Quaternion.Euler(270,0,0));
		// GameObject newFireball = Instantiate (fireballPrefab, col.transform.position, col.transform.LookAt(Camera.main));
		//newFireball.GetComponent<Rigidbody>().velocity = newFireball.transform.up * 5f;

//		Debug.Log ("col.position?" + col.transform.position);

		GameObject newFireball = Instantiate (fireballPrefab);
		newFireball.transform.position = transform.position;

		Debug.Log ("position of canMain?" + Camera.main.transform.position);


		Rigidbody rb = newFireball.GetComponent<Rigidbody>();

		rb.velocity = Camera.main.transform.forward * -30;

		//Debug.Log ("forward" + Camera.main.transform.forward);








//		}
	}







}
