using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	public GameObject scientist; 

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Crate") {
			Debug.Log("message"); 
			scientist.GetComponent<Player>().hasGun = true; 
		}
	}
}
